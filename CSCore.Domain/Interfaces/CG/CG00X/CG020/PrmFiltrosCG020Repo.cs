using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG020
{
    public class PrmFiltrosCG020Repo : ParametrosBaseFiltro
    {
        public string? FilialId { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Lote { get; set; }
    }
}