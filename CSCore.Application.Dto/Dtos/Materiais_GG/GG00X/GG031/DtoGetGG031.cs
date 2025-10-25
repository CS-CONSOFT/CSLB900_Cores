using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008Kdx;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG030;
using CSCore.Domain.CS_Models.Staticas.GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG008;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG031
{
    public class DtoGetGG031
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg031Filialid { get; set; }

        public string? Gg030Id { get; set; }

        public string? Gg031KardexId { get; set; }

        public int? Gg031Produto { get; set; }

        public string? Gg031Produtoid { get; set; }

        public decimal? Gg031Codigobarra { get; set; }

        public DateTime? Gg031DataReferente { get; set; }

        public decimal? Gg031PercAjuste { get; set; }

        public decimal? Gg031PrcAnterior { get; set; }

        public decimal? Gg031PrcMovimento { get; set; }

        public decimal? Gg031PrcCalculado { get; set; }

        public int? Gg031PrecoajusteId { get; set; }

        public string? Gg031Codbarrasalfa { get; set; }

        public Dto_GetBB001_Exibicao? Nav_BB001 { get; set; }
        public DtoGetGG030? Nav_GG030 { get; set; }
        public DtoGetGG008Kdx_Simples? Nav_GG008_Kdx { get; set; }
        public DtoGetGG008_Exibicao_Simples? Nav_GG008 { get; set; }
        public CSICP_GG023Val? Nav_GG023_Val { get; set; }
    }
}
