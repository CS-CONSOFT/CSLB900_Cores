using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY035
{
    public record Dto_UpdateSy035 : IConverteParaEntidade<ABAC_CSSPH_RESOURCE>
    {
        public string? Name { get; init; }
        public string? Displayname { get; init; }
        public string? Resourcetype { get; init; }
        public string? Module { get; init; }
        public string? Path { get; init; }
        public bool? Isactive { get; init; }
        public string? Parentid { get; init; }

        public ABAC_CSSPH_RESOURCE ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_RESOURCE
            {
               
                Name = this.Name,
                Displayname = this.Displayname,
                Resourcetype = this.Resourcetype,
                Module = this.Module,
                Path = this.Path,
                Isactive = this.Isactive,
                Parentid = this.Parentid
            };
        }
    }
}
