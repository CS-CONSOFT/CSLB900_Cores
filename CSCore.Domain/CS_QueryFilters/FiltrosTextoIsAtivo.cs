namespace CSLB900.MSTools.CS_QueryFilters
{
    public class FiltrosTextoIsAtivo : ParametrosBaseFiltroSemExcederOMaxPageSize
    {
        public string? Search { get; set; } = null;
        public bool IsActive { get; set; } = true;
    }
}
