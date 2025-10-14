using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR008;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR008
{
    public static class RR008Mapper
    {
        public static DtoGetRR008 ToDtoGetRR008(this OsusrTo3CsicpRr008 entity)
        {
            return new DtoGetRR008
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr008Regalimentar = entity.Rr008Regalimentar,
                Rr008Descritivo = entity.Rr008Descritivo
            };
        }
    }
}