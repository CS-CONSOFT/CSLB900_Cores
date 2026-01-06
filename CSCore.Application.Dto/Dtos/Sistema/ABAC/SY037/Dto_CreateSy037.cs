using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY037
{
    public record Dto_CreateSy037 : IConverteParaEntidade<OsusrE9aCsicpSy037>
    {
        public string? Resourceid { get; init; }
        public string? Attributename { get; init; }
        public string? Attributevalue { get; init; }
        public string? Attributetype { get; init; }

        public OsusrE9aCsicpSy037 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy037
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Resourceid = this.Resourceid,
                Attributename = this.Attributename,
                Attributevalue = this.Attributevalue,
                Attributetype = this.Attributetype
            };
        }
    }
}
