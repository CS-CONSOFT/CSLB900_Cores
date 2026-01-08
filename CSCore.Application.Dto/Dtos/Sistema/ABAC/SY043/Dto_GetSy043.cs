using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY043
{
    public record Dto_GetSy043 : IConverteParaDTO<ABAC_CSSPH_FILTERSRESOURCE, Dto_GetSy043>
    {
        public long Id { get; init; }
        public string? Resourceid { get; init; }
        public string? Filterid { get; init; }
        public int? Orderindex { get; init; }
        public bool? Isrequired { get; init; }

        public static Dto_GetSy043 FromEntity(ABAC_CSSPH_FILTERSRESOURCE entity)
        {
            return new Dto_GetSy043
            {
                Id = entity.Id,
                Resourceid = entity.Resourceid,
                Filterid = entity.Filterid,
                Orderindex = entity.Orderindex,
                Isrequired = entity.Isrequired
            };
        }
    }
}
