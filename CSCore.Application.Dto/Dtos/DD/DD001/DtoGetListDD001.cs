using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB001;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD001
{
    public record DtoGetListDD001 : IConverteParaDTO<CSICP_DD001, DtoGetListDD001>
    {
        public int TenantId { get; init; }
        public string Dd001Id { get; init; } = null!;
        public string? Dd001Empresaid { get; init; }
        public int? Dd001Filial { get; init; }
        public string? Dd001Descricao { get; init; }
        public bool? Dd001Isactive { get; init; }
        public DateTime? Dd001Datainicio { get; init; }
        public DateTime? Dd001Datafim { get; init; }
        public string? Dd001Protocolnumber { get; init; }
        public Dto_GetBB001Simples? NavBB001FilialID_DD001 { get; init; }



        public static DtoGetListDD001 FromEntity(CSICP_DD001 entity)
        {
            return new DtoGetListDD001
            {
                TenantId = entity.TenantId,
                Dd001Id = entity.Dd001Id,
                Dd001Empresaid = entity.Dd001Empresaid,
                Dd001Filial = entity.Dd001Filial,
                Dd001Descricao = entity.Dd001Descricao,
                Dd001Isactive = entity.Dd001Isactive,
                Dd001Datainicio = entity.Dd001Datainicio,
                Dd001Datafim = entity.Dd001Datafim,
                Dd001Protocolnumber = entity.Dd001Protocolnumber,
                NavBB001FilialID_DD001 = entity.NavBB001FilialID_DD001?.ToDtoGetSimples()
            };
        }
    }
}