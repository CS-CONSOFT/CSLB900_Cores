namespace CSBS101._82Application.Dto.BB00X.BB009
{
    public class Dto_GetBB009
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb009Filial { get; set; }

        public int? Bb009Codigo { get; set; }

        public string? Bb009Tipocobranca { get; set; }

        public string? Empresaid { get; set; }

        public bool? Bb009Isactive { get; set; }
    }
    public class Dto_GetBB009_Exibicao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public int? Bb009Codigo { get; set; }

        public string? Bb009Tipocobranca { get; set; }

    }

}
