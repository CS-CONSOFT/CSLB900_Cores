using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using FF105Financeiro.C82Application.Dto.GG00X.GG008.GG008p;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008Kdx
{
    public class DtoGetGG008KdxPrecos
    {
        public int TenantId { get; set; }

        public string Gg008Kardexid { get; set; } = null!;
        public decimal? Gg008PrecoReposicao { get; set; } = 0;
        public decimal? Gg008PrecoCusto { get; set; } = 0;
        public decimal? Gg008PrecoCustoReal { get; set; } = 0;
        public decimal? Gg008PrcVendavarejo { get; set; } = 0;
        public decimal? Gg008Prcpromocional { get; set; } = 0;
        public decimal? Gg008Prcecommerce { get; set; } = 0;

        public Dto_GetBB001Simples? NavBB001Simples { get; set; }

        public DtoGetGG008p? NavGG008PrecosTabela { get; set; }
    }

    public class DtoGetGG008KdxPrecos_2
    {
        public int TenantId { get; set; }

        public string Gg008Kardexid { get; set; } = null!;
        public decimal? Gg008PrecoReposicao { get; set; } = 0;
        public decimal? Gg008PrecoCusto { get; set; } = 0;
        public decimal? Gg008PrecoCustoReal { get; set; } = 0;
        public decimal? Gg008PrcVendavarejo { get; set; } = 0;
        public decimal? Gg008Prcpromocional { get; set; } = 0;
        public decimal? Gg008Prcecommerce { get; set; } = 0;
        public DtoGetGG008p? NavGG008PrecosTabela { get; set; }
    }


}
