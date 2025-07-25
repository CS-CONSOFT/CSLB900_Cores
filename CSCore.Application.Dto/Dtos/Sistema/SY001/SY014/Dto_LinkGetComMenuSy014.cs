using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSSY103.C82Application.Dto.SY001.SY014
{
    public class Dto_LinkGetComMenuSy014
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Sy014Grupoid { get; set; }

        public string? Sy902MenuId { get; set; }

        public Csicp_Sy002? Sy014Grupo { get; set; }
        public CsicpSy902Menu CsicpSy902Menu { get; set; } = null!;

    }
}
