using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR008
{
    public class DtoGetRR008
    {
        public int TenantId { get; set; }

        public long Id { get; set; }

        public string? Rr008Regalimentar { get; set; }

        public string? Rr008Descritivo { get; set; }
    }
}