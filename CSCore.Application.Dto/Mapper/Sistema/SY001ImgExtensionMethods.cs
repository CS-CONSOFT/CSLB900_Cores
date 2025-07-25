using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY001;

namespace CSSY103.C82Application.Mapper
{
    public static class SY001ImgExtensionMethods
    {
        public static Csicp_Sy001Img ToEntity(this Dto_CreateUpdateSY001Img dto)
        {
            return new Csicp_Sy001Img
            {
                UsuarioId = dto.UsuarioId,
                Nome = dto.Nome,
                Tipo = dto.Tipo,
                Isactive = dto.Isactive,
                Ispadrao = dto.Ispadrao,
                Path = dto.Path
            };
        }

        public static Dto_GetSy001Img ToDtoGetSy001Img(this Csicp_Sy001Img entity)
        {
            return new Dto_GetSy001Img
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                UsuarioId = entity.UsuarioId,
                Nome = entity.Nome,
                Tipo = entity.Tipo,
                Isactive = entity.Isactive,
                Ispadrao = entity.Ispadrao,
                Path = entity.Path
            };
        }
    }
}

