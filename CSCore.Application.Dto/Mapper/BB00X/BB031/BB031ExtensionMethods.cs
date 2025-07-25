using CSBS101._82Application.Dto.BB00X.BB031;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;



namespace CSBS101._82Application.ExtensionsMethods.BB00X
{
    public static class BB031ExtensionMethods
    {
        public static CSICP_Bb031 ToEntity(this Dto_CreateUpdateBB031 dto)
        {
            var entity = new CSICP_Bb031
            {
                Bb031Codgfuncaoid = dto.Bb031Codgfuncaoid,
                Bb031Descricao = dto.Bb031Descricao,
                Bb031Cbo = dto.Bb031Cbo,
                Bb031Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB031 ToDtoGet(this CSICP_Bb031 entity)
        {
            return new Dto_GetBB031
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb031Codgfuncaoid = entity.Bb031Codgfuncaoid,
                Bb031Descricao = entity.Bb031Descricao,
                Bb031Cbo = entity.Bb031Cbo,
                Bb031Isactive = entity.Bb031Isactive
            };
        }
    }
}







