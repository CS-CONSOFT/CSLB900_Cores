using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY038
{
    public record Dto_UpdateSy038 : IConverteParaEntidade<OsusrE9aCsicpSy038>
    {
        public string? Name { get; init; }
        public string? Descripton { get; init; }
        public string? Policyjson { get; init; }
        public int? Priority { get; init; }
        public bool? Isactive { get; init; }

        public OsusrE9aCsicpSy038 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy038
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Name = this.Name,
                Descripton = this.Descripton,
                Policyjson = this.Policyjson,
                Priority = this.Priority,
                Isactive = this.Isactive
            };
        }
    }
}
