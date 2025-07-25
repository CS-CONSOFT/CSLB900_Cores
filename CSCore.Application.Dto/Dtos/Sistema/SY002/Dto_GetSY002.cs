using CSSY103.C82Application.Dto.SY001.SY007;

namespace CSSY103.C82Application.Dto.SY002
{
    public class Dto_GetSy002
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Sy002Grupo { get; set; }

        public string? Sy002Descricao { get; set; }
        public List<Dto_LinkGetSy007> NavLinkGetSy007s { get; set; } = [];
    }
}
