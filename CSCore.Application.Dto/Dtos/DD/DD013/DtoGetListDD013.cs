using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD013
{
    public record DtoGetListDD013 : IConverteParaDTO<CSICP_DD013, DtoGetListDD013>
    {
        public int TenantId { get; init; }
        public string Dd013Id { get; init; } = null!;
        public string? Dd013Empresaid { get; init; }
        public string? Dd013Texto { get; init; }
        public string? Dd013Protocolnumber { get; init; }

        public static DtoGetListDD013 FromEntity(CSICP_DD013 entity)
        {
            return new DtoGetListDD013
            {
                TenantId = entity.TenantId,
                Dd013Id = entity.Dd013Id,
                Dd013Empresaid = entity.Dd013Empresaid,
                Dd013Texto = entity.Dd013Texto,
                Dd013Protocolnumber = entity.Dd013Protocolnumber
            };
        }
    }
}