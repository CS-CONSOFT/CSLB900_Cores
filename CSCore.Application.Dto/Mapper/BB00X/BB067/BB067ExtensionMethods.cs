
using CSBS101._82Application.Dto.BB00X.BB06X.BB067;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;



namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB06X.BB067
{
    public static class BB067ExtensionMethods
    {
        public static CSICP_Bb067 ToEntity(this Dto_CreateUpdateBB067 dto)
        {
            var entity = new CSICP_Bb067
            {
                Bb067Descricao = dto.Bb067Descricao,
                Bb067Codigo = dto.Bb067Codigo,
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB067 ToDtoGet(this CSICP_Bb067 entity)
        {
            return new Dto_GetBB067
            {
                TenantId = entity.TenantId,
                Bb067Id = entity.Bb067Id,
                Bb067Descricao = entity.Bb067Descricao,
                Bb067Codigo = entity.Bb067Codigo,
            };
        }
    }
}
