using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY037
{
    public record Dto_GetListSy037 : IConverteParaEntidadeV2<OsusrE9aCsicpSy037, Dto_GetListSy037>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Resourceid { get; init; }
        public string? Attributename { get; init; }
        public string? Attributevalue { get; init; }
        public string? Attributetype { get; init; }

        public static Dto_GetListSy037 FromEntity(OsusrE9aCsicpSy037 entity)
        {
            return new Dto_GetListSy037
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Resourceid = entity.Resourceid,
                Attributename = entity.Attributename,
                Attributevalue = entity.Attributevalue,
                Attributetype = entity.Attributetype
            };
        }
    }
}
