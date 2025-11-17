using CSSY103.C82Application.Dto.SY904;

namespace CSSY103.C82Application.Dto.SY903
{
    public class DtoSY903
    {
        public string Id { get; set; } = null!;

        public string? Label { get; set; }

        public string? Descricao { get; set; }

        public string? Submenu { get; set; }

        public string? Url { get; set; }

        public string? Menu { get; set; }


        public int? Ordem { get; set; }

        public DateTime? Datacreate { get; set; }

        public bool? Isactive { get; set; }



        public List<DtoSY904> NavListSY904Programa { get; set; } = [];

    }

    public class DtoSY903_V2
    {
        public string title { get; set; } = string.Empty;

        public string? icon { get; set; } = string.Empty;

        public string? to { get; set; } = "#";

        public List<DtoSY904_V2> children { get; set; } = [];

    }
}
