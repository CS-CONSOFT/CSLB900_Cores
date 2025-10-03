using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Ifs.InterfaceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviaNFeHercules.C82Application.Dto.DD.DD060
{
    public class DtoCreateUpdateDD060 : IConverteParaEntidade<CSICP_DD060>
    {
        public string? Dd040Id { get; set; }

        public string? Dd060Produtoid { get; set; }

        public string? Dd060Saldoid { get; set; }

        public int? Dd060Codgalmox { get; set; }

        public int? Dd060CodigoProduto { get; set; }

        public decimal? Dd060CodigoBarras { get; set; }

        public int? Dd060Filial { get; set; }

        public decimal? Dd060Ci { get; set; }

        public int? Dd060Sequencia { get; set; }

        public string? Dd060Lote { get; set; }

        public string? Dd060SubLote { get; set; }

        public string? Dd060Localizacao { get; set; }

        public string? Dd060CodgLinha { get; set; }

        public string? Dd060CodgColuna { get; set; }

        public decimal? Dd060Quantidade { get; set; }

        public decimal? Dd060PrecoTabela { get; set; }

        public decimal? Dd060Totalbruto { get; set; }

        public decimal? Dd060VlrDescSt1liq { get; set; }

        public decimal? Dd060Pacrescimo { get; set; }

        public decimal? Dd060Vacrescimo { get; set; }

        public decimal? Dd060PrcTabela2 { get; set; }

        public int? Dd060Tpdesc { get; set; }

        public decimal? Dd060PercDesconto { get; set; }

        public decimal? Dd060ValorDesconto { get; set; }

        public decimal? Dd060PrecoUnitario { get; set; }

        public decimal? Dd060Totliqproduto { get; set; }

        public decimal? Dd060St2Liquido { get; set; }

        public decimal? Dd060TotalDescCascata { get; set; }

        public decimal? Dd060TotalDesconto { get; set; }

        public decimal? Dd060Frete { get; set; }

        public decimal? Dd060Seguro { get; set; }

        public decimal? Dd060Odespesas { get; set; }

        public decimal? Dd060TotalLiquido { get; set; }

        public decimal? Dd060Vdescsuframa { get; set; }

        public decimal? Dd060Vdesccupom { get; set; }

        public string? Dd060Descproduto { get; set; }

        public string? Dd060Descprodsecund { get; set; }

        public string? Dd060UnId { get; set; }

        public string? Dd060Unidade { get; set; }

        public string? Dd060CorSerieMerc { get; set; }

        public string? Dd060ResponsavelId { get; set; }

        public int? Dd060RespVendedor { get; set; }

        public int? Dd060RespComprador { get; set; }

        public decimal? Dd060BaseCalcIcms { get; set; }

        public decimal? Dd060PercIcms { get; set; }

        public decimal? Dd060ValorIcms { get; set; }

        public decimal? Dd060BaseCalcSubst { get; set; }

        public decimal? Dd060PercSubstTrib { get; set; }

        public decimal? Dd060Vlrsubsttribaux { get; set; }

        public decimal? Dd060Vlrsubsttribut { get; set; }

        public decimal? Dd060BaseCalcIpi { get; set; }

        public decimal? Dd060PercIpi { get; set; }

        public decimal? Dd060ValorIpi { get; set; }

        public decimal? Dd060Percreducaobaseicms { get; set; }

        public decimal? Dd060ValorAproxImp { get; set; }

        public decimal? Dd060LucroEstimado { get; set; }

        public decimal? Dd060QtdAnterior { get; set; }

        public decimal? Dd060Cicronologicasai { get; set; }

        public decimal? Dd060Cicronologicaent { get; set; }

        public decimal? Dd060Tamanho { get; set; }

        public decimal? Dd060Largura { get; set; }

        public decimal? Dd060Espessura { get; set; }

        public int? Dd060CodgTransacao { get; set; }

        public string? Dd060Cfop { get; set; }

        public string? Dd060Cst { get; set; }

        public DateTime? Dd060DataMovimento { get; set; }

        public bool? Dd060ItemTrocado { get; set; }

        public string? Dd060Ambiente { get; set; }

        public bool? Dd060GeraMinuta { get; set; }

        public bool? Dd060GeraRequisicao { get; set; }

        public bool? Dd060GeraRequisicaoexterna { get; set; }

        public bool? Dd060Entregar { get; set; }

        public bool? Dd060Transferir { get; set; }

        public int? Dd060Filialtransfsaida { get; set; }

        public int? Dd060Almoxtransfsaida { get; set; }

        public decimal? Dd060PrcVendaOrigin { get; set; }

        public decimal? Dd060Precocusto { get; set; }

        public decimal? Dd060Precocustoreal { get; set; }

        public decimal? Dd060Precocustomedio { get; set; }

        public decimal? Dd060Prccustomedioent { get; set; }

        public string? Dd060UnSecId { get; set; }

        public string? Dd060UnSec { get; set; }

        public int? Dd060UnSecTipoconvId { get; set; }

        public decimal? Dd060UnSecFatorconv { get; set; }

        public decimal? Dd060UnSecQtde { get; set; }

        public decimal? Dd060UnSecValor { get; set; }

        public decimal? Dd060UnSecValorLiquido { get; set; }

        public string? Dd060TransacaoId { get; set; }

        public int? Dd060StatusestoqueId { get; set; }

        public int? Dd060RegraaplicadaId { get; set; }

        public string? Dd060SaldovirtualId { get; set; }

        public decimal? Dd060Saldoanterior { get; set; }

        public decimal? Dd060Saldoatual { get; set; }

        public int? Dd060Baixaestoque { get; set; }

        public int? Dd060Controlasaldo { get; set; }

        public int? Dd060Contsaldograde { get; set; }

        public int? Dd060Contsaldolote { get; set; }

        public int? Dd060Contsaldolocal { get; set; }

        public int? Dd060Permsaldoneg { get; set; }

        public decimal? Dd060Perccomissao { get; set; }

        public decimal? Dd060Valorcomissao { get; set; }

        public string? Dd060SaldotransfId { get; set; }

        public int? Dd060Indtot { get; set; }

        public bool? Dd060Isfixarcalcimp { get; set; }

        public string? Dd060CompContaId { get; set; }

        public bool? Dd060Isservico { get; set; }

        public decimal? Dd060Mlucro { get; set; }

        public decimal? Dd060Precoreposicao { get; set; }

        public string? Dd060UsuariovendId { get; set; }

        public string? Dd060Codbarrasalfa { get; set; }

        public string? Dd060Xped { get; set; }

        public int? Dd060Nitemped { get; set; }

        public string? Dd060Infadprod { get; set; }

        public long? Dd060Ambienteid { get; set; }

        public DateTime? Dd060Dpreventrega { get; set; }

        public DateTime? Dd060Dprevmontagem { get; set; }

        public int? Dd060Modentregaid { get; set; }

        public bool? Dd060Isentregue { get; set; }

        public string? Dd060Fpagtoid { get; set; }

        public string? Dd060Condicaopagtoid { get; set; }

        public string? Dd060Cbenefic { get; set; }

        public int? Dd060Ierelevanteid { get; set; }

        public string? Dd060Cnpjfabricante { get; set; }

        public string? Dd060Nomefabricante { get; set; }

        public int? Dd060Motdesoneracaoid { get; set; }

        public decimal? Dd060Picmsdesonerado { get; set; }

        public decimal? Dd060Vicmsdesonerado { get; set; }

        public int? Dd060VicmsdesonsubId { get; set; }

        public bool? Dd08Ismontar { get; set; }

        public bool? Dd060Isinseridopdv { get; set; }

        public decimal? Dd060CashbackVunvendida { get; set; }

        public decimal? Dd060CashbackPvendaliq { get; set; }

        public decimal? Dd060CashbackVpremio { get; set; }

        public int? Dd060Nroprctabela { get; set; }
        //--------------------Reforma Tributária--------------------//

        public string? DD080_RFTRANSACAO_ID { get; set; }

        //----------------------------------------------------------//
        public CSICP_DD060 ToEntity(int tenant, string? id)
        {
            return new CSICP_DD060
            {
                TenantId = tenant,
                Dd060Id = id!,
                Dd040Id = this.Dd040Id,
                Dd060Produtoid = this.Dd060Produtoid,
                Dd060Saldoid = this.Dd060Saldoid,
                Dd060Codgalmox = this.Dd060Codgalmox,
                Dd060CodigoProduto = this.Dd060CodigoProduto,
                Dd060CodigoBarras = this.Dd060CodigoBarras,
                Dd060Filial = this.Dd060Filial,
                Dd060Ci = this.Dd060Ci,
                Dd060Sequencia = this.Dd060Sequencia,
                Dd060Lote = this.Dd060Lote,
                Dd060SubLote = this.Dd060SubLote,
                Dd060Localizacao = this.Dd060Localizacao,
                Dd060CodgLinha = this.Dd060CodgLinha,
                Dd060CodgColuna = this.Dd060CodgColuna,
                Dd060Quantidade = this.Dd060Quantidade,
                Dd060PrecoTabela = this.Dd060PrecoTabela,
                Dd060Totalbruto = this.Dd060Totalbruto,
                Dd060VlrDescSt1liq = this.Dd060VlrDescSt1liq,
                Dd060Pacrescimo = this.Dd060Pacrescimo,
                Dd060Vacrescimo = this.Dd060Vacrescimo,
                Dd060PrcTabela2 = this.Dd060PrcTabela2,
                Dd060Tpdesc = this.Dd060Tpdesc,
                Dd060PercDesconto = this.Dd060PercDesconto,
                Dd060ValorDesconto = this.Dd060ValorDesconto,
                Dd060PrecoUnitario = this.Dd060PrecoUnitario,
                Dd060Totliqproduto = this.Dd060Totliqproduto,
                Dd060St2Liquido = this.Dd060St2Liquido,
                Dd060TotalDescCascata = this.Dd060TotalDescCascata,
                Dd060TotalDesconto = this.Dd060TotalDesconto,
                Dd060Frete = this.Dd060Frete,
                Dd060Seguro = this.Dd060Seguro,
                Dd060Odespesas = this.Dd060Odespesas,
                Dd060TotalLiquido = this.Dd060TotalLiquido,
                Dd060Vdescsuframa = this.Dd060Vdescsuframa,
                Dd060Vdesccupom = this.Dd060Vdesccupom,
                Dd060Descproduto = this.Dd060Descproduto,
                Dd060Descprodsecund = this.Dd060Descprodsecund,
                Dd060UnId = this.Dd060UnId,
                Dd060Unidade = this.Dd060Unidade,
                Dd060CorSerieMerc = this.Dd060CorSerieMerc,
                Dd060ResponsavelId = this.Dd060ResponsavelId,
                Dd060RespVendedor = this.Dd060RespVendedor,
                Dd060RespComprador = this.Dd060RespComprador,
                Dd060BaseCalcIcms = this.Dd060BaseCalcIcms,
                Dd060PercIcms = this.Dd060PercIcms,
                Dd060ValorIcms = this.Dd060ValorIcms,
                Dd060BaseCalcSubst = this.Dd060BaseCalcSubst,
                Dd060PercSubstTrib = this.Dd060PercSubstTrib,
                Dd060Vlrsubsttribaux = this.Dd060Vlrsubsttribaux,
                Dd060Vlrsubsttribut = this.Dd060Vlrsubsttribut,
                Dd060BaseCalcIpi = this.Dd060BaseCalcIpi,
                Dd060PercIpi = this.Dd060PercIpi,
                Dd060ValorIpi = this.Dd060ValorIpi,
                Dd060Percreducaobaseicms = this.Dd060Percreducaobaseicms,
                Dd060ValorAproxImp = this.Dd060ValorAproxImp,
                Dd060LucroEstimado = this.Dd060LucroEstimado,
                Dd060QtdAnterior = this.Dd060QtdAnterior,
                Dd060Cicronologicasai = this.Dd060Cicronologicasai,
                Dd060Cicronologicaent = this.Dd060Cicronologicaent,
                Dd060Tamanho = this.Dd060Tamanho,
                Dd060Largura = this.Dd060Largura,
                Dd060Espessura = this.Dd060Espessura,
                Dd060CodgTransacao = this.Dd060CodgTransacao,
                Dd060Cfop = this.Dd060Cfop,
                Dd060Cst = this.Dd060Cst,
                Dd060DataMovimento = this.Dd060DataMovimento,
                Dd060ItemTrocado = this.Dd060ItemTrocado,
                Dd060Ambiente = this.Dd060Ambiente,
                Dd060GeraMinuta = this.Dd060GeraMinuta,
                Dd060GeraRequisicao = this.Dd060GeraRequisicao,
                Dd060GeraRequisicaoexterna = this.Dd060GeraRequisicaoexterna,
                Dd060Entregar = this.Dd060Entregar,
                Dd060Transferir = this.Dd060Transferir,
                Dd060Filialtransfsaida = this.Dd060Filialtransfsaida,
                Dd060Almoxtransfsaida = this.Dd060Almoxtransfsaida,
                Dd060PrcVendaOrigin = this.Dd060PrcVendaOrigin,
                Dd060Precocusto = this.Dd060Precocusto,
                Dd060Precocustoreal = this.Dd060Precocustoreal,
                Dd060Precocustomedio = this.Dd060Precocustomedio,
                Dd060Prccustomedioent = this.Dd060Prccustomedioent,
                Dd060UnSecId = this.Dd060UnSecId,
                Dd060UnSec = this.Dd060UnSec,
                Dd060UnSecTipoconvId = this.Dd060UnSecTipoconvId,
                Dd060UnSecFatorconv = this.Dd060UnSecFatorconv,
                Dd060UnSecQtde = this.Dd060UnSecQtde,
                Dd060UnSecValor = this.Dd060UnSecValor,
                Dd060UnSecValorLiquido = this.Dd060UnSecValorLiquido,
                Dd060TransacaoId = this.Dd060TransacaoId,
                Dd060StatusestoqueId = this.Dd060StatusestoqueId,
                Dd060RegraaplicadaId = this.Dd060RegraaplicadaId,
                Dd060SaldovirtualId = this.Dd060SaldovirtualId,
                Dd060Saldoanterior = this.Dd060Saldoanterior,
                Dd060Saldoatual = this.Dd060Saldoatual,
                Dd060Baixaestoque = this.Dd060Baixaestoque,
                Dd060Controlasaldo = this.Dd060Controlasaldo,
                Dd060Contsaldograde = this.Dd060Contsaldograde,
                Dd060Contsaldolote = this.Dd060Contsaldolote,
                Dd060Contsaldolocal = this.Dd060Contsaldolocal,
                Dd060Permsaldoneg = this.Dd060Permsaldoneg,
                Dd060Perccomissao = this.Dd060Perccomissao,
                Dd060Valorcomissao = this.Dd060Valorcomissao,
                Dd060SaldotransfId = this.Dd060SaldotransfId,
                Dd060Indtot = this.Dd060Indtot,
                Dd060Isfixarcalcimp = this.Dd060Isfixarcalcimp,
                Dd060CompContaId = this.Dd060CompContaId,
                Dd060Isservico = this.Dd060Isservico,
                Dd060Mlucro = this.Dd060Mlucro,
                Dd060Precoreposicao = this.Dd060Precoreposicao,
                Dd060UsuariovendId = this.Dd060UsuariovendId,
                Dd060Codbarrasalfa = this.Dd060Codbarrasalfa,
                Dd060Xped = this.Dd060Xped,
                Dd060Nitemped = this.Dd060Nitemped,
                Dd060Infadprod = this.Dd060Infadprod,
                Dd060Ambienteid = this.Dd060Ambienteid,
                Dd060Dpreventrega = this.Dd060Dpreventrega,
                Dd060Dprevmontagem = this.Dd060Dprevmontagem,
                Dd060Modentregaid = this.Dd060Modentregaid,
                Dd060Isentregue = this.Dd060Isentregue,
                Dd060Fpagtoid = this.Dd060Fpagtoid,
                Dd060Condicaopagtoid = this.Dd060Condicaopagtoid,
                Dd060Cbenefic = this.Dd060Cbenefic,
                Dd060Ierelevanteid = this.Dd060Ierelevanteid,
                Dd060Cnpjfabricante = this.Dd060Cnpjfabricante,
                Dd060Nomefabricante = this.Dd060Nomefabricante,
                Dd060Motdesoneracaoid = this.Dd060Motdesoneracaoid,
                Dd060Picmsdesonerado = this.Dd060Picmsdesonerado,
                Dd060Vicmsdesonerado = this.Dd060Vicmsdesonerado,
                Dd060VicmsdesonsubId = this.Dd060VicmsdesonsubId,
                Dd08Ismontar = this.Dd08Ismontar,
                Dd060Isinseridopdv = this.Dd060Isinseridopdv,
                Dd060CashbackVunvendida = this.Dd060CashbackVunvendida,
                Dd060CashbackPvendaliq = this.Dd060CashbackPvendaliq,
                Dd060CashbackVpremio = this.Dd060CashbackVpremio,
                Dd060Nroprctabela = this.Dd060Nroprctabela,
                DD060_RFTRANSACAO_ID = this.DD080_RFTRANSACAO_ID
            };
        }
    }
}
