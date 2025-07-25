using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD080
{
    public int TenantId { get; set; }

    public string Dd080Id { get; set; } = null!;

    public string? Dd080Atendimentoid { get; set; }

    public string? Dd080Produtoid { get; set; }

    public string? Dd080Saldoid { get; set; }

    public int? Dd080Codgalmox { get; set; }

    public int? Dd080CodigoProduto { get; set; }

    public decimal? Dd080CodigoBarras { get; set; }

    public int? Dd080Filial { get; set; }

    public decimal? Dd080Ci { get; set; }

    public int? Dd080Sequencia { get; set; }

    public string? Dd080Lote { get; set; }

    public string? Dd080SubLote { get; set; }

    public string? Dd080Localizacao { get; set; }

    public string? Dd080CodgLinha { get; set; }

    public string? Dd080CodgColuna { get; set; }

    public decimal? Dd080Quantidade { get; set; }

    public decimal? Dd080PrecoTabela { get; set; }

    public decimal? Dd080Totalbruto { get; set; }

    public decimal? Dd080VlrDescSt1liq { get; set; }

    public decimal? Dd080Pacrescimo { get; set; }

    public decimal? Dd080Vacrescimo { get; set; }

    public decimal? Dd080PrcTabela2 { get; set; }

    public int? Dd080Tpdesc { get; set; }

    public decimal? Dd080PercDescproduto { get; set; }

    public decimal? Dd080ValorDescproduto { get; set; }

    public decimal? Dd080PrecoUnitario { get; set; }

    public decimal? Dd080Totliqproduto { get; set; }

    public decimal? Dd080St2Liquido { get; set; }

    public decimal? Dd080TotalDescCascata { get; set; }

    public decimal? Dd080TotalDesconto { get; set; }

    public decimal? Dd080Frete { get; set; }

    public decimal? Dd080Seguro { get; set; }

    public decimal? Dd080Odespesas { get; set; }

    public decimal? Dd080TotalLiquido { get; set; }

    public decimal? Dd080Vdescsuframa { get; set; }

    public decimal? Dd080Vdesccupom { get; set; }

    public string? Dd080Descproduto { get; set; }

    public string? Dd060Descprodsecund { get; set; }

    public string? Dd080UnId { get; set; }

    public string? Dd080Unidade { get; set; }

    public string? Dd080CorSerieMerc { get; set; }

    public string? Dd080ResponsavelId { get; set; }

    public int? Dd080RespVendedor { get; set; }

    public int? Dd060RespComprador { get; set; }

    public decimal? Dd080BaseCalcIcms { get; set; }

    public decimal? Dd080PercIcms { get; set; }

    public decimal? Dd080ValorIcms { get; set; }

    public decimal? Dd080BaseCalcSubst { get; set; }

    public decimal? Dd080LucroEstimado { get; set; }

    public decimal? Dd080PercSubstTrib { get; set; }

    public decimal? Dd080Vlrsubsttribaux { get; set; }

    public decimal? Dd080Vlrsubsttribut { get; set; }

    public decimal? Dd080BaseCalcIpi { get; set; }

    public decimal? Dd080PercIpi { get; set; }

    public decimal? Dd060ValorIpi { get; set; }

    public decimal? Dd080ValorAproxImp { get; set; }

    public decimal? Dd080Percreducaobaseicms { get; set; }

    public decimal? Dd080QtdAnterior { get; set; }

    public decimal? Dd080Cicronologicasai { get; set; }

    public decimal? Dd080Cicronologicaent { get; set; }

    public decimal? Dd080Tamanho { get; set; }

    public decimal? Dd080Largura { get; set; }

    public decimal? Dd080Espessura { get; set; }

    public int? Dd080CodgTransacao { get; set; }

    public string? Dd080Cfop { get; set; }

    public string? Dd080Cst { get; set; }

    public DateTime? Dd080DataMovimento { get; set; }

    public bool? Dd080ItemTrocado { get; set; }

    public string? Dd080Ambiente { get; set; }

    public bool? Dd080GeraMinuta { get; set; }

    public bool? Dd080GeraRequisicao { get; set; }

    public bool? Dd080GeraRequisicaoexterna { get; set; }

    public bool? Dd080Entregar { get; set; }

    public bool? Dd080Transferir { get; set; }

    public bool? Dd080SolicitaNsNegativa { get; set; }

    public int? Dd080Filialtransfsaida { get; set; }

    public int? Dd080Almoxtransfsaida { get; set; }

    public decimal? Dd080PrcVendaOrigin { get; set; }

    public decimal? Dd080Precocusto { get; set; }

    public decimal? Dd080Precocustoreal { get; set; }

    public decimal? Dd080Precocustomedio { get; set; }

    public decimal? Dd080Prccustomedioent { get; set; }

    public string? Dd080UnSecId { get; set; }

    public string? Dd080UnSec { get; set; }

    public int? Dd080UnSecTipoconvId { get; set; }

    public decimal? Dd080UnSecFatorconv { get; set; }

    public decimal? Dd080UnSecQtde { get; set; }

    public decimal? Dd080UnSecValor { get; set; }

    public decimal? Dd080UnSecValorLiquido { get; set; }

    public string? Dd080TransacaoId { get; set; }

    public int? Dd080Statusestoque { get; set; }

    public int? Dd080Regraaplicada { get; set; }

    public string? Dd080SaldovirtualId { get; set; }

    public bool? Dd080Isfixarcalcimp { get; set; }

    public string? Dd080CompContaId { get; set; }

    public bool? Dd080Isservico { get; set; }

    public string? Dd080UsuariovendId { get; set; }

    public string? Dd080Codbarrasalfa { get; set; }

    public string? Dd080Xped { get; set; }

    public int? Dd080Nitemped { get; set; }

    public string? Dd080Infadprod { get; set; }

    public long? Dd080Ambienteid { get; set; }

    public DateTime? Dd080Dpreventrega { get; set; }

    public int? Dd080Modentregaid { get; set; }

    public string? Dd080Fpagtoid { get; set; }

    public string? Dd080Condicaopagtoid { get; set; }

    public bool? Dd080Isselecionado { get; set; }

    public string? Dd080Cbenefic { get; set; }

    public int? Dd080Ierelevanteid { get; set; }

    public string? Dd080Cnpjfabricante { get; set; }

    public string? Dd080Nomefabricante { get; set; }

    public int? Dd080Motdesoneracaoid { get; set; }

    public decimal? Dd080Picmsdesonerado { get; set; }

    public decimal? Dd080Vicmsdesonerado { get; set; }

    public int? Dd080VicmsdesonsubId { get; set; }

    public bool? Dd080Ismontar { get; set; }

    public bool? Dd080Isinseridopdv { get; set; }

    public decimal? Dd080Precoreposicao { get; set; }

    public int? Dd080Nroprctabela { get; set; }

    //--------------------Reforma Tributária--------------------//

    [Column("DD080_RFTRANSACAO_ID", TypeName = "nvarchar(72)")]
    public string? DD080_RFTRANSACAO_ID { get; set; }

    //-------------------------------------------------------//

    public virtual CSICP_DD070? Dd080Atendimento { get; set; }

    public virtual CSICP_DD110Mod? Dd080Modentrega { get; set; }

    public virtual CSICP_DD080Regra? Dd080RegraaplicadaNavigation { get; set; }

    public virtual CSICP_DD080Estq? Dd080StatusestoqueNavigation { get; set; }

    public virtual CSICP_DD081Cfgimp? OsusrTeiCsicpDd081Cfgimp { get; set; }

    public virtual CSICP_DD082? OsusrTeiCsicpDd082 { get; set; }
}
