using CSCore.Domain;

namespace CSSY103.C82Application.Dto.SY001.SY007
{
    public class Dto_LinkGetSy007
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Sy007Grupoid { get; set; }

        public int? Sy007RegraestaticaId { get; set; }

        public Csicp_Sy003Regra? NavSy007Regraestatica { get; set; }
    }
}
