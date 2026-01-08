using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY041
{
    public record Dto_GetListSy041 : IConverteParaEntidadeV2<ABAC_CSSPH_OPERADORES, Dto_GetListSy041>
    {
        public string Id { get; init; } = null!;
        public string? Operator { get; init; }
        public string? Description { get; init; }

        public static Dto_GetListSy041 FromEntity(ABAC_CSSPH_OPERADORES entity)
        {
            return new Dto_GetListSy041
            {
                Id = entity.Id,
                Operator = entity.Operator,
                Description = entity.Description
            };
        }
    }
}
