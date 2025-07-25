
using CSBS101._82Application.Dto.BB00X.BB05X.BB050;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB05X.BB050
{
    public static class BB050ExtensionMethods
    {
        public static CSICP_Bb050 ToEntity(this Dto_CreateUpdateBB050 dto)
        {
            var entity = new CSICP_Bb050
            {
                Bb050Empresaid = dto.Bb050Empresaid,
                Bb050Grupoprodutoid = dto.Bb050Grupoprodutoid,
                Bb050Datainicio = dto.Bb050Datainicio,
                Bb050Datafinal = dto.Bb050Datafinal,
                Bb050Valorminimo = dto.Bb050Valorminimo
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB050 ToDtoGet(this CSICP_Bb050 entity)
        {
            return new Dto_GetBB050
            {
                TenantId = entity.TenantId,
                Bb050Id = entity.Bb050Id,
                Bb050Empresaid = entity.Bb050Empresaid,
                Bb050Grupoprodutoid = entity.Bb050Grupoprodutoid,
                Bb050Datainicio = entity.Bb050Datainicio,
                Bb050Datafinal = entity.Bb050Datafinal,
                Bb050Valorminimo = entity.Bb050Valorminimo
            };
        }
    }
}

