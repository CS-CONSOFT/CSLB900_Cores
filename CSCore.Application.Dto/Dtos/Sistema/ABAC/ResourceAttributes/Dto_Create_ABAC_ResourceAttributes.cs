using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.ResourceAttributes
{
    public record Dto_Create_ABAC_ResourceAttributes : IConverteParaEntidade<ABAC_CSSPH_ABACRESOURCEATTRIBUTES>
    {
        public string? Attributename { get; init; }
        public string? Label { get; init; }
        public string? Datatype { get; init; }
        public string? Description { get; init; }
        public string? Enumvalues { get; init; }
        public bool? Iscore { get; init; }
        public bool? Isactive { get; init; }

        public ABAC_CSSPH_ABACRESOURCEATTRIBUTES ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_ABACRESOURCEATTRIBUTES
            {
                Id = id ?? string.Empty,
                Attributename = this.Attributename,
                Label = this.Label,
                Datatype = this.Datatype,
                Description = this.Description,
                Enumvalues = this.Enumvalues,
                Iscore = this.Iscore,
                Isactive = this.Isactive,
                Createdat = DateTime.UtcNow
            };
        }
    }
}
