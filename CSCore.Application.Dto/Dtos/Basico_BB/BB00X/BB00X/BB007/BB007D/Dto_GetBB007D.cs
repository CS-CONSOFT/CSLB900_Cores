using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using FF105Financeiro.C82Application.Dto.GG00X.GG001;

namespace CSBS101.C82Application.Dto.BB00X.BB00X.BB007.BB007D
{
    public class Dto_GetBB007D
    {
        public int TenantId { get; set; }

        public long Bb007dId { get; set; }

        public string? Bb007Responid { get; set; }

        public string? Gg001Almoxid { get; set; }

        public DtoGetGG001Simples? Nav_Ggg001 { get; set; }
        public Dto_GetBB001Simples? Nav_bb001 { get; set; }
    }
}
