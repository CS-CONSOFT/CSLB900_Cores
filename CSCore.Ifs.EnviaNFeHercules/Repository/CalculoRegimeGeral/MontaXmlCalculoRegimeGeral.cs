using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.DD._04X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto;
using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.Dto.RequestResponseExternaAPI;
using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto;
using CSCore.Ifs.EnviaNFeHercules.Repository.CalculoRegimeGeral.StrategyCalculaImposto.Dtos;
using CSLB900.MSTools.ConsomeAPI;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Service.CalculoRegimeGeral
{
    public interface IMontaXmlCalculoRegimeGeral
    {
        Task<string> CSRF01_Calculadora_OffLine_MontaDD040(string InNotaID_DD040, int TenantID);
    }
    public sealed class MontaXmlCalculoRegimeGeral: IMontaXmlCalculoRegimeGeral
    {
        private readonly AppDbContext _context;
        private readonly IConsumirAPIExterna _consumirAPIExterna;
        private const string _URL_BASE_CalculadoraSophiaerpCloud = "https://calculadora.sophiaerp.cloud/api/calculadora";
        private enum TipoEstaticas
        {
            csicp_bb001_TpTri
        }

        public MontaXmlCalculoRegimeGeral(AppDbContext context, IConsumirAPIExterna consumirAPIExterna)
        {
            _context = context;
            this._consumirAPIExterna = consumirAPIExterna;
        }

        public async Task<string> CSRF01_Calculadora_OffLine_MontaDD040(string InNotaID_DD040, int TenantID)
        {
            var nota = await this.GetNota(InNotaID_DD040, TenantID) ?? throw new KeyNotFoundException("Nota não encontrada.");
            var produtos = await this.GetProds_DD060(InNotaID_DD040, nota.Bb012_RFEspecial_ID, TenantID);

            var estaticasTpTri = this.GetTpTriIdEstaticas("Simples");
            var aa037_pis = this.GetCsicp_aa037_Imp("PIS");
            var aa037_cofins = this.GetCsicp_aa037_Imp("COFINS");
            var aa037_iss = this.GetCsicp_aa037_Imp("ISS");
            var aa037_icms = this.GetCsicp_aa037_Imp("ICMS");
            var aa037_II = this.GetCsicp_aa037_Imp("Imposto Importação");
            var NFCe = this.Getcsicp_dd040_TNt("NFCe");
            var estatica_sim = this.GetEstatica("SIM");

            var notaParaMontagem = new CSICP_DD040();

            /*como pegar o total liquido da dd060?*/
            var VlrBaseCalcImposto = 0m;
            foreach (var produto in produtos)
            {
                 var enumTipoCalculoImposto = StrategyCalculaImpostoBase.GetEnumTipoCalculoImposto(
                    produto.GetProds_DD061_Imposto_ID, aa037_icms, aa037_pis, aa037_cofins, aa037_iss, aa037_II);

                 VlrBaseCalcImposto = StrategyCalculaImpostoBase.GetTipoCalculoImposto(
                    enumTipoCalculoImposto, produto.GetProds_DD061_ValorImposto, VlrBaseCalcImposto,
                    produto.dd061Vicmsufdest, produto.dd061Vfcp, produto.dd061Vfcpufdest, produto.n39Vicmsmono
                    );
            }

            var listDtoWorkItensRecord = new List<DtoWorkItensRecord>();
            PercorreProdutosEPopulaListaParaEnviarNaAPIDeCalculoRegimeGeral(listDtoWorkItensRecord, nota, produtos, notaParaMontagem, VlrBaseCalcImposto);

            var request = new DtoRequest_Postregimegeral(nota.ID!, "0.0.1", nota.DD040_Data_Emissao, 1, "", listDtoWorkItensRecord);

            var response = await ConsumindoAPI_CalculoRegimeGeral(request);
            var xmlOfflineGerado = await ConsumindoAPI_GerarXML_OffLine(nota, NFCe, response);
            return xmlOfflineGerado is null ? throw new Exception("Erro ao gerar XML OffLine.") : xmlOfflineGerado;
        }




        #region Metodos Privados
        private async Task<string?> ConsumindoAPI_GerarXML_OffLine(DtoGetNotaDD040 nota, int NFCe, DtoResponse_PostRegimeGeral? request)
        {
            if (request == null) return null;
            var dictQueryParams = new Dictionary<string, object>
            {
                { "tipo", nota.TipoNotaID == NFCe ? "nfce" : "nfe" }
            };
            var response = await _consumirAPIExterna
                .Post<string, DtoResponse_PostRegimeGeral>
                (_URL_BASE_CalculadoraSophiaerpCloud, "xml/generate", request, dictQueryParams);

            return response;
        }

        private async Task<DtoResponse_PostRegimeGeral?> ConsumindoAPI_CalculoRegimeGeral(DtoRequest_Postregimegeral request)
        {
            return await _consumirAPIExterna
                            .Post<DtoResponse_PostRegimeGeral, DtoRequest_Postregimegeral>
                            (_URL_BASE_CalculadoraSophiaerpCloud, "regime-geral", request);
        }



        private static void PercorreProdutosEPopulaListaParaEnviarNaAPIDeCalculoRegimeGeral(List<DtoWorkItensRecord> listDtoWorkItensRecord, DtoGetNotaDD040 nota, ICollection<DtoGetProdutosDD060> produtos, CSICP_DD040 notaParaMontagem, decimal VlrBaseCalcImposto)
        {
            foreach (var produto in produtos)
            {
                if (nota.TpDebCreVazio()) notaParaMontagem.DD040_TPDEBCREID = produto.Out_Reg_bb027_Imp?.Bb027bTpdebcreid;
                listDtoWorkItensRecord.Add(
                    new DtoWorkItensRecord(
                        produto.dd060Sequencia,
                        produto.gg021Ncm,
                        "",
                        produto.Get_AA144cClassTrib_cstibsCbs.ToString(),
                        produto.Get_AA144cClassTrib_cclasstrib.ToString(),
                        VlrBaseCalcImposto,
                        produto.dd060Quantidade,
                        produto.gg007Unidade,
                        new ImpostoSeletivoDto(
                            produto.Out_Reg_AA144_cClasTrib_IS?.CstibsCbs.ToString(),
                            VlrBaseCalcImposto < 0 ? VlrBaseCalcImposto * -1 : VlrBaseCalcImposto,
                            produto.dd060Quantidade,
                            produto.gg007Unidade,
                            0m,
                            produto.Out_Reg_AA144_cClasTrib_IS?.Cclasstrib.ToString()),
                        new TributacaoRegularDto(
                            "000",
                            "000000"
                            ))
                    );
            }
        }
        private int GetTpTriIdEstaticas(string Label)
        {
            var items = this._context.E9ACSICP_BB001Tptris
                .Where(e => e.Label == Label)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstOrDefault();

            return items;
        }
        private int GetCsicp_aa037_Imp(string Label)
        {
            var items = this._context.E9ACSICP_AA037Imps
                .Where(e => e.Label == Label)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstOrDefault();

            return items;
        }

        private int Getcsicp_dd040_TNt(string Label)
        {
            var items = this._context.OsusrTeiCsicpDd040Tnts
                .Where(e => e.Label == Label)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstOrDefault();

            return items ?? -1;
        }
        private int GetEstatica(string Label)
        {
            var items = this._context.E9ACSICP_Statica
                .Where(e => e.Label == Label)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstOrDefault();

            return items;
        }
        private async Task<DtoGetNotaDD040?> GetNota(string InNotaID_DD040, int TenantID)
        {
            var query = from dd040 in this._context.OsusrTeiCsicpDd040s
                        where dd040.TenantId == TenantID && dd040.Dd040Id == InNotaID_DD040

                        join CSICP_DD040Tnt in this._context.OsusrTeiCsicpDd040Tnts
                        on dd040.Dd040TiponotaId equals CSICP_DD040Tnt.Id

                        join NavBB001 in this._context.E9ACSICP_BB001s
                        on dd040.Dd040Empresaid equals NavBB001.Id into bb001Group
                        from NavBB001 in bb001Group.DefaultIfEmpty()

                        join NavBB001CfgFis in this._context.E9ACSICP_BB001Cfgfis
                        on NavBB001.Id equals NavBB001CfgFis.Bb001EmpresaId into bb001CfgfiGroup
                        from NavBB001CfgFis in bb001CfgfiGroup.DefaultIfEmpty()

                        join NavBB01206 in this._context.OsusrE9aCsicpBb01206s
                        on dd040.Dd040ContaId equals NavBB01206.Bb012Id into bb01206Group
                        from NavBB01206 in bb01206Group.DefaultIfEmpty()

                        join NavBB012 in this._context.OsusrE9aCsicpBb012s
                        on dd040.Dd040ContaId equals NavBB012.Id into bb012Group
                        from NavBB012 in bb012Group.DefaultIfEmpty()

                        join NavAA028 in this._context.OsusrE9aCsicpAa028s
                        on NavBB01206.Bb012CodigoCidade equals NavAA028.Id into aa028Group
                        from NavAA028 in aa028Group.DefaultIfEmpty()

                        join NavAA027 in this._context.OsusrE9aCsicpAa027s
                        on NavBB01206.Bb012Uf equals NavAA027.Id into aa027Group
                        from NavAA027 in aa027Group.DefaultIfEmpty()


                        select new DtoGetNotaDD040(
                            NavBB001CfgFis.Bb001TptributacaoId,
                            NavBB012.bb012_RFEspecial_ID,
                            dd040.DD040_TPDEBCREID,
                            dd040.Dd040Id,
                            dd040.Dd040DataEmissao,
                            dd040.Dd040TiponotaId);
            return await query.AsNoTracking().FirstOrDefaultAsync();
        }

        private async Task<ICollection<DtoGetProdutosDD060>> GetProds_DD060(string InNotaID_DD040, string? In_Bb012_RFEspecial_ID, int TenantID)
        {
            var query = from gg520 in this._context.OsusrE9aCsicpGg520s.AsNoTracking()

                        join dd060 in this._context.OsusrTeiCsicpDd060s
                        on gg520.Id equals dd060.Dd060Saldoid into dd060Group
                        from dd060 in dd060Group.DefaultIfEmpty()

                        join gg008Kdx in this._context.OsusrE9aCsicpGg008Kdxes
                        on gg520.Gg520KardexId equals gg008Kdx.Gg008Kardexid into gg008KdxGroup
                        from gg008Kdx in gg008KdxGroup.DefaultIfEmpty()

                        join gg008 in this._context.OsusrE9aCsicpGg008s
                        on gg008Kdx.Gg008Produtoid equals gg008.Id into gg008Group
                        from gg008 in gg008Group.DefaultIfEmpty()

                        join dd061 in this._context.OsusrTeiCsicpDd061s
                        on dd060.Dd060Id equals dd061.Dd060Id into dd061Group
                        from dd061 in dd061Group.DefaultIfEmpty()

                        join gg021 in this._context.OsusrE9aCsicpGg021s
                        on gg008.Gg008Ncmid equals gg021.Id into gg021Group
                        from gg021 in gg021Group.DefaultIfEmpty()

                        join gg007 in this._context.OsusrE9aCsicpGg007s
                        on dd060.Dd060UnId equals gg007.Id into gg007Group
                        from gg007 in gg007Group.DefaultIfEmpty()

                        join bb027Imp_full in this._context.OsusrE9aCsicpBb027Imps
                        on dd060.DD060_RFTRANSACAO_ID equals bb027Imp_full.Bb027Id into bb027ImpFullGroup
                        from bb027Imp_full in bb027ImpFullGroup.DefaultIfEmpty()
                        where bb027Imp_full.Bb027bRflcId == In_Bb012_RFEspecial_ID

                        join Get_Regra in this._context.OsusrE9aCsicpBb027Imps
                        on dd060.DD060_RFTRANSACAO_ID equals Get_Regra.Bb027Id into bb027Group
                        from Get_Regra in bb027Group.DefaultIfEmpty()
                        where Get_Regra.Bb027bUfDestId == null 
                        && Get_Regra.Bb027bClassecontaId == null
                        && Get_Regra.Bb027bMp255Id == null
                        && Get_Regra.Bb027bMotdesoneracaoid == null
                        && Get_Regra.Bb027bRflcId == null


                        join Get_AA144cClassTrib in this._context.OsusrE9aCsicpAa144s
                        on bb027Imp_full.Bb027bRfclasstribId equals Get_AA144cClassTrib.Id into aa144Group
                        from Get_AA144cClassTrib in aa144Group.DefaultIfEmpty()

                        join Get_AA144cClassTrib_IS in this._context.OsusrE9aCsicpAa144s
                        on bb027Imp_full.Bb027bIsRfclasstribId2 equals Get_AA144cClassTrib_IS.Id into aa144Group_is
                        from Get_AA144cClassTrib_IS in aa144Group_is.DefaultIfEmpty()

                        where gg520.TenantId == TenantID && dd060.Dd040Id == InNotaID_DD040
                        where dd060.Dd060Isfixarcalcimp == false

                        select new DtoGetProdutosDD060(
                            bb027Imp_full != null,
                            Get_Regra,
                            Get_AA144cClassTrib,
                            Get_AA144cClassTrib_IS,
                            dd061.Dd061ImpostoId,
                            dd061.Dd061Valorimposto,

                            dd060.Dd060Sequencia,
                            gg021.Gg021Ncm,
                            Get_AA144cClassTrib.CstibsCbs,
                            Get_AA144cClassTrib.Cclasstrib,
                            dd060.Dd060Quantidade,
                            gg007.Gg007Unidade,
                            Get_AA144cClassTrib_IS.CstibsCbs,
                            Get_AA144cClassTrib_IS.Cclasstrib,

                            dd061.Dd061Vicmsufdest,
                            dd061.Dd061Vfcp,
                            dd061.Dd061Vfcpufdest,
                            dd061.N39Vicmsmono,
                            dd060.Dd060TotalLiquido
                            );

            return await query.ToListAsync();
        }
        #endregion
    }
}
