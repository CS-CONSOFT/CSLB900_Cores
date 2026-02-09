using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR011;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR011
{
    public static class RR011Mapper
    {
        /// <summary>
        /// Converte entidade RR011 para DTO de retorno completo
        /// </summary>
        public static DtoGetRR011 ToDtoGetRR011(this OsusrTo3CsicpRr011 entity)
        {
            return new DtoGetRR011
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr011Serie = entity.Rr011Serie ?? string.Empty,
                Rr011Ultrgn = entity.Rr011Ultrgn ?? 0
            };
        }

    }
}