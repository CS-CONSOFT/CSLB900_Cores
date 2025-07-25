





using CSCore.Domain;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_GetAA041
    {
        public int TenantId { get; set; }

        public long Aa041Id { get; set; }

        public int? Aa041TabspedId { get; set; }

        public string? Aa041Codigo { get; set; }

        public string? Aa041Descricao { get; set; }

        public DateTime? Aa041Dinicio { get; set; }

        public DateTime? Aa041Dfinal { get; set; }

        public OsusrNnxSpedInTabela? NavAa041Tabsped { get; set; }
    }
}
