using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY030
{
    public record Dto_GetListSy030 : IConverteParaEntidadeV2<OsusrE9aCsicpSy030, Dto_GetListSy030>
    {
        public int TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Sy030Name { get; init; }
        public string? Sy030Descricao { get; init; }
        public bool? Sy030Isactive { get; init; }

        public static Dto_GetListSy030 FromEntity(OsusrE9aCsicpSy030 entity)
        {
            return new Dto_GetListSy030
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy030Name = entity.Sy030Name,
                Sy030Descricao = entity.Sy030Descricao,
                Sy030Isactive = entity.Sy030Isactive
            };
        }
    }
}