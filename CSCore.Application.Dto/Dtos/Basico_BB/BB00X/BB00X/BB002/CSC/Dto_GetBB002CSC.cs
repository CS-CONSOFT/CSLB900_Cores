namespace CSBS101._82Application.Dto.BB00X.BB002.CSC
{
    public class Dto_GetBB002CSC
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb002Id { get; set; }

        public int? Bb002Cidtoken { get; set; }

        public string? Bb002Csc { get; set; }

        public DateTime? Bb002Dataativacao { get; set; }

        public DateTime? Bb002Datarevogacao { get; set; }

        public string? Bb002Motivorevogacao { get; set; }

        public bool? Bb002Isrevogado { get; set; }

        public string? Bb001Estabid { get; set; }
    }
}
