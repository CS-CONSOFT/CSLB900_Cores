using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY037
{
    public record Dto_UpdateSy037 : IConverteParaEntidade<ABAC_CSSPH_RESOURCEATRIB>
    {
        public string? Resourceid { get; init; }
        public string? Attributename { get; init; }
        public string? Attributevalue { get; init; }
        public string? Attributetype { get; init; }

        public ABAC_CSSPH_RESOURCEATRIB ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_RESOURCEATRIB
            {
        
                Id = id ?? string.Empty,
                Resourceid = this.Resourceid,
                Attributename = this.Attributename,
                Attributevalue = this.Attributevalue,
                Attributetype = this.Attributetype
            };
        }
    }
}
