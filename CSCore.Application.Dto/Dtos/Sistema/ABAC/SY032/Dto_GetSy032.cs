using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY032
{
    public record Dto_GetSy032 : IConverteParaEntidadeV2<OsusrE9aCsicpSy032, Dto_GetSy032>
    {
        public int TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Sy032Usuarioid { get; init; }
        public string? Attributename { get; init; }
        public string? Attributevalue { get; init; }
        public string? Attributetype { get; init; }

        public static Dto_GetSy032 FromEntity(OsusrE9aCsicpSy032 entity)
        {
            return new Dto_GetSy032
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Sy032Usuarioid = entity.Sy032Usuarioid,
                Attributename = entity.Attributename,
                Attributevalue = entity.Attributevalue,
                Attributetype = entity.Attributetype
            };
        }
    }
}
