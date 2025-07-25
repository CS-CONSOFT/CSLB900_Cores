



using CSBS101._82Application.Dto.BB00X.BB012.Get;

namespace CSBS101._82Application.Dto.BB00X.BB007.BB007C
{
    public class Dto_GetBB007C
    {
        public int TenantId { get; set; }

        public long Bb007cId { get; set; }

        public string? Bb007Responid { get; set; }

        public string? Bb012Contaid { get; set; }

        public decimal? Bb007cPcomissao { get; set; }
        public Dto_GetBB012_Exibicao? NavBb012Conta { get; set; }
    }
}
