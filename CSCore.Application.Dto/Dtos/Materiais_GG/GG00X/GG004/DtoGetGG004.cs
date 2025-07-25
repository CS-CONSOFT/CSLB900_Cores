namespace GG104Materiais.C82Application.Dto.GG00X.GG004
{
    public class DtoGetGG004
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg004Filial { get; set; }

        public string? Gg004Filialid { get; set; }

        public int? Gg004Codigoclasse { get; set; }

        public string? Gg004Descclasse { get; set; }

        public bool? Gg004Isactive { get; set; }

        public CSICP_BB001? NavBB001Filial { get; set; } = null;
    }


    public class DtoGG004_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg004Codigoclasse { get; set; }

        public string? Gg004Descclasse { get; set; }

    }

}
