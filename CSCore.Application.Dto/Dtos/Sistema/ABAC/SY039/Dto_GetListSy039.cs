using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY039
{
    public record Dto_GetListSy039 : IConverteParaEntidadeV2<OsusrE9aCsicpSy039, Dto_GetListSy039>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Policyid { get; init; }
        public string? Rulename { get; init; }
        public string? Effect { get; init; }
        public int? Priority { get; init; }
        public string? Conditions { get; init; }
        public string? Actions { get; init; }
        public string? Resources { get; init; }

        public static Dto_GetListSy039 FromEntity(OsusrE9aCsicpSy039 entity)
        {
            return new Dto_GetListSy039
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Policyid = entity.Policyid,
                Rulename = entity.Rulename,
                Effect = entity.Effect,
                Priority = entity.Priority,
                Conditions = entity.Conditions,
                Actions = entity.Actions,
                Resources = entity.Resources
            };
        }
    }
}
