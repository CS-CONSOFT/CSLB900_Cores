

using CSBS101._82Application.Dto.BB00X.BB037;
using CSCore.Domain;
using CSLB900.MSTools.Extensao;

namespace CSBS101._82Application.ExtensionsMethods.BB00X.BB03X.BB037
{
    public static class BB037ExtensionMethods
    {

        public static CSICP_Bb037 ToEntity(this Dto_CreateUpdateBB037 dto)
        {
            var entity = new CSICP_Bb037
            {
                Bb037Codigo = dto.Bb037Codigo,
                Bb037Descricao = dto.Bb037Descricao,
                Bb037Dia = dto.Bb037Dia,
                Bb037Qtddiasmcompra = dto.Bb037Qtddiasmcompra,
                Bb037Isactive = true
            };
            entity.ConverteValoresPadraoParaNulo();
            return entity;
        }

        public static Dto_GetBB037 ToDtoGet(this CSICP_Bb037 entity)
        {
            return entity != null ? new Dto_GetBB037
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Bb037Codigo = entity.Bb037Codigo,
                Bb037Descricao = entity.Bb037Descricao,
                Bb037Dia = entity.Bb037Dia,
                Bb037Qtddiasmcompra = entity.Bb037Qtddiasmcompra,
                Bb037Isactive = entity.Bb037Isactive,
            } : new Dto_GetBB037();
        }
    }
}
