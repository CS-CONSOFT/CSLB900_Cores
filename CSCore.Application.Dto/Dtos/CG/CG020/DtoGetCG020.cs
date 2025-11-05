using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG008;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Dtos.CG.CG020
{
    public class DtoGetCG020
    {
        public int TenantId { get; set; }
        public string Cg020Id { get; set; } = null!;
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
        public Dto_GetBB001_Exibicao? NavBB001Estab_CG020 { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001ConsoEstab_CG020 { get; set; }

        public DtoGetCG008? NavCG008TpSaldo_CG020 { get; set; }

        public Osusr8dwCsicpCg992? NavCG992_CG020 { get; set; }
    }
}