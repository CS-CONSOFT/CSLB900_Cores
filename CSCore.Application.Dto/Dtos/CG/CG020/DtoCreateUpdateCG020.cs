using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.CG.CG020
{
    public class DtoCreateUpdateCG020 : IConverteParaEntidade<CSICP_CG020>
    {
        public string? Cg020FilialId { get; set; }
        public int? Cg020Ano { get; set; }
        public int? Cg020Mes { get; set; }
        public int? Cg020Lote { get; set; }
        public string? Cg020TiposaldoId { get; set; }
        public DateTime? Cg020Datainicio { get; set; }
        public DateTime? Cg020Datafinal { get; set; }
        public int? Cg020Qtdlanctos { get; set; }
        public decimal? Cg020Totaldebito { get; set; }
        public decimal? Cg020Totalcredito { get; set; }
        public decimal? Cg020Difdebcre { get; set; }
        public decimal? Cg020Gtdebcre { get; set; }
        public int? Cg020Ultlancto { get; set; }
        public int? Cg020UltSeq { get; set; }
        public int? Cg020SituacaoloteId { get; set; }
        public string? Cg020ConsolidadoFilialId { get; set; }

        public CSICP_CG020 ToEntity(int tenant, string? id)
        {
            return new CSICP_CG020
            {
                TenantId = tenant,
                Cg020Id = id!,
                Cg020FilialId = this.Cg020FilialId,
                Cg020Ano = this.Cg020Ano,
                Cg020Mes = this.Cg020Mes,
                Cg020Lote = this.Cg020Lote,
                Cg020TiposaldoId = this.Cg020TiposaldoId,
                Cg020Datainicio = this.Cg020Datainicio,
                Cg020Datafinal = this.Cg020Datafinal,
                Cg020Qtdlanctos = this.Cg020Qtdlanctos,
                Cg020Totaldebito = this.Cg020Totaldebito,
                Cg020Totalcredito = this.Cg020Totalcredito,
                Cg020Difdebcre = this.Cg020Difdebcre,
                Cg020Gtdebcre = this.Cg020Gtdebcre,
                Cg020Ultlancto = this.Cg020Ultlancto,
                Cg020UltSeq = this.Cg020UltSeq,
                Cg020SituacaoloteId = this.Cg020SituacaoloteId,
                Cg020ConsolidadoFilialId = this.Cg020ConsolidadoFilialId
            };
        }
    }
}