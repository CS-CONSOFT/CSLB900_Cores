using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD008
{
    public record DtoGetListDD008 : IConverteParaDTO<CSICP_DD008, DtoGetListDD008>
    {
        public int TenantId { get; init; }
        public string Dd008Id { get; init; } = null!;
        public string? Dd008Empresaid { get; init; }
        public string? Dd008ResponsavelId { get; init; }
        public string? Dd008CargoId { get; init; }
        public string? Dd008FormapagtoId { get; init; }
        public string? Dd008CondpagtoId { get; init; }
        public decimal? Dd008Valorate { get; init; }
        public decimal? Dd008Percdesconto { get; init; }
        public bool? Dd008Isactive { get; init; }

        public static DtoGetListDD008 FromEntity(CSICP_DD008 entity)
        {
            return new DtoGetListDD008
            {
                TenantId = entity.TenantId,
                Dd008Id = entity.Dd008Id,
                Dd008Empresaid = entity.Dd008Empresaid,
                Dd008ResponsavelId = entity.Dd008ResponsavelId,
                Dd008CargoId = entity.Dd008CargoId,
                Dd008FormapagtoId = entity.Dd008FormapagtoId,
                Dd008CondpagtoId = entity.Dd008CondpagtoId,
                Dd008Valorate = entity.Dd008Valorate,
                Dd008Percdesconto = entity.Dd008Percdesconto,
                Dd008Isactive = entity.Dd008Isactive
            };
        }
    }
}