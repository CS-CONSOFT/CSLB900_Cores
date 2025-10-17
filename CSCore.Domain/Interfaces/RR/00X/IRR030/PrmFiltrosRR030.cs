using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR030
{
    public class PrmFiltrosRR030 : ParametrosBaseFiltro
    {
        public string? In_Descricao { get; set; }
        public DateTime? In_DataMontaInicial { get; set; }
        public DateTime? In_DataMontaFinal { get; set; }
    }
}