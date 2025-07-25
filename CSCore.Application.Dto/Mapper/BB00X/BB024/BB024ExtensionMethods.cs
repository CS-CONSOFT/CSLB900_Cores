using CSBS101._82Application.Dto.BB00X.BB024;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB024ExtensionMethods
    {
        public static CSICP_Bb024 ToEntity(this Dto_CreateUpdateBB024 dto)
        {
            var entity = new CSICP_Bb024
            {
                Bb025NatoperacaoId = dto.Bb025NatoperacaoId,
                Bb024CfopId = dto.Bb024CfopId
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB024 ToDtoGet(this CSICP_Bb024 entity)
        {
            return new Dto_GetBB024
            {
                TenantId = entity.TenantId,
                Bb024Id = entity.Bb024Id,
                Bb025NatoperacaoId = entity.Bb025NatoperacaoId,
                Bb024CfopId = entity.Bb024CfopId,
                NavSpedCfop = entity.osusr66CSpedInCfop
            };
        }
    }
}

