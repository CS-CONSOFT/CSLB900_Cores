using CSBS101._82Application.Dto.BB00X.BB06X.BB065;
using CSBS101._82Application.Dto.BB00X.BB06X.BB066;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB064
{
    public class Dto_GetBB064
    {
        public int TenantId { get; set; }

        public long Bb064Fxetariaid { get; set; }

        public string? Bb064Descricao { get; set; }

        public bool? Bb064Isactive { get; set; }

        public ICollection<Dto_GetBB066> NavCSICP_BB066List { get; set; } = [];
        public ICollection<Dto_GetBB065> NavCSICP_BB065List { get; set; } = [];
    }
}
