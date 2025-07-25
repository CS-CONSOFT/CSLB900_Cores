namespace GG104Materiais.C82Application.Dto.GG00X.GG011
{
    public class DtoGetGG011
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Gg011Filial { get; set; }

        public string? Gg011Filialid { get; set; }

        public string? Gg011CodigoQualidade { get; set; }

        public string? Gg011Descricaoqualidade { get; set; }

        public bool? Gg011IsActive { get; set; }
        public CSICP_BB001? NavFilial { get; set; }

    }
}
