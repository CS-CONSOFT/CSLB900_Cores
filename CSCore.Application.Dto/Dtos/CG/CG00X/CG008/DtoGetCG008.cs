namespace CSCore.Application.Dto.Dtos.CG.CG00X.CG008
{
    public class DtoGetCG008
    {
        public int TenantId { get; set; }
        public string Cg008Id { get; set; } = null!;
        public int? Cg008Cod { get; set; }
        public string? Cg008Descricao { get; set; }
        public string? Cg008Descresumida { get; set; }
        public bool? Cg008Isactive { get; set; }
    }
}