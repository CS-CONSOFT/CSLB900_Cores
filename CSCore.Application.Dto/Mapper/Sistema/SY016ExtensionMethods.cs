using CSCore.Domain;
using CSSY103.C82Application.Dto.SY001.SY016;

namespace CSSY103.C82Application.Mapper
{
    public static class SY016ExtensionMethods
    {
        public static Csicp_Sy016 ToEntity(this Dto_CreateUpdateLinkSy016 dto)
        {
            return new Csicp_Sy016
            {
                Linkusuarioestabecimentoid = dto.Linkusuarioestabecimentoid,
                Codigoacesso = dto.Codigoacesso,
                Usuariocriacao = dto.Usuariocriacao,
                Tipoacessorapidoid = dto.Tipoacessorapidoid,
                Isactive = dto.Isactive
            };
        }

        public static Dto_LinkGetSy016 ToDtoGetSy016(this Csicp_Sy016 entity)
        {
            return new Dto_LinkGetSy016
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Linkusuarioestabecimentoid = entity.Linkusuarioestabecimentoid,
                Codigoacesso = entity.Codigoacesso,
                Datacriacao = entity.Datacriacao,
                Usuariocriacao = entity.Usuariocriacao,
                Tipoacessorapidoid = entity.Tipoacessorapidoid,
                Dataativacao = entity.Dataativacao,
                Isactive = entity.Isactive

            };
        }
    }
}