using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY031
{
    public record Dto_UpdateSy031 : IConverteParaEntidade<OsusrE9aCsicpSy031>
    {
        public string? Sy031Usuarioid { get; init; }
        public string? Sy031Grupoid { get; init; }
        public bool? Sy031Isactive { get; init; }

        public OsusrE9aCsicpSy031 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy031
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Sy031Usuarioid = this.Sy031Usuarioid,
                Sy031Grupoid = this.Sy031Grupoid,
                Sy031Isactive = this.Sy031Isactive
            };
        }
    }
}
