using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY030
{
    public record Dto_CreateSy030 : IConverteParaEntidade<OsusrE9aCsicpSy030>
    {
        public string? Sy030Name { get; init; }
        public string? Sy030Descricao { get; init; }
        public bool? Sy030Isactive { get; init; }

        public OsusrE9aCsicpSy030 ToEntity(int tenant, string? id)
        {
            return new OsusrE9aCsicpSy030
            {
                TenantId = tenant,
                Id = id ?? string.Empty,
                Sy030Name = this.Sy030Name,
                Sy030Descricao = this.Sy030Descricao,
                Sy030Isactive = this.Sy030Isactive
            };
        }
    }
}