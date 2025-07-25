
using CSBS101._82Application.Dto.BB00X.BB007.BB007C;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Domain;

namespace CSBS101._82Application.Mapper.BB00X.BB007
{
    public static class BB007CExtensionMethods
    {
        public static CSICP_BB007c ToEntity(this Dto_CreateUpdateBB007C dto)
        {
            return new CSICP_BB007c
            {
                Bb007Responid = dto.Bb007Responid,
                Bb012Contaid = dto.Bb012Contaid,
                Bb007cPcomissao = dto.Bb007cPcomissao
            };
        }
        public static Dto_GetBB007C ToDtoGet(this CSICP_BB007c entity)
        {
            return new Dto_GetBB007C
            {
                TenantId = entity.TenantId,
                Bb007cId = entity.Bb007cId,
                Bb007Responid = entity.Bb007Responid,
                Bb012Contaid = entity.Bb012Contaid,
                Bb007cPcomissao = entity.Bb007cPcomissao,
                NavBb012Conta = entity.Bb012Conta?.ToDtoBB012Exibicao()
            };
        }
    }
}
