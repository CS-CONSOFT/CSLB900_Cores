namespace CSCore.Application.Dto.Dtos.CG.CG007
{
    public class DtoGetCG007
    {
        public int TenantId { get; set; }

        public string Cg007Id { get; set; } = null!;

        public string? Cg007FilialId { get; set; }

        public string? Cg007Codigo { get; set; }

        public string? Cg007Descricao { get; set; }

        public string? Cg007Objetivo { get; set; }

        public bool? Cg007Isactive { get; set; }

        public DateTime? Cg007DataInicio { get; set; }

        public DateTime? Cg007DataFim { get; set; }

        public string? Cg007UserpropId { get; set; }

        public int? Cg007StatusId { get; set; }
    }
}