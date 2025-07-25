namespace CSCore.Domain.Interfaces.Menu
{

    public class MenuResponse
    {
        public string Id { get; set; } = null!;

        public string? Label { get; set; }

        public string? Menu { get; set; }

        public string? Descricao { get; set; }
        public int? Ordem { get; set; }

        public bool? Isactive { get; set; }

        public IEnumerable<SubMenuResponse> NavListSubMenus { get; set; } = [];

    }


    public class SubMenuResponse
    {
        public string Id { get; set; } = null!;

        public string? Label { get; set; }

        public string? Descricao { get; set; }

        public string? Submenu { get; set; }
        public int? Ordem { get; set; }
        public bool? Isactive { get; set; }

        public IEnumerable<ProgramaMenu> NavListProgramaMenus { get; set; } = [];
    }

    public class ProgramaMenu
    {
        public string Id { get; set; } = null!;

        public string? Label { get; set; }

        public string? Programa { get; set; }

        public int? Ordem { get; set; }
        public string? Url { get; set; }

        public string? Descricao { get; set; }
        public bool? IsActive { get; set; }
    }
}