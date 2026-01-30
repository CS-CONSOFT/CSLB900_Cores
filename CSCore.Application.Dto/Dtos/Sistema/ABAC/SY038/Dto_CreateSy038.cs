using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY038
{
    public record Dto_CreateSy038 : IConverteParaEntidade<CSSPH_POLICYS>
    {
        public string? Name { get; init; }
        public string? Descripton { get; init; }
        public string? Policyjson { get; init; }
        public int? Priority { get; init; }
        public bool? Isactive { get; init; }

        public CSSPH_POLICYS ToEntity(int tenant, string? id)
        {
            return new CSSPH_POLICYS
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Name = this.Name,
                Descripton = this.Descripton,
                Policyjson = this.Policyjson,
                Priority = this.Priority,
                Isactive = this.Isactive
            };
        }
    }
}
