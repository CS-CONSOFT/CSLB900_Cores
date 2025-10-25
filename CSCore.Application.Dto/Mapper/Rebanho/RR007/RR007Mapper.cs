using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR007;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR007
{
    public static class RR007Mapper
    {
        public static DtoGetRR007 ToDtoGetRR007(this OsusrTo3CsicpRr007 entity)
        {
            return new DtoGetRR007
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr007Proprietario = entity.Rr007Proprietario
            };
        }
    }
}