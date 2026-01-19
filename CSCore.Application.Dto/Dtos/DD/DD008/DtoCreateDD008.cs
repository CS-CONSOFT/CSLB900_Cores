using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD008
{
    public record DtoCreateDD008 : IConverteParaEntidade<CSICP_DD008>
    {
        public string? Dd008Empresaid { get; init; }
        public string? Dd008ResponsavelId { get; init; }
        public string? Dd008CargoId { get; init; }
        public string? Dd008FormapagtoId { get; init; }
        public string? Dd008CondpagtoId { get; init; }
        public decimal? Dd008Valorate { get; init; }
        public decimal? Dd008Percdesconto { get; init; }
        public bool? Dd008Isactive { get; init; }

        public CSICP_DD008 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD008
            {
                TenantId = tenant,
                Dd008Id = id ?? string.Empty,
                Dd008Empresaid = this.Dd008Empresaid,
                Dd008ResponsavelId = this.Dd008ResponsavelId,
                Dd008CargoId = this.Dd008CargoId,
                Dd008FormapagtoId = this.Dd008FormapagtoId,
                Dd008CondpagtoId = this.Dd008CondpagtoId,
                Dd008Valorate = this.Dd008Valorate,
                Dd008Percdesconto = this.Dd008Percdesconto,
                Dd008Isactive = this.Dd008Isactive
            };
        }
    }
}