using CSCore.Domain;

namespace CSSY103.C82Application.Dto.SY001.SY020
{
    public class Dto_LinkGetSy020
    {
        public int TenantId { get; set; }

        public long Sy020Id { get; set; }

        public string? Sy020Usuarioid { get; set; }

        public string? Sy020Mac { get; set; }

        public bool? Sy020Isautorizado { get; set; }

        public DateTime? Sy020Dcreate { get; set; }

        public Csicp_Sy001? Sy020Usuario { get; set; }

    }
}
