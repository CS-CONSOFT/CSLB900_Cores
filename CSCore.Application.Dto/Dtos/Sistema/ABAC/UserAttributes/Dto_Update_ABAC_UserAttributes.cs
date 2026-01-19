using CSCore.Domain.DELETAR;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.UserAttributes
{
    public record Dto_Update_ABAC_UserAttributes : IConverteParaEntidade<ABAC_CSSPH_ABACUSERATTRIBUTES>
    {
        public string? Attributename { get; init; }
        public string? Label { get; init; }
        public string? Datatype { get; init; }
        public string? Description { get; init; }
        public string? Enumvalues { get; init; }
        public bool? Iscore { get; init; }
        public bool? Isactive { get; init; }

        public ABAC_CSSPH_ABACUSERATTRIBUTES ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_ABACUSERATTRIBUTES
            {
                Id = id ?? string.Empty,
                Attributename = this.Attributename,
                Label = this.Label,
                Datatype = this.Datatype,
                Description = this.Description,
                Enumvalues = this.Enumvalues,
                Iscore = this.Iscore,
                Isactive = this.Isactive
            };
        }
    }
}
