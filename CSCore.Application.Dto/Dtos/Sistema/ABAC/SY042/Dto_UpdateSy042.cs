using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY042
{
    public record Dto_UpdateSy042 : IConverteParaEntidade<OsusrE9aCsicpSy042>
    {
        public string? Filterid { get; init; }
        public string? Operatorid { get; init; }

        public OsusrE9aCsicpSy042 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy042
            {
                Id = id ?? string.Empty,
                Filterid = this.Filterid,
                Operatorid = this.Operatorid
            };
        }
    }
}
