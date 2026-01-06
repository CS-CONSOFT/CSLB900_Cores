using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY042
{
    public record Dto_GetListSy042 : IConverteParaEntidadeV2<OsusrE9aCsicpSy042, Dto_GetListSy042>
    {
        public string Id { get; init; } = null!;
        public string? Filterid { get; init; }
        public string? Operatorid { get; init; }

        public static Dto_GetListSy042 FromEntity(OsusrE9aCsicpSy042 entity)
        {
            return new Dto_GetListSy042
            {
                Id = entity.Id,
                Filterid = entity.Filterid,
                Operatorid = entity.Operatorid
            };
        }
    }
}
