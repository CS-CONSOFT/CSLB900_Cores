using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.Dashboard;

namespace CSCore.Domain.CS_Models.CSICP_FF;


public partial class CSICP_FF102
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Ff102Tiporegistro { get; set; }

    public string? Ff102Filialid { get; set; }

    public int? Ff102Filial { get; set; }

    public string? Ff102Pfx { get; set; }

    public decimal? Ff102NoTitulo { get; set; }

    public string? Ff102Sfx { get; set; }

    public decimal? Ff102NoTitulonobanco { get; set; }

    public string? Ff102Especieid { get; set; }

    public int? Ff102Tipoparcelaid { get; set; }

    public int? Ff102TipoParcela { get; set; }

    public int? Ff102ParcelaX { get; set; }

    public int? Ff102ParcelaY { get; set; }

    public string? Ff102Contaid { get; set; }

    public string? Ff102Contarealid { get; set; }

    public string? Ff102AvalistaId { get; set; }

    public string? Ff102Ccustoid { get; set; }

    public string? Ff102Usuarioproprieid { get; set; }

    public string? Ff102Agcobradorid { get; set; }

    public string? Ff102Responsavelid { get; set; }

    public string? Ff102Condicaoid { get; set; }

    public string? Ff102Administradoraid { get; set; }

    public string? Ff102Tipocobrancaid { get; set; }

    public string? Ff102Moedaid { get; set; }

    public int? Ff102CodgCliente { get; set; }

    public int? Ff102Codclientereal { get; set; }

    public string? Ff102CliFavorecido { get; set; }

    public int? Ff102CodgCcusto { get; set; }

    public int? Ff102CodgAcobrador { get; set; }

    public int? Ff102CodgResponsavel { get; set; }

    public int? Ff102CodgCondicao { get; set; }

    public int? Ff102Codadministrad { get; set; }

    public int? Ff102CodgTcobranca { get; set; }

    public int? Ff102CodgMoeda { get; set; }

    public DateTime Ff102DataEmissao { get; set; } = default(DateTime);

    public DateTime Ff102DataVencimento { get; set; } = default(DateTime);

    public DateTime? Ff102DataVencReal { get; set; } = default(DateTime);

    public decimal? Ff102ValorTitulo { get; set; }

    public decimal? Ff102VlAcrescimos { get; set; }

    public decimal? Ff102VlDecrescimos { get; set; }

    public decimal? Ff102ValorDesagio { get; set; }

    public decimal? Ff102TotalPagamentos { get; set; }

    public decimal? Ff102TotalMultaPaga { get; set; }

    public decimal? Ff102TotalJuros { get; set; }

    public decimal? Ff102TotalDescontos { get; set; }

    public decimal? Ff102TotalDevolucao { get; set; }

    public decimal? Ff102TotalDoacao { get; set; }

    public decimal? Ff102TotalTarifas { get; set; }

    public decimal? Ff102TotalImpostosmais { get; set; }

    public decimal? Ff102TotalImpostosmenos { get; set; }

    public decimal Ff102VlLiqTitulo { get; set; }

    public int Ff102Nodiasliberacao { get; set; }

    public int? Ff102TipoDesconto { get; set; }

    public decimal? Ff102Percdescfinan { get; set; }

    public int? Ff102Diasparadesconto { get; set; }

    public int? Ff102CnabCodDesconto { get; set; }

    public int? Ff102NoPagamentos { get; set; }

    public DateTime? Ff102DataUltPagto { get; set; }

    public string? Ff102Observacao { get; set; }

    public string? Ff102InstCobranca1 { get; set; }

    public string? Ff102InstCobranca2 { get; set; }

    public decimal? Ff102NoBordero { get; set; }

    public int? Ff102FluxoCaixa { get; set; }

    public string? Ff102Origem { get; set; }

    public string? Ff102Vendaid { get; set; }

    public string? Ff102Compraid { get; set; }

    public int? Ff102NPdv { get; set; }

    public decimal? Ff102NumeroNf { get; set; }

    public string? Ff102SerieNf { get; set; }

    public decimal? Ff102CiNfNfCupom { get; set; }

    public decimal? Ff102TotalNotas { get; set; }

    public string? Ff102Empenho { get; set; }

    public string? Ff102Processo { get; set; }

    public string? Ff102NContrato { get; set; }

    public string? Ff102Situacao { get; set; }

    public int Ff102Situacaoid { get; set; }

    public int? Ff102SequenciaLog { get; set; }

    public decimal? Ff102NossoNumero { get; set; }

    public string? Ff102DvNossoNumero { get; set; }

    public string? Ff102DvCodgBeneficiario { get; set; }

    public decimal? Ff1021ocampodigitavel { get; set; }

    public decimal? Ff1022ocampodigitavel { get; set; }

    public decimal? Ff1023ocampodigitavel { get; set; }

    public string? Ff102DvCampoLivre { get; set; }

    public string? Ff102DvCodigoBarras { get; set; }

    public int? Ff102FatorVencimento { get; set; }

    public decimal? Ff102Vlrnominaltitulo { get; set; }

    public string? Ff102CodigoBarras { get; set; }

    public string? Ff102Modalidcbarras { get; set; }

    public string? Ff102Linhadigital { get; set; }

    public string? Ff102Codcobrador { get; set; }

    public string? Ff102Lanctocontabil { get; set; }

    public decimal? Ff102cpNoDuplicata { get; set; }

    public decimal? Ff102cpValorMulta { get; set; }

    public decimal? Ff102cpValorJurosDia { get; set; }

    public string? Ff102cpAprovador { get; set; }

    public string? Ff102cpAprovadorid { get; set; }

    public DateTime? Ff102cpDataAprovacao { get; set; }

    public DateTime? Ff102cpHoraAprovacao { get; set; }

    public bool? Ff102cpRegistroMarcado { get; set; }

    public string? Ff102cpTituloOriginal { get; set; }

    public DateTime? Ff102Dataapresentacao { get; set; }

    public string? Ff102cpLiberado { get; set; }

    public string? Ff102cpConfirmado { get; set; }

    public decimal? Ff102TaxaCartao { get; set; }

    public decimal? Ff102ValorTaxaCartao { get; set; }

    public int? Ff102CnabCodJurosMora { get; set; }

    public decimal? Ff102PercJurosAtr { get; set; }

    public int? Ff102CnabCodMulta { get; set; }

    public decimal? Ff102PercMulta { get; set; }

    public int? Ff102Tpcobranca { get; set; }

    public int? Ff102cpPagtoautorizadoId { get; set; }

    public int? Ff102cpConfirmadoId { get; set; }

    public string? Ff102Cnsu { get; set; }

    public string? Ff102Cdatamovimento { get; set; }

    public int? Ff102Cpv { get; set; }

    public string? Ff102Cautorizacao { get; set; }

    public string? Ff102Cdoc { get; set; }

    public bool? Ff102Isconcvenda { get; set; }

    public bool? Ff102Isconcfinanc { get; set; }

    public string? Ff10FpagtoId { get; set; }

    public int? Ff102CtbIscontabilizadoid { get; set; }

    public string? Ff102CtbUsuarioid { get; set; }

    public DateTime? Ff102CtbDtregistro { get; set; }

    public int? Ff102CtbIsestornadoid { get; set; }

    public string? Ff102CtbEstusuarioid { get; set; }

    public DateTime? Ff102CtbEstdtreg { get; set; }

    public long? Ff102CtbIdlancto { get; set; }

    public string? Ff102CtbMsg { get; set; }

    public int? Ff102SitespecialId { get; set; }

    public DateTime? Ff102Dtimestamp { get; set; }

    public DateTime? Ff102DtvencSimulado { get; set; }

    public decimal? Ff102PercCorrmonetaria { get; set; }

    public decimal? Ff102PercHonorarios { get; set; }

    public decimal? Ff102VlCorrmonetaria { get; set; }

    public decimal? Ff102VlHonorarios { get; set; }

    public bool? Ff102CtlIscontabilizadoid { get; set; }

    public string? Ff102CtlUsuarioid { get; set; }

    public DateTime? Ff102CtlDtregistro { get; set; }

    public bool? Ff102CtlIsestornadoid { get; set; }

    public string? Ff102CtlEstusuarioid { get; set; }

    public DateTime? Ff102CtlEstdtreg { get; set; }

    public long? Ff102CtlIdlancto { get; set; }

    public string? Ff102CtlMsg { get; set; }

    public int? Ff102ApiId { get; set; }

    public string? Ff102NoTitulocliente { get; set; }

    public string? Ff102HashId { get; set; }

    public string? Ff102PixQrcode { get; set; }

    public string? Ff102Txid { get; set; }

    public int? Ff102CodgOcorrencia { get; set; }

    public string? Ff102Ocorrencia { get; set; }

    public decimal? Ff102Jurosrecebido { get; set; }

    public decimal? Ff102Multarecebida { get; set; }

    public decimal? Ff102Outrovlrrecebido { get; set; }

    public decimal? Ff102Descconcedido { get; set; }

    public decimal? Ff102Valorpago { get; set; }

    public DateTime? Ff102DataRecto { get; set; }

    public DateTime? Ff102DataCredito { get; set; }

    public DateTime? Ff102DataBxaut { get; set; }

    public DateTime? Ff102HoraBxaut { get; set; }

    public DateTime? Ff102DataProtesto { get; set; }

    public int? Ff102Diasprotesto { get; set; }

    public int? Ff102Prazorecto { get; set; }

    public DateTime? Ff102DataLimrecto { get; set; }

    public string? Ff102CodigoErroApi { get; set; }

    public string? Ff102VersaoErroApi { get; set; }

    public string? Ff102MsgErroApi { get; set; }

    public string? Ff102OcorErroApi { get; set; }

    public int? Ff102OcorrenciaApi { get; set; }

    public int? Ff102LiqApi { get; set; }

    public int? Ff102BaixaApi { get; set; }

    public DateTime? Ff102DataAtualizacao { get; set; }

    public DateTime? Ff102HoraAtualizacao { get; set; }

    public int? Ff102Flagbxtes { get; set; }

    public bool? Ff102Isaprovacao { get; set; }

    public int? Ff102AdtoId { get; set; }

    public decimal? Ff102Vdeduzidoadto { get; set; }

    public string? Ff102Hashcnab { get; set; }

    public string? Ff102Cpcodgrfederalid { get; set; }

    public int? Ff102Cptppagtoid { get; set; }

    public int? Ff102Cptpprodutobbid { get; set; }

    public string? Ff102PixcobTransactionid { get; set; }

    public string? Ff102PixcobQrcode { get; set; }

    public string? Ff102PixcobStatus { get; set; }

    public int? Ff102TrilhaApiid { get; set; }

}

public class RepoDtoCSICP_FF102 : CSICP_FF102
{
    public int? CSDiasAtraso { get; set; } = default;

    public decimal? CSValorCorrecaoMonetaria { get; set; } = default;

    public decimal? CSValorMulta { get; set; } = default;

    public decimal? CSValorHonorarios { get; set; } = default;

    public decimal? CSValorJuros { get; set; } = default;

    public decimal? CSValorAPagar { get; set; } = default;
    public decimal? CSPercentualJurosConfig { get; set; }
    public decimal? CSPercentualMultaConfig { get; set; }
    public decimal? CSPercentualCorrecaoMonetariaConfig { get; set; }
    public decimal? CSPercentualHonorarioConfig { get; set; }


    public CSICP_BB001? NavBB001 { get; set; }
    public CSICP_Bb005? NavBB005 { get; set; }
    public CSICP_Bb006? NavBB006 { get; set; }
    public CSICP_BB007? NavBB007 { get; set; }
    public CSICP_Bb008? NavBB008 { get; set; }
    public CSICP_Bb009? NavBB009 { get; set; }
    public CSICP_Bb019? NavBB019 { get; set; }
    public CSICP_BB012? NavBB012 { get; set; }
    public CSICP_BB012? NavBB012ContaID { get; set; }
    public CSICP_BB012? NavBB012ContaRealID { get; set; }
    public CSICP_BB012? NavBB012AvalistaID { get; set; }
    public CSICP_Bb01201Jur? NavBB01201Jur { get; set; }
    public CSICP_Bb026? NavBB026 { get; set; }
    public CSICP_FF000? NavFF000 { get; set; }
    public CSICP_FF003? NavFF003 { get; set; }
    public CSICP_FF102_C021? NavFF102C021 { get; set; }
    public CSICP_FF102Des? NavFF102Des { get; set; }
    public CSICP_FF102Ent? NavFF102Ent { get; set; }
    public CSICP_FF102Sit? NavFF102Sit { get; set; }
    public CSICP_FF102_C018? NavFF102C018 { get; set; }
    public CSICP_FF102_G073? NavFF102G073 { get; set; }
    public CSICP_FF102Cob? NavFF102Cob { get; set; }
    public CSICP_FF102Aut? NavFF102Aut { get; set; }
    public CSICP_FF102ApiBanco? NavFF102ApiBanco { get; set; }
    public CSICP_FF102Adt? NavFF102Adt { get; set; }
    public CSICP_FF112ApiOcorrencium? NavFF112ApiOcorrencium { get; set; }
    public CSICP_FF112ApiLiquidacao? NavFF112ApiLiquidacao { get; set; }
    public CSICP_FF112ApiBaixa? NavFF112ApiBaixa { get; set; }
    public CSICP_FF120TrackApi? NavFF120Trackapi { get; set; }
    public Csicp_Sy001? NavSy001Usuario { get; set; }
    public Csicp_Sy001? NavSy001CodCobrador { get; set; }
    public Csicp_Sy001? NavSy001Aprovador { get; set; }
    public Csicp_Sy001? NavSy001CTBUsuarioID { get; set; }
    public Csicp_Sy001? NavSy001CTBEstUsuarioID { get; set; }
    public Csicp_Sy001? NavSy001CTLUsuarioID { get; set; }
    public Csicp_Sy001? NavSy001CTLEstUsuarioID { get; set; }
    public CSICP_Statica? NavStaticaFluxoCaixa { get; set; }
    public CSICP_Statica? NavStaticaConfirmadoID { get; set; }

}