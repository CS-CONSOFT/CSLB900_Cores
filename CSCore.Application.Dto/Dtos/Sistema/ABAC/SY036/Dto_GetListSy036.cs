using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY036
{
    public record Dto_GetListSy036 : IConverteParaDTO<ABAC_CSSPH_RESOURCEACTIONS, Dto_GetListSy036>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Resourceid { get; init; }
        public string? Actionname { get; init; }
        public string? DisplayName { get; init; }
        public string? Description { get; init; }

        public static Dto_GetListSy036 FromEntity(ABAC_CSSPH_RESOURCEACTIONS entity)
        {
            return new Dto_GetListSy036
            {
                Id = entity.Id,
                Resourceid = entity.Resourceid,
                Actionname = entity.Actionname,
                Description = entity.Description,
                DisplayName = entity.DisplayName,
            };
        }
    }
}
