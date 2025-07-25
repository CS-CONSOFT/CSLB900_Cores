using CSBS101._82Application.Dto.BB00X;
using CSBS101._82Application.Dto.BB00X.BB003;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;


namespace CSBS101._82Application.Mapper.BB00X.BB003
{
    public static class BB003ExtensionMethods
    {
        public static CSICP_Bb003 ToEntity(this Dto_CreateUpdateBB003 dto)
        {
            var entity = new CSICP_Bb003
            {
                Bb003Moeda = dto.Bb003Moeda,
                Bb003Sigla = dto.Bb003Sigla
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB003 ToDtoGet(this CSICP_Bb003 entity)
        {
            return new Dto_GetBB003
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb003Moeda = entity.Bb003Moeda,
                Bb003Sigla = entity.Bb003Sigla,
            };
        }
    }
}
