using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY035
{
    public record Dto_GetListSy035 : IConverteParaDTO<ABAC_CSSPH_RESOURCE, Dto_GetListSy035>
    {
        public int? TenantId { get; init; }
        public string Id { get; init; } = null!;
        public string? Name { get; init; }
        public string? Displayname { get; init; }
        public string? Resourcetype { get; init; }
        public string? Module { get; init; }
        public string? Path { get; init; }
        public bool? Isactive { get; init; }
        public string? Parentid { get; init; }

        public static Dto_GetListSy035 FromEntity(ABAC_CSSPH_RESOURCE entity)
        {
            return new Dto_GetListSy035
            {
            
                Id = entity.Id,
                Name = entity.Name,
                Displayname = entity.Displayname,
                Resourcetype = entity.Resourcetype,
                Module = entity.Module,
                Path = entity.Path,
                Isactive = entity.Isactive,
                Parentid = entity.Parentid
            };
        }
    }
}
