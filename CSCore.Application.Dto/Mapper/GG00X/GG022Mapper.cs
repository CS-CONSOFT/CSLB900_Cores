using CSCore.Domain.CS_Models.CSICP_GG;
using FF105Financeiro.C82Application.Dto.GG00X.GG022;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG022Mapper
    {
        public static DtoGetGG022 ToDtoGet(this CSICP_GG022 entity)
        {
            return new DtoGetGG022
            {
                TenantId = entity.TenantId,
                Gg022Id = entity.Gg022Id,
                Gg022Ncmid = entity.Gg022Ncmid,
                Gg022Ufid = entity.Gg022Ufid,
                Gg022Pfcp = entity.Gg022Pfcp,
                Gg022Ncm = entity.NavGg021Ncm,
            };
        }
    }
}
