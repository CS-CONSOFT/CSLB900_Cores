namespace CSCore.Application.Dto.Dtos.CG.CG08X.CG080
{
    public class DtoGetCG080
    {
        public int TenantId { get; set; }

        public long Cg080Id { get; set; }

        public string? Cg080Nome { get; set; }

        public DateTime? Cg080Dtvigenciaini { get; set; }

        public DateTime? Cg080Dtvigenciafim { get; set; }

        public bool? Cg080Isactive { get; set; }

        public bool? Cg080Isprojfromprov { get; set; }
    }
}