namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF002
{
    public class DtoGetFF002Simples
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public int? Ff002Tiporegistro { get; set; }
        public int? Ff002Codigo { get; set; }
        public string? Ff002Motivo { get; set; }
    }
}