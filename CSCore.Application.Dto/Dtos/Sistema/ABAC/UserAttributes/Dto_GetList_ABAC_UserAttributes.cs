using CSCore.Domain.DELETAR;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.UserAttributes
{
    public record Dto_GetList_ABAC_UserAttributes : IConverteParaDTO<ABAC_CSSPH_ABACUSERATTRIBUTES, Dto_GetList_ABAC_UserAttributes>
    {
        public string? Id { get; init; }
        public string? Attributename { get; init; }
        public string? Label { get; init; }
        public string? Datatype { get; init; }
        public bool? Iscore { get; init; }
        public bool? Isactive { get; init; }

        public static Dto_GetList_ABAC_UserAttributes FromEntity(ABAC_CSSPH_ABACUSERATTRIBUTES entity)
        {
            return new Dto_GetList_ABAC_UserAttributes
            {
                Id = entity.Id,
                Attributename = entity.Attributename,
                Label = entity.Label,
                Datatype = entity.Datatype,
                Iscore = entity.Iscore,
                Isactive = entity.Isactive
            };
        }
    }
}
