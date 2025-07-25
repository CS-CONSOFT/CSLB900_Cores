using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008a;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X.GG008
{
    public static class GG008aMapper
    {
        public static DtoGetGG008a ToDtoGet(this CSICP_GG008a entity)
        {
            return new DtoGetGG008a
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg008aFilialid = entity.Gg008aFilialid,
                Gg008aProdutoid = entity.Gg008aProdutoid,
                Gg08aFilial = entity.Gg08aFilial,
                Gg08aCodgProduto = entity.Gg08aCodgProduto,
                Gg08aLinha = entity.Gg08aLinha,
                Gg08aCaracteristica = entity.Gg08aCaracteristica,
                Gg008aValor = entity.Gg008aValor,
            };
        }
    }
}
