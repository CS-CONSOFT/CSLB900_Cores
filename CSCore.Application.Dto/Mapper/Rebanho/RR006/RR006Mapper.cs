using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR006;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR006
{
    public static class RR006Mapper
    {
        public static DtoGetRR006 ToDtoGetRR006(this OsusrTo3CsicpRr006 entity)
        {
            return new DtoGetRR006
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr006Ocorrencia = entity.Rr006Ocorrencia
            };
        }
    }
}