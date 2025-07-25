namespace CSLB900.MSTools.CS_QueryFilters
{
    /*
     Filtro apenas com o search, sem o is active
     */
    public class FiltroPesquisaTexto : ParametrosBaseFiltro
    {
        public string? Search { get; set; } = null;
    }
}
