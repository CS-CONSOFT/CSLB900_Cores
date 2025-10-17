using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.RR._00X
{
    public class PrmFiltrosRR001 : ParametrosBaseFiltro
    {
        public string? In_Nomeanimal { get; set; }
        public string? In_Serie { get; set; }
        public int? In_NumeroRGN { get; set; }
        public string? In_Apelido { get; set; }
        public int? In_AtivoID { get; set; }
        public DateTime? In_DataNascimento { get; set; }
        public long? In_RacaID { get; set; }
        public int? In_SexoID { get; set; }
        public long? In_SituacaoID { get; set; }
    }
}
