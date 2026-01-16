using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD001
{
    public record DtoUpdateDD001 : IConverteParaEntidade<CSICP_DD001>
    {
        public string? Dd001Empresaid { get; init; }
        public int? Dd001Filial { get; init; }
        public string? Dd001Descricao { get; init; }
        public bool? Dd001Isactive { get; init; }
        public DateTime? Dd001Datainicio { get; init; }
        public DateTime? Dd001Datafim { get; init; }

        public CSICP_DD001 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD001
            {
                TenantId = tenant,
                Dd001Id = id ?? string.Empty,
                Dd001Empresaid = this.Dd001Empresaid,
                Dd001Filial = this.Dd001Filial,
                Dd001Descricao = this.Dd001Descricao,
                Dd001Isactive = this.Dd001Isactive,
                Dd001Datainicio = this.Dd001Datainicio,
                Dd001Datafim = this.Dd001Datafim
            };
        }
    }
}