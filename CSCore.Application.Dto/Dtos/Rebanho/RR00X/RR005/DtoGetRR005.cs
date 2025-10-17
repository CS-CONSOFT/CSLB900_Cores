using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR005
{
    public class DtoGetRR005
    {
        public int TenantId { get; set; }

        public long Id { get; set; }

        public string? Rr005Situacao { get; set; }
    }
}