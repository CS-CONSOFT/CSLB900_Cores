using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101._82Application.Dto.BB00X.BB05X.BB050;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB051
{
    public class Dto_GetBB051
    {
        public int TenantId { get; set; }

        public string Bb051Id { get; set; } = null!;

        public string? Bb050Id { get; set; }

        public string? Bb051Formapagtoid { get; set; }

        public int? Bb051Maxparcela { get; set; }

        public Dto_GetBB050? NavBb050 { get; set; }

        public Dto_GetBB026SemList? NavBb051Formapagto { get; set; }
    }
}
