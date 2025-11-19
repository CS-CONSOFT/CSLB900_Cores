using CSLB900.MSTools.CS_QueryFilters;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG003
{
    public class PrmFiltrosCG003Repo : ParametrosBaseFiltro
    {
        public string? EstabID { get; set; }
        public string? Descricao { get; set; }
    }
}