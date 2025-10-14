using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR005;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR005
{
    public static class RR005Mapper
    {
        public static DtoGetRR005 ToDtoGetRR005(this OsusrTo3CsicpRr005 entity)
        {
            return new DtoGetRR005
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr005Situacao = entity.Rr005Situacao
            };
        }
    }
}