using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG033;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG033Mapper
    {
        public static DtoGetGG033 ToDtoGet(this CSICP_GG033 entity)
        {
            return new DtoGetGG033
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Gg033Filialid = entity.Gg033Filialid,
                Gg032Id = entity.Gg032Id,
                Gg033Saldoid = entity.Gg033Saldoid,
                Gg033Produto = entity.Gg033Produto,
                Gg033Codigobarras = entity.Gg033Codigobarras,
                Gg033Datareferente = entity.Gg033Datareferente,
                Gg033Qtdinventario = entity.Gg033Qtdinventario,
                Gg033Saldoestoque = entity.Gg033Saldoestoque,
                Gg033Qtdajuste = entity.Gg033Qtdajuste,
                Gg033Entsai = entity.Gg033Entsai,
                Gg033Precocusto = entity.Gg033Precocusto,
                Gg033Precocustoreal = entity.Gg033Precocustoreal,
                Gg033Precocustomedio = entity.Gg033Precocustomedio,
                Gg033Precovenda = entity.Gg033Precovenda,
                Gg033Datafechanterior = entity.Gg033Datafechanterior,
                Gg033Qtdfechanterior = entity.Gg033Qtdfechanterior,
                Gg033Naoinventariar = entity.Gg033Naoinventariar,
                Gg033Alterado = entity.Gg033Alterado,
                Gg033NnGrupoId = entity.Gg033NnGrupoId,
                Gg033NnClasseId = entity.Gg033NnClasseId,
                Gg033NnMarcaId = entity.Gg033NnMarcaId,
                Gg033NnArtigoId = entity.Gg033NnArtigoId,
                Gg033NnLinhaId = entity.Gg033NnLinhaId,
                Gg033NnSubgrupoId = entity.Gg033NnSubgrupoId,
                Gg033QuemdigitouUserId = entity.Gg033QuemdigitouUserId,
                Gg033QuemcontouUserid = entity.Gg033QuemcontouUserid,
                Gg033Posicao = entity.Gg033Posicao,
                Gg033Codbarrasalfa = entity.Gg033Codbarrasalfa,
                NavBB001Simples = entity.NavBB001Estab?.ToDtoGetSimples(),
                NavGG033_Saldo = entity.NavGG033_Saldo?.ToDtoGetSimplesComProdutoESemKardex(),
            };
        }
    }
}
