using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY043
{
    public record Dto_GetListSy043 : IConverteParaEntidadeV2<ABAC_CSSPH_FILTERSRESOURCE, Dto_GetListSy043>
    {
        public long Id { get; init; }
        public string? Resourceid { get; init; }
        public string? Filterid { get; init; }
        public int? Orderindex { get; init; }
        public bool? Isrequired { get; init; }

        public static Dto_GetListSy043 FromEntity(ABAC_CSSPH_FILTERSRESOURCE entity)
        {
            return new Dto_GetListSy043
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
