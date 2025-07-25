namespace GG104Materiais.C82Application.Dto.GG00X.GG005
{
    public class DtoGetGG005
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg005Filial { get; set; }

        public string? Gg005Filialid { get; set; }

        public int? Gg005Codigoartigo { get; set; }

        public string? Gg005Descartigo { get; set; }

        public bool? Gg005Isactive { get; set; }

        public string? Gg005PesoLe { get; set; }

        public CSICP_BB001? NavBB001Estabelecimento { get; set; }
    }
}
