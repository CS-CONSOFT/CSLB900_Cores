using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG008.GG008b;
using CSCore.Domain.CS_Models.CSICP_GG;
using GG104Materiais.C82Application.Mapper;

namespace CSCore.Application.Dto.Mapper.GG00X.GG008
{
    public static class GG008bMapper
    {
        public static DtoGetGG008b ToDtoGet(this CSICP_GG008b entity)
        {
            return new DtoGetGG008b
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg008bSeq = entity.Gg008bSeq,
                Gg008bRefsimilar = entity.Gg008bRefsimilar,
                Gg008bDatavigor = entity.Gg008bDatavigor,
                Gg008bMarcaid = entity.Gg008bMarcaid,
                NavGg006Marca = entity.NavGg006Marca?.ToDtoGetSimples(),
            };
        }
    }
}
