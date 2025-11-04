using CSLB900.MSTools.CS_QueryFilters;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG009
{
    public class PrmFiltrosCG009Repo : ParametrosBaseFiltro
    {
        public string? EstabID { get; set; }
        public string? ContaId { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
    }
}