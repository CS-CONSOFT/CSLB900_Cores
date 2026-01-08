using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY041
{
    public record Dto_CreateSy041 : IConverteParaEntidade<ABAC_CSSPH_OPERADORES>
    {
        public string? Operator { get; init; }
        public string? Description { get; init; }

        public ABAC_CSSPH_OPERADORES ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_OPERADORES
            {
                Id = id ?? string.Empty,
                Operator = this.Operator,
                Description = this.Description
            };
        }
    }
}
