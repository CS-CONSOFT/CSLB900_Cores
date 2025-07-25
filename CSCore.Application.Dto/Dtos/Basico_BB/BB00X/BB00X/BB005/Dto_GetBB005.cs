namespace CSBS101._82Application.Dto.BB00X.BB005
{
    public class Dto_GetBB005
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb005Filial { get; set; }

        public int? Bb005Codigo { get; set; }

        public string? Bb005Nomeccusto { get; set; }

        public int? Bb005Colunaimpressao { get; set; }

        public string? Empresaid { get; set; }

        public bool? Bb005Isactive { get; set; }
    }

    public class Dto_GetBB005_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb005Codigo { get; set; }

        public string? Bb005Nomeccusto { get; set; }

    }
}
