using CSCore.Domain.DELETAR;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.UserAttributes
{
    public record Dto_Get_ABAC_UserAttributes : IConverteParaDTO<ABAC_CSSPH_ABACUSERATTRIBUTES, Dto_Get_ABAC_UserAttributes>
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

        public static Dto_Get_ABAC_UserAttributes FromEntity(ABAC_CSSPH_ABACUSERATTRIBUTES entity)
        {
            return new Dto_Get_ABAC_UserAttributes
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
