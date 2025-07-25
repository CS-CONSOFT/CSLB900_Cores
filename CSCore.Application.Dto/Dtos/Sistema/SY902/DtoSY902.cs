using CSSY103.C82Application.Dto.SY903;

namespace CSSY103.C82Application.Dto.SY902
{
    public class DtoSY902
    {
        public string Id { get; set; } = null!;

        public int? IdSy802 { get; set; }

        public string? Label { get; set; }

        public string? Menu { get; set; }

        public string? Descricao { get; set; }

        public string? Url { get; set; }

        public int? Ordem { get; set; }

        public bool? Isactive { get; set; }

        public List<DtoSY903> NavListSY903_SMenu { get; set; } = [];
    }
}
