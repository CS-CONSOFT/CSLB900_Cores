using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102
{
    public class DtoCreateUpdateFF102 : IConverteParaEntidade<CSICP_FF102>
    {
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

        public DateTime? Ff102DataEmissao { get; set; }

        public DateTime Ff102DataVencimento { get; set; }

        public DateTime? Ff102DataVencReal { get; set; }

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
        public CSICP_FF102 ToEntity(int tenant, string? id)
        {
            return new CSICP_FF102
            {
                TenantId = tenant,
                Id = id!,
                Ff102Tiporegistro = Ff102Tiporegistro,
                Ff102Filialid = Ff102Filialid,
                Ff102Filial = Ff102Filial,
                Ff102Pfx = Ff102Pfx,
                Ff102NoTitulo = Ff102NoTitulo,
                Ff102Sfx = Ff102Sfx,
                Ff102NoTitulonobanco = Ff102NoTitulonobanco,
                Ff102Especieid = Ff102Especieid,
                Ff102Tipoparcelaid = Ff102Tipoparcelaid,
                Ff102TipoParcela = Ff102TipoParcela,
                Ff102ParcelaX = Ff102ParcelaX,
                Ff102ParcelaY = Ff102ParcelaY,
                Ff102Contaid = Ff102Contaid,
                Ff102Contarealid = Ff102Contarealid,
                Ff102AvalistaId = Ff102AvalistaId,
                Ff102Ccustoid = Ff102Ccustoid,
                Ff102Usuarioproprieid = Ff102Usuarioproprieid,
                Ff102Agcobradorid = Ff102Agcobradorid,
                Ff102Responsavelid = Ff102Responsavelid,
                Ff102Condicaoid = Ff102Condicaoid,
                Ff102Administradoraid = Ff102Administradoraid,
                Ff102Tipocobrancaid = Ff102Tipocobrancaid,
                Ff102Moedaid = Ff102Moedaid,
                Ff102CodgCliente = Ff102CodgCliente,
                Ff102Codclientereal = Ff102Codclientereal,
                Ff102CliFavorecido = Ff102CliFavorecido,
                Ff102CodgCcusto = Ff102CodgCcusto,
                Ff102CodgAcobrador = Ff102CodgAcobrador,
                Ff102CodgResponsavel = Ff102CodgResponsavel,
                Ff102CodgCondicao = Ff102CodgCondicao,
                Ff102Codadministrad = Ff102Codadministrad,
                Ff102CodgTcobranca = Ff102CodgTcobranca,
                Ff102CodgMoeda = Ff102CodgMoeda,
                Ff102DataEmissao = Ff102DataEmissao ?? DateTime.Now,
                Ff102DataVencimento = Ff102DataVencimento,
                Ff102DataVencReal = Ff102DataVencReal ?? DateTime.Now,
                Ff102ValorTitulo = Ff102ValorTitulo,
                Ff102VlAcrescimos = Ff102VlAcrescimos,
                Ff102VlDecrescimos = Ff102VlDecrescimos,
                Ff102ValorDesagio = Ff102ValorDesagio,
                Ff102TotalPagamentos = Ff102TotalPagamentos,
                Ff102TotalMultaPaga = Ff102TotalMultaPaga,
                Ff102TotalJuros = Ff102TotalJuros,
                Ff102TotalDescontos = Ff102TotalDescontos,
                Ff102TotalDevolucao = Ff102TotalDevolucao,
                Ff102TotalDoacao = Ff102TotalDoacao,
                Ff102TotalTarifas = Ff102TotalTarifas,
                Ff102TotalImpostosmais = Ff102TotalImpostosmais,
                Ff102TotalImpostosmenos = Ff102TotalImpostosmenos,
                Ff102VlLiqTitulo = Ff102VlLiqTitulo,
                Ff102Nodiasliberacao = Ff102Nodiasliberacao,
                Ff102TipoDesconto = Ff102TipoDesconto,
                Ff102Percdescfinan = Ff102Percdescfinan,
                Ff102Diasparadesconto = Ff102Diasparadesconto,
                Ff102CnabCodDesconto = Ff102CnabCodDesconto,
                Ff102NoPagamentos = Ff102NoPagamentos,
                Ff102DataUltPagto = Ff102DataUltPagto,
                Ff102Observacao = Ff102Observacao,
                Ff102InstCobranca1 = Ff102InstCobranca1,
                Ff102InstCobranca2 = Ff102InstCobranca2,
                Ff102NoBordero = Ff102NoBordero,
                Ff102FluxoCaixa = Ff102FluxoCaixa,
                Ff102Origem = Ff102Origem,
                Ff102Vendaid = Ff102Vendaid,
                Ff102Compraid = Ff102Compraid,
                Ff102NPdv = Ff102NPdv,
                Ff102NumeroNf = Ff102NumeroNf,
                Ff102SerieNf = Ff102SerieNf,
                Ff102CiNfNfCupom = Ff102CiNfNfCupom,
                Ff102TotalNotas = Ff102TotalNotas,
                Ff102Empenho = Ff102Empenho,
                Ff102Processo = Ff102Processo,
                Ff102NContrato = Ff102NContrato,
                Ff102Situacao = Ff102Situacao,
                Ff102Situacaoid = Ff102Situacaoid,
                Ff102SequenciaLog = Ff102SequenciaLog,
                Ff102NossoNumero = Ff102NossoNumero,
                Ff102DvNossoNumero = Ff102DvNossoNumero,
                Ff102DvCodgBeneficiario = Ff102DvCodgBeneficiario,
                Ff1021ocampodigitavel = Ff1021ocampodigitavel,
                Ff1022ocampodigitavel = Ff1022ocampodigitavel,
                Ff1023ocampodigitavel = Ff1023ocampodigitavel,
                Ff102DvCampoLivre = Ff102DvCampoLivre,
                Ff102DvCodigoBarras = Ff102DvCodigoBarras,
                Ff102FatorVencimento = Ff102FatorVencimento,
                Ff102Vlrnominaltitulo = Ff102Vlrnominaltitulo,
                Ff102CodigoBarras = Ff102CodigoBarras,
                Ff102Modalidcbarras = Ff102Modalidcbarras,
                Ff102Linhadigital = Ff102Linhadigital,
                Ff102Codcobrador = Ff102Codcobrador,
                Ff102Lanctocontabil = Ff102Lanctocontabil,
                Ff102cpNoDuplicata = Ff102cpNoDuplicata,
                Ff102cpValorMulta = Ff102cpValorMulta,
                Ff102cpValorJurosDia = Ff102cpValorJurosDia,
                Ff102cpAprovador = Ff102cpAprovador,
                Ff102cpAprovadorid = Ff102cpAprovadorid,
                Ff102cpDataAprovacao = Ff102cpDataAprovacao,
                Ff102cpHoraAprovacao = Ff102cpHoraAprovacao,
                Ff102cpRegistroMarcado = Ff102cpRegistroMarcado,
                Ff102cpTituloOriginal = Ff102cpTituloOriginal,
                Ff102Dataapresentacao = Ff102Dataapresentacao,
                Ff102cpLiberado = Ff102cpLiberado,
                Ff102cpConfirmado = Ff102cpConfirmado,
                Ff102TaxaCartao = Ff102TaxaCartao,
                Ff102ValorTaxaCartao = Ff102ValorTaxaCartao,
                Ff102CnabCodJurosMora = Ff102CnabCodJurosMora,
                Ff102PercJurosAtr = Ff102PercJurosAtr,
                Ff102CnabCodMulta = Ff102CnabCodMulta,
                Ff102PercMulta = Ff102PercMulta,
                Ff102Tpcobranca = Ff102Tpcobranca,
                Ff102cpPagtoautorizadoId = Ff102cpPagtoautorizadoId,
                Ff102cpConfirmadoId = Ff102cpConfirmadoId,
                Ff102Cnsu = Ff102Cnsu,
                Ff102Cdatamovimento = Ff102Cdatamovimento,
                Ff102Cpv = Ff102Cpv,
                Ff102Cautorizacao = Ff102Cautorizacao,
                Ff102Cdoc = Ff102Cdoc,
                Ff102Isconcvenda = Ff102Isconcvenda,
                Ff102Isconcfinanc = Ff102Isconcfinanc,
                Ff10FpagtoId = Ff10FpagtoId,
                Ff102CtbIscontabilizadoid = Ff102CtbIscontabilizadoid,
                Ff102CtbUsuarioid = Ff102CtbUsuarioid,
                Ff102CtbDtregistro = Ff102CtbDtregistro,
                Ff102CtbIsestornadoid = Ff102CtbIsestornadoid,
                Ff102CtbEstusuarioid = Ff102CtbEstusuarioid,
                Ff102CtbEstdtreg = Ff102CtbEstdtreg,
                Ff102CtbIdlancto = Ff102CtbIdlancto,
                Ff102CtbMsg = Ff102CtbMsg,
                Ff102SitespecialId = Ff102SitespecialId,
                Ff102Dtimestamp = Ff102Dtimestamp,
                Ff102DtvencSimulado = Ff102DtvencSimulado,
                Ff102PercCorrmonetaria = Ff102PercCorrmonetaria,
                Ff102PercHonorarios = Ff102PercHonorarios,
                Ff102VlCorrmonetaria = Ff102VlCorrmonetaria,
                Ff102VlHonorarios = Ff102VlHonorarios,
                Ff102CtlIscontabilizadoid = Ff102CtlIscontabilizadoid,
                Ff102CtlUsuarioid = Ff102CtlUsuarioid,
                Ff102CtlDtregistro = Ff102CtlDtregistro,
                Ff102CtlIsestornadoid = Ff102CtlIsestornadoid,
                Ff102CtlEstusuarioid = Ff102CtlEstusuarioid,
                Ff102CtlEstdtreg = Ff102CtlEstdtreg,
                Ff102CtlIdlancto = Ff102CtlIdlancto,
                Ff102CtlMsg = Ff102CtlMsg,
                Ff102ApiId = Ff102ApiId,
                Ff102NoTitulocliente = Ff102NoTitulocliente,
                Ff102HashId = Ff102HashId,
                Ff102PixQrcode = Ff102PixQrcode,
                Ff102Txid = Ff102Txid,
                Ff102CodgOcorrencia = Ff102CodgOcorrencia,
                Ff102Ocorrencia = Ff102Ocorrencia,
                Ff102Jurosrecebido = Ff102Jurosrecebido,
                Ff102Multarecebida = Ff102Multarecebida,
                Ff102Outrovlrrecebido = Ff102Outrovlrrecebido,
                Ff102Descconcedido = Ff102Descconcedido,
                Ff102Valorpago = Ff102Valorpago,
                Ff102DataRecto = Ff102DataRecto,
                Ff102DataCredito = Ff102DataCredito,
                Ff102DataBxaut = Ff102DataBxaut,
                Ff102HoraBxaut = Ff102HoraBxaut,
                Ff102DataProtesto = Ff102DataProtesto,
                Ff102Diasprotesto = Ff102Diasprotesto,
                Ff102Prazorecto = Ff102Prazorecto,
                Ff102DataLimrecto = Ff102DataLimrecto,
                Ff102CodigoErroApi = Ff102CodigoErroApi,
                Ff102VersaoErroApi = Ff102VersaoErroApi,
                Ff102MsgErroApi = Ff102MsgErroApi,
                Ff102OcorErroApi = Ff102OcorErroApi,
                Ff102OcorrenciaApi = Ff102OcorrenciaApi,
                Ff102LiqApi = Ff102LiqApi,
                Ff102BaixaApi = Ff102BaixaApi,
                Ff102DataAtualizacao = Ff102DataAtualizacao,
                Ff102HoraAtualizacao = Ff102HoraAtualizacao,
                Ff102Flagbxtes = Ff102Flagbxtes,
                Ff102Isaprovacao = Ff102Isaprovacao,
                Ff102AdtoId = Ff102AdtoId,
                Ff102Vdeduzidoadto = Ff102Vdeduzidoadto,
                Ff102Hashcnab = Ff102Hashcnab,
                Ff102Cpcodgrfederalid = Ff102Cpcodgrfederalid,
                Ff102Cptppagtoid = Ff102Cptppagtoid,
                Ff102Cptpprodutobbid = Ff102Cptpprodutobbid,
                Ff102PixcobTransactionid = Ff102PixcobTransactionid,
                Ff102PixcobQrcode = Ff102PixcobQrcode,
                Ff102PixcobStatus = Ff102PixcobStatus,
                Ff102TrilhaApiid = Ff102TrilhaApiid
            };
        }
    }
}































