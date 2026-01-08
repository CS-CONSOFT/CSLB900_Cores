using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY032
{
    public record Dto_UpdateSy032 : IConverteParaEntidade<OsusrE9aCsicpSy032>
    {
        public string? Sy032Usuarioid { get; init; }
        public string? Attributename { get; init; }
        public string? Attributevalue { get; init; }
        public string? Attributetype { get; init; }

        public OsusrE9aCsicpSy032 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy032
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Sy032Usuarioid = this.Sy032Usuarioid,
                Attributename = this.Attributename,
                Attributevalue = this.Attributevalue,
                Attributetype = this.Attributetype
            };
        }
    }
}
