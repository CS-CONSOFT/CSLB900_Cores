using CSCore.Domain;

namespace CSBS101._82Application.Dto.BB00X.BB024
{
    public class Dto_GetBB024
    {
        public int TenantId { get; set; }

        public long Bb024Id { get; set; }

        public string? Bb025NatoperacaoId { get; set; }

        public int? Bb024CfopId { get; set; }
        public Osusr66cSpedInCfop? NavSpedCfop { get; set; }
    }
}
