namespace CSLB900.MSTools.CS_QueryFilters
{
    /**
     * Codigo e search sem o is active
     */
    public class FiltroPesquisaTextoCodigoParametro : ParametrosBaseFiltro
    {
        public string? Search { get; set; } = null;
        public int? SearchCode { get; set; } = null;
    }
}
