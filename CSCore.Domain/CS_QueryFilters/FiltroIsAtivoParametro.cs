namespace CSLB900.MSTools.CS_QueryFilters
{
    /*
     Filtro apenas com o is active, sem o search
     */
    public class FiltroIsAtivoParametro : ParametrosBaseFiltro
    {
        public bool IsActive { get; set; } = true;
    }
}
