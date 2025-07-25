using CSCore.Domain.CS_Models.CSICP_DD;
using EnviaNFeHercules.C82Application.Dto.DD.DD040;
using EnviaNFeHercules.C82Application.Dto.DD.DD060;
using EnviaNFeHercules.C82Application.Mapper.DD00X.DD060;
using GG104Materiais.C82Application.Mapper;
using GG104Materiais.C82Application.Mapper.GG008;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_DD.CSICP_DD060;

namespace EnviaNFeHercules.C82Application.Mapper.DD00X
{
    public static class DD060Mapper
    {
        public static DtoGetDD060 ToDtoGet(this RepoDtoCSICP_DD060 entity)
        {
            return new DtoGetDD060
            {
                TenantId = entity.TenantId,
                Dd060Id = entity.Dd060Id,
                Dd040Id = entity.Dd040Id,
                Dd060Produtoid = entity.Dd060Produtoid,
                Dd060Saldoid = entity.Dd060Saldoid,
                Dd060Codgalmox = entity.Dd060Codgalmox,
                Dd060CodigoProduto = entity.Dd060CodigoProduto,
                Dd060CodigoBarras = entity.Dd060CodigoBarras,
                Dd060Filial = entity.Dd060Filial,
                Dd060Ci = entity.Dd060Ci,
                Dd060Sequencia = entity.Dd060Sequencia,
                Dd060Lote = entity.Dd060Lote,
                Dd060SubLote = entity.Dd060SubLote,
                Dd060Localizacao = entity.Dd060Localizacao,
                Dd060CodgLinha = entity.Dd060CodgLinha,
                Dd060CodgColuna = entity.Dd060CodgColuna,
                Dd060Quantidade = entity.Dd060Quantidade,
                Dd060PrecoTabela = entity.Dd060PrecoTabela,
                Dd060Totalbruto = entity.Dd060Totalbruto,
                Dd060VlrDescSt1liq = entity.Dd060VlrDescSt1liq,
                Dd060Pacrescimo = entity.Dd060Pacrescimo,
                Dd060Vacrescimo = entity.Dd060Vacrescimo,
                Dd060PrcTabela2 = entity.Dd060PrcTabela2,
                Dd060Tpdesc = entity.Dd060Tpdesc,
                Dd060PercDesconto = entity.Dd060PercDesconto,
                Dd060ValorDesconto = entity.Dd060ValorDesconto,
                Dd060PrecoUnitario = entity.Dd060PrecoUnitario,
                Dd060Totliqproduto = entity.Dd060Totliqproduto,
                Dd060St2Liquido = entity.Dd060St2Liquido,
                Dd060TotalDescCascata = entity.Dd060TotalDescCascata,
                Dd060TotalDesconto = entity.Dd060TotalDesconto,
                Dd060Frete = entity.Dd060Frete,
                Dd060Seguro = entity.Dd060Seguro,
                Dd060Odespesas = entity.Dd060Odespesas,
                Dd060TotalLiquido = entity.Dd060TotalLiquido,
                Dd060Vdescsuframa = entity.Dd060Vdescsuframa,
                Dd060Vdesccupom = entity.Dd060Vdesccupom,
                Dd060Descproduto = entity.Dd060Descproduto,
                Dd060Descprodsecund = entity.Dd060Descprodsecund,
                Dd060UnId = entity.Dd060UnId,
                Dd060Unidade = entity.Dd060Unidade,
                Dd060CorSerieMerc = entity.Dd060CorSerieMerc,
                Dd060ResponsavelId = entity.Dd060ResponsavelId,
                Dd060RespVendedor = entity.Dd060RespVendedor,
                Dd060RespComprador = entity.Dd060RespComprador,
                Dd060BaseCalcIcms = entity.Dd060BaseCalcIcms,
                Dd060PercIcms = entity.Dd060PercIcms,
                Dd060ValorIcms = entity.Dd060ValorIcms,
                Dd060BaseCalcSubst = entity.Dd060BaseCalcSubst,
                Dd060PercSubstTrib = entity.Dd060PercSubstTrib,
                Dd060Vlrsubsttribaux = entity.Dd060Vlrsubsttribaux,
                Dd060Vlrsubsttribut = entity.Dd060Vlrsubsttribut,
                Dd060BaseCalcIpi = entity.Dd060BaseCalcIpi,
                Dd060PercIpi = entity.Dd060PercIpi,
                Dd060ValorIpi = entity.Dd060ValorIpi,
                Dd060Percreducaobaseicms = entity.Dd060Percreducaobaseicms,
                Dd060ValorAproxImp = entity.Dd060ValorAproxImp,
                Dd060LucroEstimado = entity.Dd060LucroEstimado,
                Dd060QtdAnterior = entity.Dd060QtdAnterior,
                Dd060Cicronologicasai = entity.Dd060Cicronologicasai,
                Dd060Cicronologicaent = entity.Dd060Cicronologicaent,
                Dd060Tamanho = entity.Dd060Tamanho,
                Dd060Largura = entity.Dd060Largura,
                Dd060Espessura = entity.Dd060Espessura,
                Dd060CodgTransacao = entity.Dd060CodgTransacao,
                Dd060Cfop = entity.Dd060Cfop,
                Dd060Cst = entity.Dd060Cst,
                Dd060DataMovimento = entity.Dd060DataMovimento,
                Dd060ItemTrocado = entity.Dd060ItemTrocado,
                Dd060Ambiente = entity.Dd060Ambiente,
                Dd060GeraMinuta = entity.Dd060GeraMinuta,
                Dd060GeraRequisicao = entity.Dd060GeraRequisicao,
                Dd060GeraRequisicaoexterna = entity.Dd060GeraRequisicaoexterna,
                Dd060Entregar = entity.Dd060Entregar,
                Dd060Transferir = entity.Dd060Transferir,
                Dd060Filialtransfsaida = entity.Dd060Filialtransfsaida,
                Dd060Almoxtransfsaida = entity.Dd060Almoxtransfsaida,
                Dd060PrcVendaOrigin = entity.Dd060PrcVendaOrigin,
                Dd060Precocusto = entity.Dd060Precocusto,
                Dd060Precocustoreal = entity.Dd060Precocustoreal,
                Dd060Precocustomedio = entity.Dd060Precocustomedio,
                Dd060Prccustomedioent = entity.Dd060Prccustomedioent,
                Dd060UnSecId = entity.Dd060UnSecId,
                Dd060UnSec = entity.Dd060UnSec,
                Dd060UnSecTipoconvId = entity.Dd060UnSecTipoconvId,
                Dd060UnSecFatorconv = entity.Dd060UnSecFatorconv,
                Dd060UnSecQtde = entity.Dd060UnSecQtde,
                Dd060UnSecValor = entity.Dd060UnSecValor,
                Dd060UnSecValorLiquido = entity.Dd060UnSecValorLiquido,
                Dd060TransacaoId = entity.Dd060TransacaoId,
                Dd060StatusestoqueId = entity.Dd060StatusestoqueId,
                Dd060RegraaplicadaId = entity.Dd060RegraaplicadaId,
                Dd060SaldovirtualId = entity.Dd060SaldovirtualId,
                Dd060Saldoanterior = entity.Dd060Saldoanterior,
                Dd060Saldoatual = entity.Dd060Saldoatual,
                Dd060Baixaestoque = entity.Dd060Baixaestoque,
                Dd060Controlasaldo = entity.Dd060Controlasaldo,
                Dd060Contsaldograde = entity.Dd060Contsaldograde,
                Dd060Contsaldolote = entity.Dd060Contsaldolote,
                Dd060Contsaldolocal = entity.Dd060Contsaldolocal,
                Dd060Permsaldoneg = entity.Dd060Permsaldoneg,
                Dd060Perccomissao = entity.Dd060Perccomissao,
                Dd060Valorcomissao = entity.Dd060Valorcomissao,
                Dd060SaldotransfId = entity.Dd060SaldotransfId,
                Dd060Indtot = entity.Dd060Indtot,
                Dd060Isfixarcalcimp = entity.Dd060Isfixarcalcimp,
                Dd060CompContaId = entity.Dd060CompContaId,
                Dd060Isservico = entity.Dd060Isservico,
                Dd060Mlucro = entity.Dd060Mlucro,
                Dd060Precoreposicao = entity.Dd060Precoreposicao,
                Dd060UsuariovendId = entity.Dd060UsuariovendId,
                Dd060Codbarrasalfa = entity.Dd060Codbarrasalfa,
                Dd060Xped = entity.Dd060Xped,
                Dd060Nitemped = entity.Dd060Nitemped,
                Dd060Infadprod = entity.Dd060Infadprod,
                Dd060Ambienteid = entity.Dd060Ambienteid,
                Dd060Dpreventrega = entity.Dd060Dpreventrega,
                Dd060Dprevmontagem = entity.Dd060Dprevmontagem,
                Dd060Modentregaid = entity.Dd060Modentregaid,
                Dd060Isentregue = entity.Dd060Isentregue,
                Dd060Fpagtoid = entity.Dd060Fpagtoid,
                Dd060Condicaopagtoid = entity.Dd060Condicaopagtoid,
                Dd060Cbenefic = entity.Dd060Cbenefic,
                Dd060Ierelevanteid = entity.Dd060Ierelevanteid,
                Dd060Cnpjfabricante = entity.Dd060Cnpjfabricante,
                Dd060Nomefabricante = entity.Dd060Nomefabricante,
                Dd060Motdesoneracaoid = entity.Dd060Motdesoneracaoid,
                Dd060Picmsdesonerado = entity.Dd060Picmsdesonerado,
                Dd060Vicmsdesonerado = entity.Dd060Vicmsdesonerado,
                Dd060VicmsdesonsubId = entity.Dd060VicmsdesonsubId,
                Dd08Ismontar = entity.Dd08Ismontar,
                Dd060Isinseridopdv = entity.Dd060Isinseridopdv,
                Dd060CashbackVunvendida = entity.Dd060CashbackVunvendida,
                Dd060CashbackPvendaliq = entity.Dd060CashbackPvendaliq,
                Dd060CashbackVpremio = entity.Dd060CashbackVpremio,
                Dd060Nroprctabela = entity.Dd060Nroprctabela,
                NavGG005 = entity.NavGG005?.ToDtoGetSemFilial(),
                NavGG006 = entity.NavGG006?.ToDtoGet(),
                NavGG007Unidade = entity.NavGG007Unidade?.ToDtoGetSimples(),
                NavGG007UnidadeSec = entity.NavGG007UnidadeSec?.ToDtoGetSimples(),
                NavGG008Produto = entity.NavGG008Produto?.ToDtoGetSimples(),
                NavGG008Kdx = entity.NavGG008Kdx?.ToDtoGetSimples(),
                NavGG021 = entity.NavGG021?.ToDtoGetSimples(),
                NavAA031Cstori = entity.NavAA031Cstori,
                NavAA032Csticm = entity.NavAA032Csticm,
                NavAA033Cstipi = entity.NavAA033Cstipi,
                NavAA034Cstpi = entity.NavAA034Cstpi,
                NavAA038Modst = entity.NavAA038Modst,
                NavBB027Modal = entity.NavBB027Modal,
                NavBB027Motivo = entity.NavBB027Motivo,
                NavDD061Cfgimp = entity.NavDD061Cfgimp,
                NavGG021Cest = entity.NavGG021Cest,
                NavSpedInCenqIpi = entity.NavSpedInCenqIpi,
                NavSpedInCfop = entity.NavSpedInCfop,
                NavListDD061 = entity.NavListDD061.Select(e => e.ToDtoGetDD061()),
                NavDD060Combs = entity.NavDD060Combs?.ToDtoGetDD060Comb(),
                NavListDD060CombsLa01 = entity.NavListDD060CombsLa01.Select(e => e.ToDtoGetDD060CombLa01()),
                DD080_RFTRANSACAO_ID = entity.DD080_RFTRANSACAO_ID

            };
        }
    }
}
























