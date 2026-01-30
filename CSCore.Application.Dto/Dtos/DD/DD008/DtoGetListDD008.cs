using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Domain;
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
        public Dto_GetBB001_Exibicao? NavBB001EmpresaID_DD008 { get; init; }
        public Dto_GetBB007SemListSimples? NavBB007ResponsavelID_DD008 { get; init; }
        public CSICP_Bb032? NavBB032CargoID_DD008 { get; init; }
        public Dto_GetBB026_Exibicao? NavBB026FormaPagtoID_DD008 { get; init; }
        public Dto_GetBB008_Exibicao? NavBB008CondPagtoID_DD008 { get; init; }

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
                Dd008Isactive = entity.Dd008Isactive,
                NavBB001EmpresaID_DD008 = entity.NavBB001EmpresaID_DD008?.ToDtoGetExibicao(),
                NavBB007ResponsavelID_DD008 = entity.NavBB007ResponsavelID_DD008?.ToDtoGetSimples(),
                NavBB032CargoID_DD008 = entity.NavBB032CargoID_DD008,
                NavBB026FormaPagtoID_DD008 = entity.NavBB026FormaPagtoID_DD008?.ToDtoGetExibicao(),
                NavBB008CondPagtoID_DD008 = entity.NavBB008CondPagtoID_DD008?.ToDtoGetSimples()
            };
        }
    }
}