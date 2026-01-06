using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY042
{
    public record Dto_GetSy042 : IConverteParaEntidadeV2<OsusrE9aCsicpSy042, Dto_GetSy042>
    {
        public string Id { get; init; } = null!;
        public string? Filterid { get; init; }
        public string? Operatorid { get; init; }

        public static Dto_GetSy042 FromEntity(OsusrE9aCsicpSy042 entity)
        {
            return new Dto_GetSy042
            {
                Id = entity.Id,
                Filterid = entity.Filterid,
                Operatorid = entity.Operatorid
            };
        }
    }
}
