

using CSBS101._82Application.Dto.BB00X.BB007.BB007D;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB007.BB007D;
using CSCore.Domain;
using GG104Materiais.C82Application.Mapper;

namespace CSBS101._82Application.Mapper.BB00X
{
    public static class BB007DExtensionMethods
    {
        public static CSICP_BB007d ToEntity(this Dto_CreateUpdateBB007D dto)
        {
            return new CSICP_BB007d
            {
                Bb007Responid = dto.Bb007Responid,
                Gg001Almoxid = dto.Gg001Almoxid
            };
        }
        public static Dto_GetBB007D ToDtoGet(this CSICP_BB007d entity)
        {
            return new Dto_GetBB007D
            {
                TenantId = entity.TenantId,
                Bb007dId = entity.Bb007dId,
                Bb007Responid = entity.Bb007Responid,
                Gg001Almoxid = entity.Gg001Almoxid,
                Nav_Ggg001 = entity.CSICP_GG001?.ToDtoGetSimples(),
                Nav_bb001 = entity.CSICP_GG001?.BB001FilialNav?.ToDtoGetSimples()
            };
        }
    }
}
