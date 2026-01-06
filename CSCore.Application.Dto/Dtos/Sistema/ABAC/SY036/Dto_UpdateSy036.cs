using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY036
{
    public record Dto_UpdateSy036 : IConverteParaEntidade<OsusrE9aCsicpSy036>
    {
        public string? Resourceid { get; init; }
        public string? Actionname { get; init; }

        public OsusrE9aCsicpSy036 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy036
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Resourceid = this.Resourceid,
                Actionname = this.Actionname
            };
        }
    }
}
