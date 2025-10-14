using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR004;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR004
{
    public static class RR004Mapper
    {
        public static DtoGetRR004 ToDtoGetRR004(this OsusrTo3CsicpRr004 entity)
        {
            return new DtoGetRR004
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr004Raca = entity.Rr004Raca
            };
        }
    }
}