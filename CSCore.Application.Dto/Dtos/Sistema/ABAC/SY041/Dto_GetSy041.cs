using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY041
{
    public record Dto_GetSy041 : IConverteParaDTO<ABAC_CSSPH_OPERADORES, Dto_GetSy041>
    {
        public string Id { get; init; } = null!;
        public string? Operator { get; init; }
        public string? Description { get; init; }

        public static Dto_GetSy041 FromEntity(ABAC_CSSPH_OPERADORES entity)
        {
            return new Dto_GetSy041
            {
                Id = entity.Id,
                Operator = entity.Operator,
                Description = entity.Description
            };
        }
    }
}
