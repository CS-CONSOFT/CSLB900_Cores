using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD016
{
    public record DtoGetListDD016 : IConverteParaDTO<CSICP_DD016, DtoGetListDD016>
    {
        public int TenantId { get; init; }
        public string Dd016Id { get; init; } = null!;
        public string? Dd016FilialId { get; init; }
        public string? Dd016FormapagtoId { get; init; }
        public string? Dd016CondicaoId { get; init; }
        public string? Dd016GrupoId { get; init; }
        public string? Dd016ClasseId { get; init; }
        public string? Dd016MarcaId { get; init; }
        public string? Dd016ArtigoId { get; init; }
        public decimal? Dd016PercentPvenda { get; init; }
        public decimal? Dd016PercentPedido { get; init; }
        public int? Dd016Aplicacao { get; init; }
        public bool? Dd016Isactive { get; init; }
        public string? Dd016Protocolnumber { get; init; }
        public string? Dd001Rcomercializid { get; init; }

        public virtual CSICP_DD001? Dd001Rcomercializ { get; init; }
        public virtual CSICP_DD016Apl? Dd016AplicacaoNavigation { get; init; }

        public static DtoGetListDD016 FromEntity(CSICP_DD016 entity)
        {
            return new DtoGetListDD016
            {
                TenantId = entity.TenantId,
                Dd016Id = entity.Dd016Id,
                Dd016FilialId = entity.Dd016FilialId,
                Dd016FormapagtoId = entity.Dd016FormapagtoId,
                Dd016CondicaoId = entity.Dd016CondicaoId,
                Dd016GrupoId = entity.Dd016GrupoId,
                Dd016ClasseId = entity.Dd016ClasseId,
                Dd016MarcaId = entity.Dd016MarcaId,
                Dd016ArtigoId = entity.Dd016ArtigoId,
                Dd016PercentPvenda = entity.Dd016PercentPvenda,
                Dd016PercentPedido = entity.Dd016PercentPedido,
                Dd016Aplicacao = entity.Dd016Aplicacao,
                Dd016Isactive = entity.Dd016Isactive,
                Dd016Protocolnumber = entity.Dd016Protocolnumber,
                Dd001Rcomercializid = entity.Dd001Rcomercializid,
                Dd001Rcomercializ = entity.Dd001Rcomercializ,
                Dd016AplicacaoNavigation = entity.Dd016AplicacaoNavigation
            };
        }
    }
}