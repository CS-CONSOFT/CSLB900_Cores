using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD013
{
    public record DtoUpdateDD013 : IConverteParaEntidade<CSICP_DD013>
    {
        public string? Dd013Empresaid { get; init; }
        public string? Dd013Texto { get; init; }

        public CSICP_DD013 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD013
            {
                TenantId = tenant,
                Dd013Id = id ?? string.Empty,
                Dd013Empresaid = this.Dd013Empresaid,
                Dd013Texto = this.Dd013Texto,
            };
        }
    }
}