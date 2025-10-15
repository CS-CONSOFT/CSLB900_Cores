using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008e;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X;

    public static class GG008eMapper
    {
        public static DtoGetGG008e ToDtoGet(this CSICP_GG008e entity)
        {
            return new DtoGetGG008e
            {
                TenantId = entity.TenantId,
                Gg008eId = entity.Gg008eId,
                Gg008eSeq = entity.Gg008eSeq,
                Gg008eDescricao = entity.Gg008eDescricao,
                Gg008eCodigo = entity.Gg008eCodigo,
                Gg008eProdutoid = entity.Gg008eProdutoid,
            };
        }
    }
