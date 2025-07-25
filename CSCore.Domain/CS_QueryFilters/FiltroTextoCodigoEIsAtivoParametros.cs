using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.CS_QueryFilters
{
    public class FiltroTextoCodigoEIsAtivoParametros : ParametrosBaseFiltro
    {
        public int? SearchCode { get; set; } = null;
        public string? Search { get; set; } = null;
        public bool IsActive { get; set; } = true;
    }
}
