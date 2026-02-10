using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR010;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR010
{
    public static class RR010Mapper
    {
        /// <summary>
        /// Converte entidade RR010 para DTO de retorno completo
        /// </summary>
        public static DtoGetRR010 ToDtoGetRR010(this OsusrTo3CsicpRr010 entity)
        {
            return new DtoGetRR010
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr010Condcriacao = entity.Rr010Condcriacao,
                Rr010Descritivo = entity.Rr010Descritivo
            };
        }
    }
}