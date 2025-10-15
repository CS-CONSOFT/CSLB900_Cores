using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR003;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR003
{
    public static class RR003Mapper
    {
        public static DtoGetRR003 ToDtoGetRR003(this OsusrTo3CsicpRr003 entity)
        {
            return new DtoGetRR003
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr003Descricao = entity.Rr003Descricao
            };
        }
    }
}