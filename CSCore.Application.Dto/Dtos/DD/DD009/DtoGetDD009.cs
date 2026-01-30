using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB026;
using CSBS101._82Application.Dto.BB00X.BB029;
using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD009
{
    public record DtoGetDD009 : IConverteParaDTO<CSICP_DD009, DtoGetDD009>
    {
        public int TenantId { get; init; }
        public string Dd009Id { get; init; } = null!;
        public string? Dd009Empresaid { get; init; }
        public string? Dd009CategoriaId { get; init; }
        public string? Dd009FormapagtoId { get; init; }
        public bool? Dd009Isactive { get; init; }

        public Dto_GetBB001_Exibicao? NavBB001EmpresaID_DD009 { get; init; }

        public Dto_GetBB029? NavBB029CategoriaID_DD009 { get; init; }

        public Dto_GetBB026_Exibicao? NavBB026FormaPagtoID_DD009 { get; init; }

        public static DtoGetDD009 FromEntity(CSICP_DD009 entity)
        {
            return new DtoGetDD009
            {
                TenantId = entity.TenantId,
                Dd009Id = entity.Dd009Id,
                Dd009Empresaid = entity.Dd009Empresaid,
                Dd009CategoriaId = entity.Dd009CategoriaId,
                Dd009FormapagtoId = entity.Dd009FormapagtoId,
                Dd009Isactive = entity.Dd009Isactive,
                NavBB001EmpresaID_DD009 = entity.NavBB001EmpresaID_DD009?.ToDtoGetExibicao(),
                NavBB029CategoriaID_DD009 = entity.NavBB029CategoriaID_DD009?.ToDtoGet(),
                NavBB026FormaPagtoID_DD009 = entity.NavBB026FormaPagtoID_DD009?.ToDtoGetExibicao(),
            };
        }
    }
}