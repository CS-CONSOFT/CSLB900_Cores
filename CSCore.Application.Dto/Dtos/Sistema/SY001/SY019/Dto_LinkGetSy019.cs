using CSCore.Domain;

namespace CSSY103.C82Application.Dto.SY001.SY019
{
    public class Dto_LinkGetSy019
    {
        public int TenantId { get; set; }

        public long Sy019Id { get; set; }

        public string? Sy019Userid { get; set; }

        public string? Sy904ProgramaId { get; set; }

        public bool? Sy019Isactive { get; set; }

        public Csicp_Sy001? Sy019User { get; set; }

    }
}
