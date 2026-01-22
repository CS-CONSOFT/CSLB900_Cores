using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.DD._04X;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Service.CalculoRegimeGeral
{
    public sealed class MontaXmlCalculoRegimeGeral
    {
        private readonly AppDbContext _context;
        private enum TipoEstaticas
        {
            csicp_bb001_TpTri
        }

        public MontaXmlCalculoRegimeGeral(AppDbContext context)
        {
            _context = context;
        }

        public async Task CSRF01_Calculadora_OffLine_MontaDD040(string InNotaID_DD040, int TenantID)
        {
            var nota = await this.GetNota(InNotaID_DD040, TenantID) ?? throw new KeyNotFoundException("Nota não encontrada.");
            var produtos = await this.GetProds_DD060(InNotaID_DD040, TenantID);


            var estaticasTpTri = this.GetTpTriIdEstaticas("Simples");
            var aa037_pis = this.GetCsicp_aa037_Imp("PIS");
            var aa037_cofins = this.GetCsicp_aa037_Imp("COFINS");
            var aa037_iss = this.GetCsicp_aa037_Imp("ISS");
            var aa037_II = this.GetCsicp_aa037_Imp("Imposto Importação");
            var estatica_sim = this.GetEstatica("SIM");



            foreach (var produto in produtos)
            {
                
            }



        }

        #region Metodos Privados
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
        private int GetEstatica(string Label)
        {
            var items = this._context.E9ACSICP_Statica
                .Where(e => e.Label == Label)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstOrDefault();

            return items;
        }
        private async Task<CSICP_DD040?> GetNota(string InNotaID_DD040, int TenantID)
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
                        from NavBB012 in bb01206Group.DefaultIfEmpty()

                        join NavAA028 in this._context.OsusrE9aCsicpAa028s
                        on NavBB01206.Bb012CodigoCidade equals NavAA028.Id into aa028Group
                        from NavAA028 in aa028Group.DefaultIfEmpty()

                        join NavAA027 in this._context.OsusrE9aCsicpAa027s
                        on NavBB01206.Bb012Uf equals NavAA027.Id into aa027Group
                        from NavAA027 in aa027Group.DefaultIfEmpty()


                        select new CSICP_DD040
                        {
                            NavDD040Tnt = CSICP_DD040Tnt,

                            NavBB001 = new CSICP_BB001
                            {
                                NavBB001Cfgfi = new CSICP_BB001Cfgfi
                                {
                                    Bb001TptributacaoId = NavBB001CfgFis.Bb001TptributacaoId,
                                }
                            },
                            NavBB012Conta = new CSICP_BB012
                            {

                            }
                        };
            return await query.AsNoTracking().FirstOrDefaultAsync();
        }

        private async Task<ICollection<CSICP_DD060>> GetProds_DD060(string InNotaID_DD040, int TenantID)
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

                        where gg520.TenantId == TenantID && dd060.Dd040Id == InNotaID_DD040
                        where dd060.Dd060Isfixarcalcimp == false

                        select new CSICP_DD060
                        {
                            NavGG021 = new CSICP_GG021
                            {
                            },
                            NavGG007Unidade = new CSICP_GG007
                            {
                            },
                            NavGG008Produto = new CSICP_GG008
                            {

                            }
                        };

            return await query.ToListAsync();
        }

        private async Task CSRF11_ObtemTransacaoExcecao(string InBB027_ID,string InAA143_ID)
        {

        }

        #endregion
    }
}
