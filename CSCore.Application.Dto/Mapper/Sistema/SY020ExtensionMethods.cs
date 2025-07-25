using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY020;

namespace CSSY103.C82Application.Mapper
{
    public static class SY020ExtensionMethods
    {
        public static Csicp_Sy020 ToEntity(this Dto_CreateUpdateLinkSy020 dto)
        {
            return new Csicp_Sy020
            {
                Sy020Usuarioid = dto.Sy020Usuarioid,
                Sy020Mac = dto.Sy020Mac,
                Sy020Isautorizado = dto.Sy020Isautorizado,
                Sy020Dcreate = dto.Sy020Dcreate,

            };
        }

        public static Dto_LinkGetSy020 ToDtoGetSy020(this Csicp_Sy020 entity)
        {
            return new Dto_LinkGetSy020
            {
                TenantId = entity.TenantId,
                Sy020Id = entity.Sy020Id,
                Sy020Usuarioid = entity.Sy020Usuarioid,
                Sy020Mac = entity.Sy020Mac,
                Sy020Isautorizado = entity.Sy020Isautorizado,
                Sy020Dcreate = entity.Sy020Dcreate,
                Sy020Usuario = entity.Sy020Usuario,

            };
        }
    }
}

