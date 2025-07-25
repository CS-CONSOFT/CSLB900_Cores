
using CSBS101._82Application.Dto.BB00X.BB001.BB001Images;
using CSCore.Domain;


namespace CSBS101._82Application.Mapper.BB00X.BB00X.BB001
{
    public static class ImageExtensionMethods
    {
        public static CSICP_BB001Img ToEntity(this Dto_LinkImage dto, string uuid, int tenant)
        {
            return new CSICP_BB001Img
            {
                Id = uuid,
                TenantId = tenant,
                Empresaid = dto.Empresaid,
                Status = dto.Status,
                Nome = dto.Nome,
                Tipo = dto.Tipo,
                //Imagem = dto.Imagem,
                ExibirEmformapagto = dto.ExibirEmformapagto,
                Isactive = true,
                Filename = dto.Filename,
                Path = dto.Path
            };
        }

        public static Dto_GetImageFromBB001 ToDtoGet(this CSICP_BB001Img entity)
        {
            return new Dto_GetImageFromBB001
            {
                Id = entity.Id,
                TenantId = entity.TenantId,
                Empresaid = entity.Empresaid,
                Status = entity.Status,
                Nome = entity.Nome,
                Tipo = entity.Tipo,
                //Imagem = entity.Imagem,
                ExibirEmformapagto = entity.ExibirEmformapagto,
                Isactive = entity.Isactive,
                Filename = entity.Filename,
                Path = entity.Path,
                NavStatusNavigation = entity.StatusNavigation
            };
        }
    }
}
