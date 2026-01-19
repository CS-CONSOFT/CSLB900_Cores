using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY036
{
    public record Dto_CreateSy036 : IConverteParaEntidade<ABAC_CSSPH_RESOURCEACTIONS>
    {
        public string? Resourceid { get; init; }
        public string? Actionname { get; init; }

        public ABAC_CSSPH_RESOURCEACTIONS ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_RESOURCEACTIONS
            {
                Id = id ?? string.Empty,
                Resourceid = this.Resourceid,
                Actionname = this.Actionname
            };
        }
    }
}
