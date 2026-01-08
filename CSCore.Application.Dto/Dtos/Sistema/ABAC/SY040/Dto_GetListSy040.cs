using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY040
{
    public record Dto_GetListSy040 : IConverteParaDTO<ABAC_CSSPH_FILTERS, Dto_GetListSy040>
    {
        public string Id { get; init; } = null!;
        public string? Fieldname { get; init; }
        public string? Displayname { get; init; }
        public string? Datatype { get; init; }
        public string? Controltype { get; init; }
        public string? Optionssource { get; init; }
        public bool? Isactive { get; init; }

        public static Dto_GetListSy040 FromEntity(ABAC_CSSPH_FILTERS entity)
        {
            return new Dto_GetListSy040
            {
                Id = entity.Id,
                Fieldname = entity.Fieldname,
                Displayname = entity.Displayname,
                Datatype = entity.Datatype,
                Controltype = entity.Controltype,
                Optionssource = entity.Optionssource,
                Isactive = entity.Isactive
            };
        }
    }
}
