using CSSY103.C82Application.Dto.SY904;

namespace CSSY103.C82Application.Dto.SY905
{
    public class DtoSY905
    {
        public string Id { get; set; } = null!;

        public string? Submenu { get; set; }

        public string? Programa { get; set; }

        public string? Label { get; set; }

        public int? Ordem { get; set; }

        public bool? IsActive { get; set; }

        public int? IdSy805 { get; set; }

        public int? PropCsSisproId { get; set; }
        public List<DtoSY904> NavListSY904_Programa { get; set; } = [];
    }
}
