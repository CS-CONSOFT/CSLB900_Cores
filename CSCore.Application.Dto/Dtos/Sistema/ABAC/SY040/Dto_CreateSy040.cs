using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY040
{
    public record Dto_CreateSy040 : IConverteParaEntidade<ABAC_CSSPH_FILTERS>
    {
        public string? Fieldname { get; init; }
        public string? Displayname { get; init; }
        public string? Datatype { get; init; }
        public string? Controltype { get; init; }
        public string? Optionssource { get; init; }
        public bool? Isactive { get; init; }

        public ABAC_CSSPH_FILTERS ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_FILTERS
            {
                Id = id ?? string.Empty,
                Fieldname = this.Fieldname,
                Displayname = this.Displayname,
                Datatype = this.Datatype,
                Controltype = this.Controltype,
                Optionssource = this.Optionssource,
                Isactive = this.Isactive
            };
        }
    }
}
