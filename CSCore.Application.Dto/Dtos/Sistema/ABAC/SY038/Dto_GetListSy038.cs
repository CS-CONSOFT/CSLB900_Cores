using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY038
{
    public record Dto_GetListSy038 : IConverteParaDTO<CSSPH_POLICYS, Dto_GetListSy038>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Name { get; init; }
        public string? Descripton { get; init; }
        public string? Policyjson { get; init; }
        public int? Priority { get; init; }
        public bool? Isactive { get; init; }

        public static Dto_GetListSy038 FromEntity(CSSPH_POLICYS entity)
        {
            return new Dto_GetListSy038
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Name = entity.Name,
                Descripton = entity.Descripton,
                Policyjson = entity.Policyjson,
                Priority = entity.Priority,
                Isactive = entity.Isactive
            };
        }
    }
}
