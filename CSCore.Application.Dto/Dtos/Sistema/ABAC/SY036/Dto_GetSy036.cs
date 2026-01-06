using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY036
{
    public record Dto_GetSy036 : IConverteParaEntidadeV2<OsusrE9aCsicpSy036, Dto_GetSy036>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Resourceid { get; init; }
        public string? Actionname { get; init; }

        public static Dto_GetSy036 FromEntity(OsusrE9aCsicpSy036 entity)
        {
            return new Dto_GetSy036
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Resourceid = entity.Resourceid,
                Actionname = entity.Actionname
            };
        }
    }
}
