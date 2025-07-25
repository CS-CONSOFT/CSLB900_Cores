using CSBS101._82Application.Dto.BB00X.BB001;

namespace CSBS101._82Application.Dto.AA00X.AA001
{
    public class Dto_GetAA001
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public decimal? Aa001Filial { get; set; }

        public string? Aa001Identificacao { get; set; }

        public string? Aa001Tipo { get; set; }

        public string? Aa001Conteudo { get; set; }

        public string? Aa001Descricao { get; set; }

        public string? Aa001Filialid { get; set; }

        public string? Aa001Json { get; set; }
        public Dto_GetBB001? NavFilialBB001 { get; set; }
    }
}
