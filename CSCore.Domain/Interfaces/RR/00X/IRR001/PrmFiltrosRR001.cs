using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X.IRR001
{
    public class PrmFiltrosRR001 : ParametrosBaseFiltro
    {
        public string? In_Nomeanimal { get; set; }
        public int? In_NumeroRGN { get; set; }
        public string? In_Apelido { get; set; }
        public int? In_AtivoID { get; set; }
        public DateTime? In_DataNascimento { get; set; }

    }
}
