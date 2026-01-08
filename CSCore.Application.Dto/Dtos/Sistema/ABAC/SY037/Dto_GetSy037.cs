using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY037
{
    public record Dto_GetSy037 : IConverteParaEntidadeV2<ABAC_CSSPH_RESOURCEATRIB, Dto_GetSy037>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Resourceid { get; init; }
        public string? Attributename { get; init; }
        public string? Attributevalue { get; init; }
        public string? Attributetype { get; init; }

        public static Dto_GetSy037 FromEntity(ABAC_CSSPH_RESOURCEATRIB entity)
        {
            return new Dto_GetSy037
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
