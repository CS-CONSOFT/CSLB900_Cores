using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD009
{
    public record DtoGetListDD009 : IConverteParaDTO<CSICP_DD009, DtoGetListDD009>
    {
        public int TenantId { get; init; }
        public string Dd009Id { get; init; } = null!;
        public string? Dd009Empresaid { get; init; }
        public string? Dd009CategoriaId { get; init; }
        public string? Dd009FormapagtoId { get; init; }
        public bool? Dd009Isactive { get; init; }

        public static DtoGetListDD009 FromEntity(CSICP_DD009 entity)
        {
            return new DtoGetListDD009
            {
                TenantId = entity.TenantId,
                Dd009Id = entity.Dd009Id,
                Dd009Empresaid = entity.Dd009Empresaid,
                Dd009CategoriaId = entity.Dd009CategoriaId,
                Dd009FormapagtoId = entity.Dd009FormapagtoId,
                Dd009Isactive = entity.Dd009Isactive
            };
        }
    }
}