using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Mapper.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101.C82Application.Dto.BB00X.BB00X.BB008;
using CSCore.Application.Dto.Dtos.DD.DD001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG006;
using CSCore.Application.Dto.Mapper.DD;
using CSCore.Application.Dto.Mapper.GG00X;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces;
using CSLB900.MSTools.InterfaceBase;
using FF105Financeiro.C82Application.Dto.GG00X.GG003;
using FF105Financeiro.C82Application.Dto.GG00X.GG004;
using FF105Financeiro.C82Application.Dto.GG00X.GG005;
using FF105Financeiro.C82Application.Dto.GG00X.GG006;

namespace CSCore.Application.Dto.Dtos.DD.DD016
{
    public record DtoGetDD016 : IConverteParaDTO<CSICP_DD016, DtoGetDD016>
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

        public Dto_GetBB001_Exibicao? NavBB001FilialID_DD016 { get; init; }
        public Dto_GetBB008_Exibicao? NavBB008CondicaoID_DD016 { get; init; }
        public DtoGetGG003_Exibicao_2? NavGG003GrupoID_DD016 { get; init; }
        public DtoGetGG004Simples? NavGG004ClasseID_DD016 { get; init; }
        public DtoGetGG005Simples? NavGG005ArtigoID_DD016 { get; init; }
        public DtoGetGG006Simples? NavGG006MarcaID_DD016 { get; init; }
        public CSICP_DD016Apl? NavDD016Aplicacao_DD016 { get; init; }
        public DtoGetDD001SemList? NavDD001RComercializ_DD016 { get; init; }

        public static DtoGetDD016 FromEntity(CSICP_DD016 entity)
        {
            return new DtoGetDD016
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
                NavBB001FilialID_DD016 = entity.NavBB001FilialID_DD016?.ToDtoGetExibicao(),
                NavBB008CondicaoID_DD016 = entity.NavBB008CondicaoID_DD016?.ToDtoGetSimples(),
                NavGG003GrupoID_DD016 = entity.NavGG003GrupoID_DD016?.ToDtoGetSimples(),
                NavGG004ClasseID_DD016 = entity.NavGG004ClasseID_DD016?.ToDtoGetSemFilial(),
                NavGG005ArtigoID_DD016 = entity.NavGG005ArtigoID_DD016?.ToDtoGetSemFilial(),
                NavGG006MarcaID_DD016 = entity.NavGG006MarcaID_DD016?.ToDtoGetSimples(),
                NavDD016Aplicacao_DD016 = entity.NavDD016Aplicacao_DD016,
                NavDD001RComercializ_DD016 = entity.NavDD001RComercializ_DD016?.ToDtoGetDD001()
            };
        }
    }
}