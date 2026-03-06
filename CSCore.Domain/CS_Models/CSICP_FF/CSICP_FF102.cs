using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.Dashboard;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

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

    public DateTime Ff102DataEmissao { get; set; } = new DateTime(1999, 01,01);

    public DateTime Ff102DataVencimento { get; set; } = new DateTime(1999, 01, 01);

    public DateTime? Ff102DataVencReal { get; set; } = new DateTime(1999, 01,01);

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

    public int? Ff102Situacaoid { get; set; }

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

    [NotMapped]
    public int? CSDiasAtraso { get; set; } = default;
    [NotMapped]
    public decimal? CSValorCorrecaoMonetaria { get; set; } = default;
    [NotMapped]
    public decimal? CSValorMulta { get; set; } = default;
    [NotMapped]
    public decimal? CSValorHonorarios { get; set; } = default;
    [NotMapped]
    public decimal? CSValorJuros { get; set; } = default;
    [NotMapped]
    public decimal? CSValorAPagar { get; set; } = default;
    [NotMapped]
    public decimal? CSPercentualJurosConfig { get; set; }
    [NotMapped]
    public decimal? CSPercentualMultaConfig { get; set; }
    [NotMapped]
    public decimal? CSPercentualCorrecaoMonetariaConfig { get; set; }
    [NotMapped]
    public decimal? CSPercentualHonorarioConfig { get; set; }

    public CSICP_BB001? NavBB001 { get; set; }
    public CSICP_Bb005? NavBB005 { get; set; }
    public CSICP_Bb003? NavBB003 { get; set; }
    public CSICP_Bb006? NavBB006 { get; set; }
    public CSICP_BB007? NavBB007 { get; set; }
    public CSICP_Bb008? NavBB008 { get; set; }
    public CSICP_Bb009? NavBB009 { get; set; }
    public CSICP_Bb019? NavBB019 { get; set; }
    public CSICP_BB012? NavBB012 { get; set; }
    public CSICP_BB012? NavBB012ContaRealID { get; set; }
    public CSICP_BB012? NavBB012AvalistaID { get; set; }
    public CSICP_Bb01201Jur? NavBB01201Jur { get; set; }
    public CSICP_Bb026? NavBB026 { get; set; }
    [NotMapped]
    public CSICP_FF000? NavFF000 { get; set; }
    public CSICP_FF003? NavFF003 { get; set; }
    public CSICP_FF104? NavFF104 { get; set; }

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



    public static CSICP_FF102 CreateInstance(
     int tenantId,
     string id,
     decimal ff102VlLiqTitulo,
     int ff102Nodiasliberacao,
         DateTime? ff102DataEmissao,
     DateTime ff102DataVencimento,
         int ff102Situacaoid,
     int? ff102Tiporegistro = null,
     string? ff102Filialid = null,
     string? ff102Pfx = null,
     decimal? ff102NoTitulo = null,
     string? ff102Sfx = null,
     decimal? ff102NoTitulonobanco = null,
     string? ff102Especieid = null,
     int? ff102Tipoparcelaid = null,
     int? ff102TipoParcela = null,
     int? ff102ParcelaX = null,
     int? ff102ParcelaY = null,
     string? ff102Contaid = null,
     string? ff102Contarealid = null,
     string? ff102AvalistaId = null,
     string? ff102Ccustoid = null,
     string? ff102Usuarioproprieid = null,
     string? ff102Agcobradorid = null,
     string? ff102Responsavelid = null,
     string? ff102Condicaoid = null,
     string? ff102Administradoraid = null,
     string? ff102Tipocobrancaid = null,
     string? ff102Moedaid = null,
     int? ff102CodgCliente = null,
     int? ff102Codclientereal = null,
     string? ff102CliFavorecido = null,
     int? ff102CodgCcusto = null,
     int? ff102CodgAcobrador = null,
     int? ff102CodgResponsavel = null,
     int? ff102CodgCondicao = null,
     int? ff102Codadministrad = null,
     int? ff102CodgTcobranca = null,
     int? ff102CodgMoeda = null,

     DateTime? ff102DataVencReal = null,
     decimal? ff102ValorTitulo = null,
     decimal? ff102VlAcrescimos = null,
     decimal? ff102VlDecrescimos = null,
     decimal? ff102ValorDesagio = null,
     decimal? ff102TotalPagamentos = null,
     decimal? ff102TotalMultaPaga = null,
     decimal? ff102TotalJuros = null,
     decimal? ff102TotalDescontos = null,
     decimal? ff102TotalDevolucao = null,
     decimal? ff102TotalDoacao = null,
     decimal? ff102TotalTarifas = null,
     decimal? ff102TotalImpostosmais = null,
     decimal? ff102TotalImpostosmenos = null,
     int? ff102TipoDesconto = null,
     decimal? ff102Percdescfinan = null,
     int? ff102Diasparadesconto = null,
     int? ff102CnabCodDesconto = null,
     int? ff102NoPagamentos = null,
     DateTime? ff102DataUltPagto = null,
     string? ff102Observacao = null,
     string? ff102InstCobranca1 = null,
     string? ff102InstCobranca2 = null,
     decimal? ff102NoBordero = null,
     int? ff102FluxoCaixa = null,
     string? ff102Origem = null,
     string? ff102Vendaid = null,
     string? ff102Compraid = null,
     int? ff102NPdv = null,
     decimal? ff102NumeroNf = null,
     string? ff102SerieNf = null,
     decimal? ff102CiNfNfCupom = null,
     decimal? ff102TotalNotas = null,
     string? ff102Empenho = null,
     string? ff102Processo = null,
     string? ff102NContrato = null,
     string? ff102Situacao = null,

     int? ff102SequenciaLog = null,
     decimal? ff102NossoNumero = null,
     string? ff102DvNossoNumero = null,
     string? ff102DvCodgBeneficiario = null,
     decimal? ff1021ocampodigitavel = null,
     decimal? ff1022ocampodigitavel = null,
     decimal? ff1023ocampodigitavel = null,
     string? ff102DvCampoLivre = null,
     string? ff102DvCodigoBarras = null,
     int? ff102FatorVencimento = null,
     decimal? ff102Vlrnominaltitulo = null,
     string? ff102CodigoBarras = null,
     string? ff102Modalidcbarras = null,
     string? ff102Linhadigital = null,
     string? ff102Codcobrador = null,
     string? ff102Lanctocontabil = null,
     decimal? ff102cpNoDuplicata = null,
     decimal? ff102cpValorMulta = null,
     decimal? ff102cpValorJurosDia = null,
     string? ff102cpAprovador = null,
     string? ff102cpAprovadorid = null,
     DateTime? ff102cpDataAprovacao = null,
     DateTime? ff102cpHoraAprovacao = null,
     bool? ff102cpRegistroMarcado = null,
     string? ff102cpTituloOriginal = null,
     DateTime? ff102Dataapresentacao = null,
     string? ff102cpLiberado = null,
     string? ff102cpConfirmado = null,
     decimal? ff102TaxaCartao = null,
     decimal? ff102ValorTaxaCartao = null,
     int? ff102CnabCodJurosMora = null,
     decimal? ff102PercJurosAtr = null,
     int? ff102CnabCodMulta = null,
     decimal? ff102PercMulta = null,
     int? ff102Tpcobranca = null,
     int? ff102cpPagtoautorizadoId = null,
     int? ff102cpConfirmadoId = null,
     string? ff102Cnsu = null,
     string? ff102Cdatamovimento = null,
     int? ff102Cpv = null,
     string? ff102Cautorizacao = null,
     string? ff102Cdoc = null,
     bool? ff102Isconcvenda = null,
     bool? ff102Isconcfinanc = null,
     string? ff10FpagtoId = null,
     int? ff102CtbIscontabilizadoid = null,
     string? ff102CtbUsuarioid = null,
     DateTime? ff102CtbDtregistro = null,
     int? ff102CtbIsestornadoid = null,
     string? ff102CtbEstusuarioid = null,
     DateTime? ff102CtbEstdtreg = null,
     long? ff102CtbIdlancto = null,
     string? ff102CtbMsg = null,
     int? ff102SitespecialId = null,
     DateTime? ff102Dtimestamp = null,
     DateTime? ff102DtvencSimulado = null,
     decimal? ff102PercCorrmonetaria = null,
     decimal? ff102PercHonorarios = null,
     decimal? ff102VlCorrmonetaria = null,
     decimal? ff102VlHonorarios = null,
     bool? ff102CtlIscontabilizadoid = null,
     string? ff102CtlUsuarioid = null,
     DateTime? ff102CtlDtregistro = null,
     bool? ff102CtlIsestornadoid = null,
     string? ff102CtlEstusuarioid = null,
     DateTime? ff102CtlEstdtreg = null,
     long? ff102CtlIdlancto = null,
     string? ff102CtlMsg = null,
     int? ff102ApiId = null,
     string? ff102NoTitulocliente = null,
     string? ff102HashId = null,
     string? ff102PixQrcode = null,
     string? ff102Txid = null,
     int? ff102CodgOcorrencia = null,
     string? ff102Ocorrencia = null,
     decimal? ff102Jurosrecebido = null,
     decimal? ff102Multarecebida = null,
     decimal? ff102Outrovlrrecebido = null,
     decimal? ff102Descconcedido = null,
     decimal? ff102Valorpago = null,
     DateTime? ff102DataRecto = null,
     DateTime? ff102DataCredito = null,
     DateTime? ff102DataBxaut = null,
     DateTime? ff102HoraBxaut = null,
     DateTime? ff102DataProtesto = null,
     int? ff102Diasprotesto = null,
     int? ff102Prazorecto = null,
     DateTime? ff102DataLimrecto = null,
     string? ff102CodigoErroApi = null,
     string? ff102VersaoErroApi = null,
     string? ff102MsgErroApi = null,
     string? ff102OcorErroApi = null,
     int? ff102OcorrenciaApi = null,
     int? ff102LiqApi = null,
     int? ff102BaixaApi = null,
     DateTime? ff102DataAtualizacao = null,
     DateTime? ff102HoraAtualizacao = null,
     int? ff102Flagbxtes = null,
     bool? ff102Isaprovacao = null,
     int? ff102AdtoId = null,
     decimal? ff102Vdeduzidoadto = null,
     string? ff102Hashcnab = null,
     string? ff102Cpcodgrfederalid = null,
     int? ff102Cptppagtoid = null,
     int? ff102Cptpprodutobbid = null,
     string? ff102PixcobTransactionid = null,
     string? ff102PixcobQrcode = null,
     string? ff102PixcobStatus = null,
     int? ff102TrilhaApiid = null)
    {
        return new CSICP_FF102
        {
            TenantId = tenantId,
            Id = id,
            Ff102Tiporegistro = ff102Tiporegistro,
            Ff102Filialid = ff102Filialid,
            Ff102Filial = 0,
            Ff102Pfx = ff102Pfx,
            Ff102NoTitulo = ff102NoTitulo,
            Ff102Sfx = ff102Sfx,
            Ff102NoTitulonobanco = ff102NoTitulonobanco,
            Ff102Especieid = ff102Especieid,
            Ff102Tipoparcelaid = ff102Tipoparcelaid,
            Ff102TipoParcela = ff102TipoParcela,
            Ff102ParcelaX = ff102ParcelaX,
            Ff102ParcelaY = ff102ParcelaY,
            Ff102Contaid = ff102Contaid,
            Ff102Contarealid = ff102Contarealid,
            Ff102AvalistaId = ff102AvalistaId,
            Ff102Ccustoid = ff102Ccustoid,
            Ff102Usuarioproprieid = ff102Usuarioproprieid,
            Ff102Agcobradorid = ff102Agcobradorid,
            Ff102Responsavelid = ff102Responsavelid,
            Ff102Condicaoid = ff102Condicaoid,
            Ff102Administradoraid = ff102Administradoraid,
            Ff102Tipocobrancaid = ff102Tipocobrancaid,
            Ff102Moedaid = ff102Moedaid,
            Ff102CodgCliente = ff102CodgCliente,
            Ff102Codclientereal = ff102Codclientereal,
            Ff102CliFavorecido = ff102CliFavorecido,
            Ff102CodgCcusto = ff102CodgCcusto,
            Ff102CodgAcobrador = ff102CodgAcobrador,
            Ff102CodgResponsavel = ff102CodgResponsavel,
            Ff102CodgCondicao = ff102CodgCondicao,
            Ff102Codadministrad = ff102Codadministrad,
            Ff102CodgTcobranca = ff102CodgTcobranca,
            Ff102CodgMoeda = ff102CodgMoeda,
            Ff102DataEmissao = ff102DataEmissao ?? new DateTime(1999, 01, 01),
            Ff102DataVencimento = ff102DataVencimento,
            Ff102DataVencReal = ff102DataVencReal,
            Ff102ValorTitulo = ff102ValorTitulo,
            Ff102VlAcrescimos = ff102VlAcrescimos,
            Ff102VlDecrescimos = ff102VlDecrescimos,
            Ff102ValorDesagio = ff102ValorDesagio,
            Ff102TotalPagamentos = ff102TotalPagamentos,
            Ff102TotalMultaPaga = ff102TotalMultaPaga,
            Ff102TotalJuros = ff102TotalJuros,
            Ff102TotalDescontos = ff102TotalDescontos,
            Ff102TotalDevolucao = ff102TotalDevolucao,
            Ff102TotalDoacao = ff102TotalDoacao,
            Ff102TotalTarifas = ff102TotalTarifas,
            Ff102TotalImpostosmais = ff102TotalImpostosmais,
            Ff102TotalImpostosmenos = ff102TotalImpostosmenos,
            Ff102VlLiqTitulo = ff102VlLiqTitulo,
            Ff102Nodiasliberacao = ff102Nodiasliberacao,
            Ff102TipoDesconto = ff102TipoDesconto,
            Ff102Percdescfinan = ff102Percdescfinan,
            Ff102Diasparadesconto = ff102Diasparadesconto,
            Ff102CnabCodDesconto = ff102CnabCodDesconto,
            Ff102NoPagamentos = ff102NoPagamentos,
            Ff102DataUltPagto = ff102DataUltPagto,
            Ff102Observacao = ff102Observacao,
            Ff102InstCobranca1 = ff102InstCobranca1,
            Ff102InstCobranca2 = ff102InstCobranca2,
            Ff102NoBordero = ff102NoBordero,
            Ff102FluxoCaixa = ff102FluxoCaixa,
            Ff102Origem = ff102Origem,
            Ff102Vendaid = ff102Vendaid,
            Ff102Compraid = ff102Compraid,
            Ff102NPdv = ff102NPdv,
            Ff102NumeroNf = ff102NumeroNf,
            Ff102SerieNf = ff102SerieNf,
            Ff102CiNfNfCupom = ff102CiNfNfCupom,
            Ff102TotalNotas = ff102TotalNotas,
            Ff102Empenho = ff102Empenho,
            Ff102Processo = ff102Processo,
            Ff102NContrato = ff102NContrato,
            Ff102Situacao = ff102Situacao,
            Ff102Situacaoid = ff102Situacaoid,
            Ff102SequenciaLog = ff102SequenciaLog,
            Ff102NossoNumero = ff102NossoNumero,
            Ff102DvNossoNumero = ff102DvNossoNumero,
            Ff102DvCodgBeneficiario = ff102DvCodgBeneficiario,
            Ff1021ocampodigitavel = ff1021ocampodigitavel,
            Ff1022ocampodigitavel = ff1022ocampodigitavel,
            Ff1023ocampodigitavel = ff1023ocampodigitavel,
            Ff102DvCampoLivre = ff102DvCampoLivre,
            Ff102DvCodigoBarras = ff102DvCodigoBarras,
            Ff102FatorVencimento = ff102FatorVencimento,
            Ff102Vlrnominaltitulo = ff102Vlrnominaltitulo,
            Ff102CodigoBarras = ff102CodigoBarras,
            Ff102Modalidcbarras = ff102Modalidcbarras,
            Ff102Linhadigital = ff102Linhadigital,
            Ff102Codcobrador = ff102Codcobrador,
            Ff102Lanctocontabil = ff102Lanctocontabil,
            Ff102cpNoDuplicata = ff102cpNoDuplicata,
            Ff102cpValorMulta = ff102cpValorMulta,
            Ff102cpValorJurosDia = ff102cpValorJurosDia,
            Ff102cpAprovador = ff102cpAprovador,
            Ff102cpAprovadorid = ff102cpAprovadorid,
            Ff102cpDataAprovacao = ff102cpDataAprovacao,
            Ff102cpHoraAprovacao = ff102cpHoraAprovacao,
            Ff102cpRegistroMarcado = ff102cpRegistroMarcado,
            Ff102cpTituloOriginal = ff102cpTituloOriginal,
            Ff102Dataapresentacao = ff102Dataapresentacao,
            Ff102cpLiberado = ff102cpLiberado,
            Ff102cpConfirmado = ff102cpConfirmado,
            Ff102TaxaCartao = ff102TaxaCartao,
            Ff102ValorTaxaCartao = ff102ValorTaxaCartao,
            Ff102CnabCodJurosMora = ff102CnabCodJurosMora,
            Ff102PercJurosAtr = ff102PercJurosAtr,
            Ff102CnabCodMulta = ff102CnabCodMulta,
            Ff102PercMulta = ff102PercMulta,
            Ff102Tpcobranca = ff102Tpcobranca,
            Ff102cpPagtoautorizadoId = ff102cpPagtoautorizadoId,
            Ff102cpConfirmadoId = ff102cpConfirmadoId,
            Ff102Cnsu = ff102Cnsu,
            Ff102Cdatamovimento = ff102Cdatamovimento,
            Ff102Cpv = ff102Cpv,
            Ff102Cautorizacao = ff102Cautorizacao,
            Ff102Cdoc = ff102Cdoc,
            Ff102Isconcvenda = ff102Isconcvenda,
            Ff102Isconcfinanc = ff102Isconcfinanc,
            Ff10FpagtoId = ff10FpagtoId,
            Ff102CtbIscontabilizadoid = ff102CtbIscontabilizadoid,
            Ff102CtbUsuarioid = ff102CtbUsuarioid,
            Ff102CtbDtregistro = ff102CtbDtregistro,
            Ff102CtbIsestornadoid = ff102CtbIsestornadoid,
            Ff102CtbEstusuarioid = ff102CtbEstusuarioid,
            Ff102CtbEstdtreg = ff102CtbEstdtreg,
            Ff102CtbIdlancto = ff102CtbIdlancto,
            Ff102CtbMsg = ff102CtbMsg,
            Ff102SitespecialId = ff102SitespecialId,
            Ff102Dtimestamp = ff102Dtimestamp,
            Ff102DtvencSimulado = ff102DtvencSimulado,
            Ff102PercCorrmonetaria = ff102PercCorrmonetaria,
            Ff102PercHonorarios = ff102PercHonorarios,
            Ff102VlCorrmonetaria = ff102VlCorrmonetaria,
            Ff102VlHonorarios = ff102VlHonorarios,
            Ff102CtlIscontabilizadoid = ff102CtlIscontabilizadoid,
            Ff102CtlUsuarioid = ff102CtlUsuarioid,
            Ff102CtlDtregistro = ff102CtlDtregistro,
            Ff102CtlIsestornadoid = ff102CtlIsestornadoid,
            Ff102CtlEstusuarioid = ff102CtlEstusuarioid,
            Ff102CtlEstdtreg = ff102CtlEstdtreg,
            Ff102CtlIdlancto = ff102CtlIdlancto,
            Ff102CtlMsg = ff102CtlMsg,
            Ff102ApiId = ff102ApiId,
            Ff102NoTitulocliente = ff102NoTitulocliente,
            Ff102HashId = ff102HashId,
            Ff102PixQrcode = ff102PixQrcode,
            Ff102Txid = ff102Txid,
            Ff102CodgOcorrencia = ff102CodgOcorrencia,
            Ff102Ocorrencia = ff102Ocorrencia,
            Ff102Jurosrecebido = ff102Jurosrecebido,
            Ff102Multarecebida = ff102Multarecebida,
            Ff102Outrovlrrecebido = ff102Outrovlrrecebido,
            Ff102Descconcedido = ff102Descconcedido,
            Ff102Valorpago = ff102Valorpago,
            Ff102DataRecto = ff102DataRecto,
            Ff102DataCredito = ff102DataCredito,
            Ff102DataBxaut = ff102DataBxaut,
            Ff102HoraBxaut = ff102HoraBxaut,
            Ff102DataProtesto = ff102DataProtesto,
            Ff102Diasprotesto = ff102Diasprotesto,
            Ff102Prazorecto = ff102Prazorecto,
            Ff102DataLimrecto = ff102DataLimrecto,
            Ff102CodigoErroApi = ff102CodigoErroApi,
            Ff102VersaoErroApi = ff102VersaoErroApi,
            Ff102MsgErroApi = ff102MsgErroApi,
            Ff102OcorErroApi = ff102OcorErroApi,
            Ff102OcorrenciaApi = ff102OcorrenciaApi,
            Ff102LiqApi = ff102LiqApi,
            Ff102BaixaApi = ff102BaixaApi,
            Ff102DataAtualizacao = ff102DataAtualizacao,
            Ff102HoraAtualizacao = ff102HoraAtualizacao,
            Ff102Flagbxtes = ff102Flagbxtes,
            Ff102Isaprovacao = ff102Isaprovacao,
            Ff102AdtoId = ff102AdtoId,
            Ff102Vdeduzidoadto = ff102Vdeduzidoadto,
            Ff102Hashcnab = ff102Hashcnab,
            Ff102Cpcodgrfederalid = ff102Cpcodgrfederalid,
            Ff102Cptppagtoid = ff102Cptppagtoid,
            Ff102Cptpprodutobbid = ff102Cptpprodutobbid,
            Ff102PixcobTransactionid = ff102PixcobTransactionid,
            Ff102PixcobQrcode = ff102PixcobQrcode,
            Ff102PixcobStatus = ff102PixcobStatus,
            Ff102TrilhaApiid = ff102TrilhaApiid
        };

 
}

    public static CSICP_FF102 CreateInstance(
 int tenantId,
 string id,
 int? ff102Tiporegistro,
 string? ff102Filialid,
 int? ff102Tipoparcelaid,
 int? ff102ParcelaX,
 int? ff102ParcelaY,
 string? ff102Pfx,
 string? ff102Sfx,
 string? ff102Contaid,
 string? ff102Contarealid,
 string? ff102Ccustoid,
 string? ff102Usuarioproprieid,
 string? ff102Agcobradorid,
 string? ff102Responsavelid,
 string? ff102Administradoraid,
 DateTime? ff102DataEmissao,
 DateTime ff102Cdatamovimento,
 decimal? ff102ValorTitulo,
 decimal? ff102VlLiqTitulo,
 string? ff102Observacao,
 int? ff102FluxoCaixa,
 int ff102Situacaoid,
 decimal? ff102NoTitulo,
 string? ff10FpagtoId,
 string? ff102Condicaoid,
 int? ff102cpConfirmadoId,
 int? ff102cpPagtoautorizadoId,
 object? ff102Especieid // Use o tipo correto se não for object
)
    {
        return new CSICP_FF102
        {
            TenantId = tenantId,
            Id = id,
            Ff102Tiporegistro = ff102Tiporegistro,
            Ff102Filialid = ff102Filialid,
            Ff102Tipoparcelaid = ff102Tipoparcelaid,
            Ff102ParcelaX = ff102ParcelaX,
            Ff102ParcelaY = ff102ParcelaY,
            Ff102Pfx = ff102Pfx,
            Ff102Sfx = ff102Sfx,
            Ff102Contaid = ff102Contaid,
            Ff102Contarealid = ff102Contarealid,
            Ff102Ccustoid = ff102Ccustoid,
            Ff102Usuarioproprieid = ff102Usuarioproprieid,
            Ff102Agcobradorid = ff102Agcobradorid,
            Ff102Responsavelid = ff102Responsavelid,
            Ff102Administradoraid = ff102Administradoraid,
            Ff102DataEmissao = ff102DataEmissao ?? default,
            Ff102Cdatamovimento = ff102Cdatamovimento.ToString(),
            Ff102ValorTitulo = ff102ValorTitulo,
            Ff102VlLiqTitulo = ff102VlLiqTitulo ?? 0,
            Ff102Observacao = ff102Observacao,
            Ff102FluxoCaixa = ff102FluxoCaixa,
            Ff102Situacaoid = ff102Situacaoid,
            Ff102NoTitulo = ff102NoTitulo,
            Ff10FpagtoId = ff10FpagtoId,
            Ff102Condicaoid = ff102Condicaoid,
            Ff102cpConfirmadoId = ff102cpConfirmadoId,
            Ff102cpPagtoautorizadoId = ff102cpPagtoautorizadoId,
            Ff102Especieid = ff102Especieid?.ToString(),
            Ff102DataVencimento = ff102Cdatamovimento 
            
            // Todas as outras propriedades permanecem nulas ou com valor padrão
        };
    }

    public bool SituacaoDoTituloIs(int InSitId)
    {
        return this.Ff102Situacaoid == InSitId;
    }

    public bool SituacaoDoTituloIsNot(int InSitId)
    {
        return this.Ff102Situacaoid != InSitId;
    }

    public bool CampoConfirmadoIdTemValor()
    {
        return this.Ff102cpConfirmadoId != null;
    }

    public bool CampoConfirmadoEhNulo()
    {
        return this.Ff102cpConfirmadoId == null;
    }

    public bool CampoConfirmadoIs(int InStId)
    {
        return this.Ff102cpConfirmadoId == InStId;
    }
    public bool CampoConfirmadoIsNot(int InStId)
    {
        return this.Ff102cpConfirmadoId != InStId;
    }

    public void AtualizarCampoConfirmadoId(int InStId)
    {
        this.Ff102cpConfirmadoId = InStId;
    }

    public bool CampoPagtoAutorizadoIdTemValor()
    {
        return this.Ff102cpPagtoautorizadoId != null;
    }

    public bool CampoPagtoAutorizadoIdIsNot(int InStID)
    {
        return this.Ff102cpPagtoautorizadoId != InStID;
    }

    public bool CampoPagtoAutorizadoIdIs(int InStID)
    {
        return this.Ff102cpPagtoautorizadoId == InStID;
    }

    public void AtualizarPagtoAutorizadoId(int InStId)
    {
        this.Ff102cpPagtoautorizadoId = InStId;
    }

}
