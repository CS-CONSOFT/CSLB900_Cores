using CSBS101._82Application.Dto.BB00X.BB06X.BB060;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB065
{
    public class Dto_GetBB065
    {
        public int TenantId { get; set; }

        public long Bb065Id { get; set; }

        public long? Bb064Fxetariaid { get; set; }

        public long? Bb062Convenioid { get; set; }

        public Dto_GetBB060_Exibicao? NavBb062Convenio { get; set; }

        // public Dto_GetBB064? NavBb064Fxetaria { get; set; }
    }
}
