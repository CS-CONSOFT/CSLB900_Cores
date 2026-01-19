using CSCore.Domain.CS_Models.CSICP_DD;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD009
{
    public record DtoCreateDD009 : IConverteParaEntidade<CSICP_DD009>
    {
        public string? Dd009Empresaid { get; init; }
        public string? Dd009CategoriaId { get; init; }
        public string? Dd009FormapagtoId { get; init; }
        public bool? Dd009Isactive { get; init; }

        public CSICP_DD009 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD009
            {
                TenantId = tenant,
                Dd009Id = id ?? string.Empty,
                Dd009Empresaid = this.Dd009Empresaid,
                Dd009CategoriaId = this.Dd009CategoriaId,
                Dd009FormapagtoId = this.Dd009FormapagtoId,
                Dd009Isactive = this.Dd009Isactive
            };
        }
    }
}