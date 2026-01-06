using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY041
{
    public record Dto_UpdateSy041 : IConverteParaEntidade<OsusrE9aCsicpSy041>
    {
        public string? Operator { get; init; }
        public string? Description { get; init; }

        public OsusrE9aCsicpSy041 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy041
            {
                Id = id ?? string.Empty,
                Operator = this.Operator,
                Description = this.Description
            };
        }
    }
}
