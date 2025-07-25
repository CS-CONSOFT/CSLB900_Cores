using CSBS101._82Application.Dto.AA00X;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.Mapper.AA00X.AA014
{
    public static class AA014ExtensionMethods
    {
        public static Dto_GetAA014 ToDtoGet(this CSICP_Aa014 entity)
        {
            return new Dto_GetAA014
            {
                Aa014Id = entity.Aa014Id,
                TenantId = entity.TenantId,
                Aa014Serienfid = entity.Aa014Serienfid,
                Aa014Usuarioid = entity.Aa014Usuarioid,
                Aa014Dregistro = entity.Aa014Dregistro,
                Aa014Usuariopropid = entity.Aa014Usuariopropid
            };
        }


        //Dto Create to Entity
        public static CSICP_Aa014 ToEntity(this Dto_CreateUpdateAA014 dto)
        {
            var entity = new CSICP_Aa014()
            {
                Aa014Serienfid = dto.Aa014Serienfid,
                Aa014Usuarioid = dto.Aa014Usuarioid,
                Aa014Dregistro = dto.Aa014Dregistro,
                Aa014Usuariopropid = dto.Aa014Usuariopropid
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }
    }
}
