using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.ResourceAttributes
{
    public record Dto_Get_ABAC_ResourceAttributes : IConverteParaDTO<ABAC_CSSPH_ABACRESOURCEATTRIBUTES, Dto_Get_ABAC_ResourceAttributes>
    {
        public string? Id { get; init; }
        public string? Attributename { get; init; }
        public string? Label { get; init; }
        public string? Datatype { get; init; }
        public string? Description { get; init; }
        public string? Enumvalues { get; init; }
        public bool? Iscore { get; init; }
        public bool? Isactive { get; init; }
        public DateTime? Createdat { get; init; }

        public static Dto_Get_ABAC_ResourceAttributes FromEntity(ABAC_CSSPH_ABACRESOURCEATTRIBUTES entity)
        {
            return new Dto_Get_ABAC_ResourceAttributes
            {
                Id = entity.Id,
                Attributename = entity.Attributename,
                Label = entity.Label,
                Datatype = entity.Datatype,
                Description = entity.Description,
                Enumvalues = entity.Enumvalues,
                Iscore = entity.Iscore,
                Isactive = entity.Isactive,
                Createdat = entity.Createdat
            };
        }
    }
}
