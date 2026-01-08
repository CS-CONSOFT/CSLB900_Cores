using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY031
{
    public record Dto_GetListSy031 : IConverteParaEntidadeV2<OsusrE9aCsicpSy031, Dto_GetListSy031>
    {
        public int TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Sy031Usuarioid { get; init; }
        public string? Sy031Grupoid { get; init; }
        public bool? Sy031Isactive { get; init; }

        public static Dto_GetListSy031 FromEntity(OsusrE9aCsicpSy031 entity)
        {
            return new Dto_GetListSy031
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy031Usuarioid = entity.Sy031Usuarioid,
                Sy031Grupoid = entity.Sy031Grupoid,
                Sy031Isactive = entity.Sy031Isactive
            };
        }
    }
}
