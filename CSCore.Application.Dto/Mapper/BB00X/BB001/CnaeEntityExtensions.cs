using CSBS101._82Application.Dto.BB00X.BB001.BB001Cnae;
using CSCore.Domain;


namespace CSBS101._82Application.Mapper.BB00X.BB001
{
    public static class CnaeEntityExtensions
    {
        /**
         * BB001 CNAE => Dto_GetCnae
         */
        public static Dto_GetCnaeFromBB001 ToDtoGet(this CSICP_BB001Cnaes entityCnae)
        {
            return new Dto_GetCnaeFromBB001
            {
                TenantId = entityCnae.TenantId,
                Bb001CnaeId = entityCnae.Bb001CnaeId,
                Bb001Id = entityCnae.Bb001Id,
                Bb001PkId = entityCnae.Bb001PkId,
                Bb001Isactive = entityCnae.Bb001Isactive,
                Bb001IscnaeFiscal = entityCnae.Bb001IscnaeFiscal,
                NavCnae = entityCnae.NavCnae
            };
        }


        /**
        * Dto_LinkCnae =>CSICP_BB001Cnaes
        */
        public static CSICP_BB001Cnaes ToEntity(this Dto_LinkCnae dto_CreateCnae, int tenant, string uuid)
        {
            return new CSICP_BB001Cnaes()
            {
                TenantId = tenant,
                Bb001Id = dto_CreateCnae.Bb001Id,
                Bb001PkId = uuid,
                Bb001CnaeId = dto_CreateCnae.Bb001CnaeId,
                Bb001Isactive = true,
                Bb001IscnaeFiscal = dto_CreateCnae.Bb001IscnaeFiscal
            };
        }
    }
}
