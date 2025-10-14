namespace FF105Financeiro.C82Application.Dto.GG00X.GG006
{
    public class DtoGetGG006
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Gg006Filial { get; set; }

        public int? Gg006Codgfilial { get; set; }

        public int? Gg006Codigomarca { get; set; }

        public string? Gg006Descmarca { get; set; }

        public bool? Gg006IsActive { get; set; }
    }

    public class DtoGetGG006_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;



        public int? Gg006Codigomarca { get; set; }

        public string? Gg006Descmarca { get; set; }

    }
}
