using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY013;

namespace CSSY103.C82Application.Mapper
{
    public static class SY013ExtensionMethods
    {
        public static Csicp_Sy013 ToEntity(this Dto_CreateUpdateLinkSy013 dto)
        {
            return new Csicp_Sy013
            {
                Sy013Usuarioid = dto.Sy013Usuarioid,
                Sy013Filialid = dto.Sy013Filialid
            };
        }

        public static Dto_LinkGetSy013 ToDtoGetSy013(this Csicp_Sy013 entity)
        {
            return new Dto_LinkGetSy013
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy013Usuarioid = entity.Sy013Usuarioid,
                Sy013Filialid = entity.Sy013Filialid,
                NomeFilial = entity.NavCSICP_BB001?.Bb001Nomefantasia,
            };
        }
    }
}
