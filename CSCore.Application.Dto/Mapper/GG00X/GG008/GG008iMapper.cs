using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008i;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X.GG008
{
    public static class GG008iMapper
    {
        public static DtoGetGG008i ToDtoGet(this CSICP_GG008i entity)
        {
            return new DtoGetGG008i
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg008iFilialid = entity.Gg008iFilialid,
                Gg008iKardexId = entity.Gg008iKardexId,
                Gg008iProdutoid = entity.Gg008iProdutoid,
                Gg008iTransacaoid = entity.Gg008iTransacaoid,
                Gg008iTiporegistro = entity.Gg008iTiporegistro,
                Gg008iNcmId = entity.Gg008iNcmId,
                NavBB027Transacao = entity.NavBB027Transacao?.ToDtoGetSimples(),
                NavGG008Trans = entity.NavGG008Trans
            };
        }
    }
}