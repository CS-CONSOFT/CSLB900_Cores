namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR031
{
    public class DtoGetRR031Padrao
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr031IatfId { get; set; }

        public string? Rr031Animalid { get; set; }

        public DateTime? Rr031Dtregistro { get; set; }

        public bool? Rr031Ispositivo { get; set; }

        public string? Rr031Montaanimalid { get; set; }

        public string? Rr031Semenid { get; set; }
    }
}