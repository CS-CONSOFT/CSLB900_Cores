using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY039
{
    public record Dto_CreateSy039 : IConverteParaEntidade<CSSPH_POLICIESRULES>
    {
        public string? Policyid { get; init; }
        public string? Rulename { get; init; }
        public string? Effect { get; init; }
        public int? Priority { get; init; }
        public string? Conditions { get; init; }
        public string? Actions { get; init; }
        public string? Resources { get; init; }

        public CSSPH_POLICIESRULES ToEntity(int tenant, string? id)
        {
            return new CSSPH_POLICIESRULES
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Policyid = this.Policyid,
                Rulename = this.Rulename,
                Effect = this.Effect,
                Priority = this.Priority,
                Conditions = this.Conditions,
                Actions = this.Actions,
                Resources = this.Resources
            };
        }
    }
}
