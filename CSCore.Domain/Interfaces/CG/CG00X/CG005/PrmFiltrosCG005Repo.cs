using CSLB900.MSTools.CS_QueryFilters;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG005
{
    public class PrmFiltrosCG005Repo : ParametrosBaseFiltro
    {
        public string? EstabID { get; set; }
        public string? Historico { get; set; }
    }
}