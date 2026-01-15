using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.DD.DD016
{
    public record DtoCreateDD016 : IConverteParaEntidade<CSICP_DD016>
    {
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
        public string? Dd001Rcomercializid { get; init; }

        public CSICP_DD016 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD016
            {
                TenantId = tenant,
                Dd016Id = id ?? string.Empty,
                Dd016FilialId = this.Dd016FilialId,
                Dd016FormapagtoId = this.Dd016FormapagtoId,
                Dd016CondicaoId = this.Dd016CondicaoId,
                Dd016GrupoId = this.Dd016GrupoId,
                Dd016ClasseId = this.Dd016ClasseId,
                Dd016MarcaId = this.Dd016MarcaId,
                Dd016ArtigoId = this.Dd016ArtigoId,
                Dd016PercentPvenda = this.Dd016PercentPvenda,
                Dd016PercentPedido = this.Dd016PercentPedido,
                Dd016Aplicacao = this.Dd016Aplicacao,
                Dd016Isactive = this.Dd016Isactive,
                Dd001Rcomercializid = this.Dd001Rcomercializid
            };
        }
    }
}