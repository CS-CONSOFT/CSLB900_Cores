using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY043
{
    public record Dto_CreateSy043 : IConverteParaEntidade<OsusrE9aCsicpSy043>
    {
        public string? Resourceid { get; init; }
        public string? Filterid { get; init; }
        public int? Orderindex { get; init; }
        public bool? Isrequired { get; init; }

        public OsusrE9aCsicpSy043 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy043
            {
                Id = long.TryParse(id, out var idValue) ? idValue : 0,
                Resourceid = this.Resourceid,
                Filterid = this.Filterid,
                Orderindex = this.Orderindex,
                Isrequired = this.Isrequired
            };
        }
    }
}
