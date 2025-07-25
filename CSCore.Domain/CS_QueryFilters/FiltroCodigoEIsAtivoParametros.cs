namespace CSLB900.MSTools.CS_QueryFilters
{
    /**
     * Codigo e search sem o is active
     */
    public class FiltroCodigoEIsAtivoParametros : ParametrosBaseFiltro
    {
        public int? SearchCode { get; set; } = null;
        public bool? IsActive { get; set; } = null;
    }
}
