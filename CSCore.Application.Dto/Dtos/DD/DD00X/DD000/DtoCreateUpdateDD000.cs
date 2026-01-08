using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.DD.DD00X.DD000
{
    public class DtoCreateUpdateDD000 : IConverteParaEntidade<CSICP_DD000>
    {
        public string? Dd000FilialId { get; set; }

        public string? Dd000PvCcustoId { get; set; }

        public string? Dd000PvAgcobradorId { get; set; }

        public string? Dd000PvNatoperacaoId { get; set; }

        public string? Dd000PvContaId { get; set; }

        public string? Dd000CtrlSerieNfId { get; set; }

        public string? Dd000CtrlSerieCfId { get; set; }

        public string? Dd000CtrlSerieNfceId { get; set; }

        public string? Dd000PdCcustoId { get; set; }

        public string? Dd000PdAgcobradorId { get; set; }

        public string? Dd000PdNatoperacaoId { get; set; }

        public string? Dd000PdvCcustoId { get; set; }

        public string? Dd000PdvAgcobradorId { get; set; }

        public string? Dd000PdvNatoperacaoId { get; set; }

        public string? Dd000CtCcustoId { get; set; }

        public string? Dd000CtAgcobradorId { get; set; }

        public string? Dd000CtNatoperacaoId { get; set; }

        public int? Dd000Qtddiasvalcotacao { get; set; }

        public int? Dd000Qtddiasvalprevenda { get; set; }

        public int? Dd000Qualregraaplicar { get; set; }

        public int? Dd000AmbNfeId { get; set; }

        public int? Dd000VersaoNfeId { get; set; }

        public int? Dd000LcertdigitalId { get; set; }

        //public byte[]? Dd000Arqcertdigitalbinario { get; set; }

        public string? Dd000Arqcertdigital { get; set; }

        public string? Dd000Senhacertdigital { get; set; }

        public string? Dd000NdCcustoId { get; set; }

        public string? Dd000NdAgcobradorId { get; set; }

        public string? Dd000NdNatoperacaoId { get; set; }

        public string? Dd000DcCcustoId { get; set; }

        public string? Dd000DcAgcobradorId { get; set; }

        public string? Dd000DcNatoperacaoId { get; set; }

        public string? Dd000DisCcustoId { get; set; }

        public string? Dd000DisAgcobradorId { get; set; }

        public string? Dd000DisNatoperacaoId { get; set; }

        public int? Dd000ZonetimeId { get; set; }

        public string? Dd000CpCcustoId { get; set; }

        public string? Dd000CpAgcobradorId { get; set; }

        public string? Dd000CpCondpagtoId { get; set; }

        public string? Dd000CpFormapagtoId { get; set; }

        public int? Dd000CpDiaVencto { get; set; }

        public string? Dd000UfOrgaoId { get; set; }

        public int? Dd000Qtddiasvaletiq { get; set; }

        public bool? Dd000NfeConjugada { get; set; }

        public int? Dd000OrigPcomissaoId { get; set; }

        public int? Dd000FormaPcomId { get; set; }

        public string? Dd000Comespecieid { get; set; }

        public bool? Dd000NfsIsmultiplo { get; set; }

        public int? Dd000NfsPadraoId { get; set; }

        public int? Dd000NfsRegesptribId { get; set; }

        public int? Dd000NfsOtpsnId { get; set; }

        public int? Dd000NfsInccultId { get; set; }

        public string? Dd000NfsCodintegrcliente { get; set; }

        public string? Dd000NfsUrlWsInvoicy { get; set; }

        public string? Dd000NfsAlvaraempresa { get; set; }

        public int? Dd000NfsNatop { get; set; }

        public string? Dd000PdvWebRptNfceId { get; set; }

        public string? Dd000PdvWebRptNfeId { get; set; }

        public string? Dd000PdvWebRptNfId { get; set; }

        public string? Dd000Tokenacessows { get; set; }

        public bool? Dd000Isenviows { get; set; }

        public bool? Dd000Isusaambiente { get; set; }

        public bool? Dd000Isusaprojeto { get; set; }

        public decimal? Dd000Vmetadiamonitor { get; set; }

        public decimal? Dd000Qmetadiamonitor { get; set; }

        public bool? Dd000Iscomissaogerente { get; set; }

        public decimal? Dd000Valormincomissao { get; set; }

        public bool? Dd000Exibepvfaturada { get; set; }

        public bool? Dd000Isdataemissaooriginal { get; set; }

        public int? Dd000RegralimitedescontoId { get; set; }

        public decimal? Dd000Vlrmaxarredondvenda { get; set; }

        public bool? Dd000Isusacomanda { get; set; }

        public bool? Dd000Ishabilitapvexpress { get; set; }

        public string? Dd000FormapgtId { get; set; }

        public bool? Dd000Isusavendareprimida { get; set; }

        public bool? Dd000Ishabilitaperfalmox { get; set; }

        public bool? Dd000Isvendadeposito { get; set; }

        public bool? Dd000Ispermitesaldonegativo { get; set; }

        public bool? Dd000Iscontigencianfce { get; set; }

        public string? Dd000SatAssinaturaac { get; set; }

        public string? Dd000SatCodigoativacao { get; set; }

        public string? Dd000Almoxpadraotrocaid { get; set; }

        public string? Dd000CtrlContigenciaNfcei { get; set; }

        public bool? Dd000Isusavaloresretido { get; set; }

        public bool? Dd000Iscalculavolume { get; set; }

        public int? Dd000Tipoimportbibliotec { get; set; }

        public int? Dd000Tipoinsercaoprod { get; set; }

        public string? Dd000CorreiosUsuario { get; set; }

        public string? Dd000CorreiosSenha { get; set; }

        public string? Dd000Urlcorreios { get; set; }

        public bool? Dd000Iscanccomentrega { get; set; }

        public CSICP_DD000 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD000
            {
                TenantId = tenant,
                Dd000ConfigId = id!,
                Dd000FilialId = Dd000FilialId,
                Dd000PvCcustoId = Dd000PvCcustoId,
                Dd000PvAgcobradorId = Dd000PvAgcobradorId,
                Dd000PvNatoperacaoId = Dd000PvNatoperacaoId,
                Dd000PvContaId = Dd000PvContaId,
                Dd000CtrlSerieNfId = Dd000CtrlSerieNfId,
                Dd000CtrlSerieCfId = Dd000CtrlSerieCfId,
                Dd000CtrlSerieNfceId = Dd000CtrlSerieNfceId,
                Dd000PdCcustoId = Dd000PdCcustoId,
                Dd000PdAgcobradorId = Dd000PdAgcobradorId,
                Dd000PdNatoperacaoId = Dd000PdNatoperacaoId,
                Dd000PdvCcustoId = Dd000PdvCcustoId,
                Dd000PdvAgcobradorId = Dd000PdvAgcobradorId,
                Dd000PdvNatoperacaoId = Dd000PdvNatoperacaoId,
                Dd000CtCcustoId = Dd000CtCcustoId,
                Dd000CtAgcobradorId = Dd000CtAgcobradorId,
                Dd000CtNatoperacaoId = Dd000CtNatoperacaoId,
                Dd000Qtddiasvalcotacao = Dd000Qtddiasvalcotacao,
                Dd000Qtddiasvalprevenda = Dd000Qtddiasvalprevenda,
                Dd000Qualregraaplicar = Dd000Qualregraaplicar,
                Dd000AmbNfeId = Dd000AmbNfeId,
                Dd000VersaoNfeId = Dd000VersaoNfeId,
                Dd000LcertdigitalId = Dd000LcertdigitalId,
                //Dd000Arqcertdigitalbinario = Dd000Arqcertdigitalbinario,
                Dd000Arqcertdigital = Dd000Arqcertdigital,
                Dd000Senhacertdigital = Dd000Senhacertdigital,
                Dd000NdCcustoId = Dd000NdCcustoId,
                Dd000NdAgcobradorId = Dd000NdAgcobradorId,
                Dd000NdNatoperacaoId = Dd000NdNatoperacaoId,
                Dd000DcCcustoId = Dd000DcCcustoId,
                Dd000DcAgcobradorId = Dd000DcAgcobradorId,
                Dd000DcNatoperacaoId = Dd000DcNatoperacaoId,
                Dd000DisCcustoId = Dd000DisCcustoId,
                Dd000DisAgcobradorId = Dd000DisAgcobradorId,
                Dd000DisNatoperacaoId = Dd000DisNatoperacaoId,
                Dd000ZonetimeId = Dd000ZonetimeId,
                Dd000CpCcustoId = Dd000CpCcustoId,
                Dd000CpAgcobradorId = Dd000CpAgcobradorId,
                Dd000CpCondpagtoId = Dd000CpCondpagtoId,
                Dd000CpFormapagtoId = Dd000CpFormapagtoId,
                Dd000CpDiaVencto = Dd000CpDiaVencto,
                Dd000UfOrgaoId = Dd000UfOrgaoId,
                Dd000Qtddiasvaletiq = Dd000Qtddiasvaletiq,
                Dd000NfeConjugada = Dd000NfeConjugada,
                Dd000OrigPcomissaoId = Dd000OrigPcomissaoId,
                Dd000FormaPcomId = Dd000FormaPcomId,
                Dd000Comespecieid = Dd000Comespecieid,
                Dd000NfsIsmultiplo = Dd000NfsIsmultiplo,
                Dd000NfsPadraoId = Dd000NfsPadraoId,
                Dd000NfsRegesptribId = Dd000NfsRegesptribId,
                Dd000NfsOtpsnId = Dd000NfsOtpsnId,
                Dd000NfsInccultId = Dd000NfsInccultId,
                Dd000NfsCodintegrcliente = Dd000NfsCodintegrcliente,
                Dd000NfsUrlWsInvoicy = Dd000NfsUrlWsInvoicy,
                Dd000NfsAlvaraempresa = Dd000NfsAlvaraempresa,
                Dd000NfsNatop = Dd000NfsNatop,
                Dd000PdvWebRptNfceId = Dd000PdvWebRptNfceId,
                Dd000PdvWebRptNfeId = Dd000PdvWebRptNfeId,
                Dd000PdvWebRptNfId = Dd000PdvWebRptNfId,
                Dd000Tokenacessows = Dd000Tokenacessows,
                Dd000Isenviows = Dd000Isenviows,
                Dd000Isusaambiente = Dd000Isusaambiente,
                Dd000Isusaprojeto = Dd000Isusaprojeto,
                Dd000Vmetadiamonitor = Dd000Vmetadiamonitor,
                Dd000Qmetadiamonitor = Dd000Qmetadiamonitor,
                Dd000Iscomissaogerente = Dd000Iscomissaogerente,
                Dd000Valormincomissao = Dd000Valormincomissao,
                Dd000Exibepvfaturada = Dd000Exibepvfaturada,
                Dd000Isdataemissaooriginal = Dd000Isdataemissaooriginal,
                Dd000RegralimitedescontoId = Dd000RegralimitedescontoId,
                Dd000Vlrmaxarredondvenda = Dd000Vlrmaxarredondvenda,
                Dd000Isusacomanda = Dd000Isusacomanda,
                Dd000Ishabilitapvexpress = Dd000Ishabilitapvexpress,
                Dd000FormapgtId = Dd000FormapgtId,
                Dd000Isusavendareprimida = Dd000Isusavendareprimida,
                Dd000Ishabilitaperfalmox = Dd000Ishabilitaperfalmox,
                Dd000Isvendadeposito = Dd000Isvendadeposito,
                Dd000Ispermitesaldonegativo = Dd000Ispermitesaldonegativo,
                Dd000Iscontigencianfce = Dd000Iscontigencianfce,
                Dd000SatAssinaturaac = Dd000SatAssinaturaac,
                Dd000SatCodigoativacao = Dd000SatCodigoativacao,
                Dd000Almoxpadraotrocaid = Dd000Almoxpadraotrocaid,
                Dd000CtrlContigenciaNfcei = Dd000CtrlContigenciaNfcei,
                Dd000Isusavaloresretido = Dd000Isusavaloresretido,
                Dd000Iscalculavolume = Dd000Iscalculavolume,
                Dd000Tipoimportbibliotec = Dd000Tipoimportbibliotec,
                Dd000Tipoinsercaoprod = Dd000Tipoinsercaoprod,
                Dd000CorreiosUsuario = Dd000CorreiosUsuario,
                Dd000CorreiosSenha = Dd000CorreiosSenha,
                Dd000Urlcorreios = Dd000Urlcorreios,
                Dd000Iscanccomentrega = Dd000Iscanccomentrega
            };
        }
    }
}
