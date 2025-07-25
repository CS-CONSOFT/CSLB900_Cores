namespace CSCore.Application.Dto.Dtos.Sistema.SY001.SY001
{
    public class Dto_GetSY001Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Sy001Usuario { get; set; }

        public string? Sy001Nome { get; set; }
    }
}
