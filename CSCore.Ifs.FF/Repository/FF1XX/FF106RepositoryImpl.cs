using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.GenerateId;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF106;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF106RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF106>(appDbContext, "Id"), IFF106Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(List<RepoDtoCSICP_FF106>, int)> GetListAsync(int in_tenant,
            string in_ff105ID, int in_page, int in_pageSize)
        {
            IQueryable<RepoDtoCSICP_FF106> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff105ID, query);
            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);
            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF106> FiltraQuandoExisteFiltro(string in_ff105ID, IQueryable<RepoDtoCSICP_FF106> query)
        {
            if (in_ff105ID != null)
                query = query.Where(e => e.Ff105Id!.Equals(in_ff105ID));
            return query;
        }

        private IQueryable<RepoDtoCSICP_FF106> GetQueryBase(int in_tenant)
        {
            return from ff106 in _appDbContext.OsusrE9aCsicpFf106s
                   .AsNoTracking()

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff106.Ff106Filialid equals bb001.Id into bb001_ff106_join
                   from bb001 in bb001_ff106_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff106.Ff106Agcobradorid equals bb006.Id into bb006_ff106_join
                   from bb006 in bb006_ff106_join.DefaultIfEmpty()

                   join bb009 in _appDbContext.OsusrE9aCsicpBb009s
                   on ff106.Ff106Tipocobrancaid equals bb009.Id into bb009_ff106_join
                   from bb009 in bb009_ff106_join.DefaultIfEmpty()

                   join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   on ff106.Ff102Id equals ff102.Id into ff102_ff106_join //Titulo? Verificar
                   from ff102 in ff102_ff106_join.DefaultIfEmpty()

                   join ff105 in _appDbContext.OsusrE9aCsicpFf105s
                   on ff106.Ff105Id equals ff105.Id into ff105_ff106_join //Bordero? Verificar
                   from ff105 in ff105_ff106_join.DefaultIfEmpty()

                   join ff102OcorrenciaApi in _appDbContext.OsusrE9aCsicpFf112apiOcorrencia
                   on ff102.Ff102OcorrenciaApi equals ff102OcorrenciaApi.Id into ff102OcorrenciaApi_ff102_join
                   from ff102OcorrenciaApi in ff102OcorrenciaApi_ff102_join.DefaultIfEmpty()

                   join ff102LiqApi in _appDbContext.OsusrE9aCsicpFf112apiLiquidacaos
                   on ff102.Ff102LiqApi equals ff102LiqApi.Id into ff102LiqApi_ff102_join
                   from ff102LiqApi in ff102LiqApi_ff102_join.DefaultIfEmpty()

                   join ff102BaixaApi in _appDbContext.OsusrE9aCsicpFf112apiBaixas
                   on ff102.Ff102BaixaApi equals ff102BaixaApi.Id into ff102BaixaApi_ff102_join
                   from ff102BaixaApi in ff102BaixaApi_ff102_join.DefaultIfEmpty()

                   where ff106.TenantId == in_tenant
                   select new RepoDtoCSICP_FF106
                   {
                       TenantId = ff106.TenantId,
                       Id = ff106.Id,
                       Ff106Filialid = ff106.Ff106Filialid,
                       Ff105Id = ff106.Ff105Id,
                       Ff102Id = ff106.Ff102Id,
                       Ff106Selecionado = ff106.Ff106Selecionado,
                       Ff106Agcobradorid = ff106.Ff106Agcobradorid,
                       Ff106Tipocobrancaid = ff106.Ff106Tipocobrancaid,
                       Ff106InstCobranca1 = ff106.Ff106InstCobranca1,
                       Ff106InstCobranca2 = ff106.Ff106InstCobranca2,
                       Ff106IdOutroBordero = ff106.Ff106IdOutroBordero,
                       Ff106CodgOcorrencia = ff106.Ff106CodgOcorrencia,
                       Ff106Ocorrencia = ff106.Ff106Ocorrencia,
                       Ff106Jurosrecebido = ff106.Ff106Jurosrecebido,
                       Ff106Multarecebida = ff106.Ff106Multarecebida,
                       Ff106Outrovlrrecebido = ff106.Ff106Outrovlrrecebido,
                       Ff106Descconcedido = ff106.Ff106Descconcedido,
                       Ff106Valorpago = ff106.Ff106Valorpago,
                       Ff106DataRecto = ff106.Ff106DataRecto,
                       Ff106DataCredito = ff106.Ff106DataCredito,
                       Nn016IdBxTes = ff106.Nn016IdBxTes,
                       Ff106DataBxaut = ff106.Ff106DataBxaut,
                       Ff106DataProtesto = ff106.Ff106DataProtesto,
                       Ff106Diasprotesto = ff106.Ff106Diasprotesto,
                       Ff106Prazorecto = ff106.Ff106Prazorecto,
                       Ff106DataLimrecto = ff106.Ff106DataLimrecto,
                       Ff106CodigoErroApi = ff106.Ff106CodigoErroApi,
                       Ff106VersaoErroApi = ff106.Ff106VersaoErroApi,
                       Ff106MsgErroApi = ff106.Ff106MsgErroApi,
                       Ff106OcorErroApi = ff106.Ff106OcorErroApi,
                       Ff106OcorrenciaApi = ff106.Ff106OcorrenciaApi,
                       Ff106LiqApi = ff106.Ff106LiqApi,
                       Ff106BaixaApi = ff106.Ff106BaixaApi,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavBB006 = bb006 != null ? new CSICP_Bb006
                       {
                           TenantId = bb006.TenantId,
                           Id = bb006.Id,
                           Bb006Codgbanco = bb006.Bb006Codgbanco,
                           Bb006Banco = bb006.Bb006Banco
                       } : null,

                       NavBB009 = bb009 != null ? new CSICP_Bb009
                       {
                           TenantId = bb009.TenantId,
                           Id = bb009.Id,
                           Bb009Codigo = bb009.Bb009Codigo,
                           Bb009Tipocobranca = bb009.Bb009Tipocobranca,
                       } : null,

                       NavFF102 = ff102 != null ? new CSICP_FF102
                       {
                           TenantId = ff102.TenantId,
                           Id = ff102.Id,
                           Ff102Tiporegistro = ff102.Ff102Tiporegistro,
                           Ff102Filialid = ff102.Ff102Filialid,
                           Ff102Filial = ff102.Ff102Filial,
                           Ff102Pfx = ff102.Ff102Pfx,
                           Ff102NoTitulo = ff102.Ff102NoTitulo,
                           Ff102Sfx = ff102.Ff102Sfx,
                           Ff102NoTitulonobanco = ff102.Ff102NoTitulonobanco,
                           Ff102Especieid = ff102.Ff102Especieid,
                           Ff102Tipoparcelaid = ff102.Ff102Tipoparcelaid,
                           Ff102TipoParcela = ff102.Ff102TipoParcela,
                           Ff102ParcelaX = ff102.Ff102ParcelaX,
                           Ff102ParcelaY = ff102.Ff102ParcelaY,
                           Ff102Contaid = ff102.Ff102Contaid,
                           Ff102Contarealid = ff102.Ff102Contarealid,
                           Ff102AvalistaId = ff102.Ff102AvalistaId,
                           Ff102Ccustoid = ff102.Ff102Ccustoid,
                           Ff102Usuarioproprieid = ff102.Ff102Usuarioproprieid,
                           Ff102Agcobradorid = ff102.Ff102Agcobradorid,
                           Ff102Responsavelid = ff102.Ff102Responsavelid,
                           Ff102Condicaoid = ff102.Ff102Condicaoid,
                           Ff102Administradoraid = ff102.Ff102Administradoraid,
                           Ff102Tipocobrancaid = ff102.Ff102Tipocobrancaid,
                           Ff102Moedaid = ff102.Ff102Moedaid,
                           Ff102CodgCliente = ff102.Ff102CodgCliente,
                           Ff102Codclientereal = ff102.Ff102Codclientereal,
                           Ff102CliFavorecido = ff102.Ff102CliFavorecido,
                           Ff102CodgCcusto = ff102.Ff102CodgCcusto,
                           Ff102CodgAcobrador = ff102.Ff102CodgAcobrador,
                           Ff102CodgResponsavel = ff102.Ff102CodgResponsavel,
                           Ff102CodgCondicao = ff102.Ff102CodgCondicao,
                           Ff102Codadministrad = ff102.Ff102Codadministrad,
                           Ff102CodgTcobranca = ff102.Ff102CodgTcobranca,
                           Ff102CodgMoeda = ff102.Ff102CodgMoeda,
                           Ff102DataEmissao = ff102.Ff102DataEmissao,
                           Ff102DataVencimento = ff102.Ff102DataVencimento,
                           Ff102DataVencReal = ff102.Ff102DataVencReal,
                           Ff102ValorTitulo = ff102.Ff102ValorTitulo,
                           Ff102VlAcrescimos = ff102.Ff102VlAcrescimos,
                           Ff102VlDecrescimos = ff102.Ff102VlDecrescimos,
                           Ff102ValorDesagio = ff102.Ff102ValorDesagio,
                           Ff102TotalPagamentos = ff102.Ff102TotalPagamentos,
                           Ff102TotalMultaPaga = ff102.Ff102TotalMultaPaga,
                           Ff102TotalJuros = ff102.Ff102TotalJuros,
                           Ff102TotalDescontos = ff102.Ff102TotalDescontos,
                           Ff102TotalDevolucao = ff102.Ff102TotalDevolucao,
                           Ff102TotalDoacao = ff102.Ff102TotalDoacao,
                           Ff102TotalTarifas = ff102.Ff102TotalTarifas,
                           Ff102TotalImpostosmais = ff102.Ff102TotalImpostosmais,
                           Ff102TotalImpostosmenos = ff102.Ff102TotalImpostosmenos,
                           Ff102VlLiqTitulo = ff102.Ff102VlLiqTitulo,
                           Ff102Nodiasliberacao = ff102.Ff102Nodiasliberacao,
                           Ff102TipoDesconto = ff102.Ff102TipoDesconto,
                           Ff102Percdescfinan = ff102.Ff102Percdescfinan,
                           Ff102Diasparadesconto = ff102.Ff102Diasparadesconto,
                           Ff102CnabCodDesconto = ff102.Ff102CnabCodDesconto,
                           Ff102NoPagamentos = ff102.Ff102NoPagamentos,
                           Ff102DataUltPagto = ff102.Ff102DataUltPagto,
                           Ff102Observacao = ff102.Ff102Observacao,
                           Ff102InstCobranca1 = ff102.Ff102InstCobranca1,
                           Ff102InstCobranca2 = ff102.Ff102InstCobranca2,
                           Ff102NoBordero = ff102.Ff102NoBordero,
                           Ff102FluxoCaixa = ff102.Ff102FluxoCaixa,
                           Ff102Origem = ff102.Ff102Origem,
                           Ff102Vendaid = ff102.Ff102Vendaid,
                           Ff102Compraid = ff102.Ff102Compraid,
                           Ff102NPdv = ff102.Ff102NPdv,
                           Ff102NumeroNf = ff102.Ff102NumeroNf,
                           Ff102SerieNf = ff102.Ff102SerieNf,
                           Ff102CiNfNfCupom = ff102.Ff102CiNfNfCupom,
                           Ff102TotalNotas = ff102.Ff102TotalNotas,
                           Ff102Empenho = ff102.Ff102Empenho,
                           Ff102Processo = ff102.Ff102Processo,
                           Ff102NContrato = ff102.Ff102NContrato,
                           Ff102Situacao = ff102.Ff102Situacao,
                           Ff102Situacaoid = ff102.Ff102Situacaoid,
                           Ff102SequenciaLog = ff102.Ff102SequenciaLog,
                           Ff102NossoNumero = ff102.Ff102NossoNumero,
                           Ff102DvNossoNumero = ff102.Ff102DvNossoNumero,
                           Ff102DvCodgBeneficiario = ff102.Ff102DvCodgBeneficiario,
                           Ff1021ocampodigitavel = ff102.Ff1021ocampodigitavel,
                           Ff1022ocampodigitavel = ff102.Ff1022ocampodigitavel,
                           Ff1023ocampodigitavel = ff102.Ff1023ocampodigitavel,
                           Ff102DvCampoLivre = ff102.Ff102DvCampoLivre,
                           Ff102DvCodigoBarras = ff102.Ff102DvCodigoBarras,
                           Ff102FatorVencimento = ff102.Ff102FatorVencimento,
                           Ff102Vlrnominaltitulo = ff102.Ff102Vlrnominaltitulo,
                           Ff102CodigoBarras = ff102.Ff102CodigoBarras,
                           Ff102Modalidcbarras = ff102.Ff102Modalidcbarras,
                           Ff102Linhadigital = ff102.Ff102Linhadigital,
                           Ff102Codcobrador = ff102.Ff102Codcobrador,
                           Ff102Lanctocontabil = ff102.Ff102Lanctocontabil,
                           Ff102cpNoDuplicata = ff102.Ff102cpNoDuplicata,
                           Ff102cpValorMulta = ff102.Ff102cpValorMulta,
                           Ff102cpValorJurosDia = ff102.Ff102cpValorJurosDia,
                           Ff102cpAprovador = ff102.Ff102cpAprovador,
                           Ff102cpAprovadorid = ff102.Ff102cpAprovadorid,
                           Ff102cpDataAprovacao = ff102.Ff102cpDataAprovacao,
                           Ff102cpHoraAprovacao = ff102.Ff102cpHoraAprovacao,
                           Ff102cpRegistroMarcado = ff102.Ff102cpRegistroMarcado,
                           Ff102cpTituloOriginal = ff102.Ff102cpTituloOriginal,
                           Ff102Dataapresentacao = ff102.Ff102Dataapresentacao,
                           Ff102cpLiberado = ff102.Ff102cpLiberado,
                           Ff102cpConfirmado = ff102.Ff102cpConfirmado,
                           Ff102TaxaCartao = ff102.Ff102TaxaCartao,
                           Ff102ValorTaxaCartao = ff102.Ff102ValorTaxaCartao,
                           Ff102CnabCodJurosMora = ff102.Ff102CnabCodJurosMora,
                           Ff102PercJurosAtr = ff102.Ff102PercJurosAtr,
                           Ff102CnabCodMulta = ff102.Ff102CnabCodMulta,
                           Ff102PercMulta = ff102.Ff102PercMulta,
                           Ff102Tpcobranca = ff102.Ff102Tpcobranca,
                           Ff102cpPagtoautorizadoId = ff102.Ff102cpPagtoautorizadoId,
                           Ff102cpConfirmadoId = ff102.Ff102cpConfirmadoId,
                           Ff102Cnsu = ff102.Ff102Cnsu,
                           Ff102Cdatamovimento = ff102.Ff102Cdatamovimento,
                           Ff102Cpv = ff102.Ff102Cpv,
                           Ff102Cautorizacao = ff102.Ff102Cautorizacao,
                           Ff102Cdoc = ff102.Ff102Cdoc,
                           Ff102Isconcvenda = ff102.Ff102Isconcvenda,
                           Ff102Isconcfinanc = ff102.Ff102Isconcfinanc,
                           Ff10FpagtoId = ff102.Ff10FpagtoId,
                           Ff102CtbIscontabilizadoid = ff102.Ff102CtbIscontabilizadoid,
                           Ff102CtbUsuarioid = ff102.Ff102CtbUsuarioid,
                           Ff102CtbDtregistro = ff102.Ff102CtbDtregistro,
                           Ff102CtbIsestornadoid = ff102.Ff102CtbIsestornadoid,
                           Ff102CtbEstusuarioid = ff102.Ff102CtbEstusuarioid,
                           Ff102CtbEstdtreg = ff102.Ff102CtbEstdtreg,
                           Ff102CtbIdlancto = ff102.Ff102CtbIdlancto,
                           Ff102CtbMsg = ff102.Ff102CtbMsg,
                           Ff102SitespecialId = ff102.Ff102SitespecialId,
                           Ff102Dtimestamp = ff102.Ff102Dtimestamp,
                           Ff102DtvencSimulado = ff102.Ff102DtvencSimulado,
                           Ff102PercCorrmonetaria = ff102.Ff102PercCorrmonetaria,
                           Ff102PercHonorarios = ff102.Ff102PercHonorarios,
                           Ff102VlCorrmonetaria = ff102.Ff102VlCorrmonetaria,
                           Ff102VlHonorarios = ff102.Ff102VlHonorarios,
                           Ff102CtlIscontabilizadoid = ff102.Ff102CtlIscontabilizadoid,
                           Ff102CtlUsuarioid = ff102.Ff102CtlUsuarioid,
                           Ff102CtlDtregistro = ff102.Ff102CtlDtregistro,
                           Ff102CtlIsestornadoid = ff102.Ff102CtlIsestornadoid,
                           Ff102CtlEstusuarioid = ff102.Ff102CtlEstusuarioid,
                           Ff102CtlEstdtreg = ff102.Ff102CtlEstdtreg,
                           Ff102CtlIdlancto = ff102.Ff102CtlIdlancto,
                           Ff102CtlMsg = ff102.Ff102CtlMsg,
                           Ff102ApiId = ff102.Ff102ApiId,
                           Ff102NoTitulocliente = ff102.Ff102NoTitulocliente,
                           Ff102HashId = ff102.Ff102HashId,
                           Ff102PixQrcode = ff102.Ff102PixQrcode,
                           Ff102Txid = ff102.Ff102Txid,
                           Ff102CodgOcorrencia = ff102.Ff102CodgOcorrencia,
                           Ff102Ocorrencia = ff102.Ff102Ocorrencia,
                           Ff102Jurosrecebido = ff102.Ff102Jurosrecebido,
                           Ff102Multarecebida = ff102.Ff102Multarecebida,
                           Ff102Outrovlrrecebido = ff102.Ff102Outrovlrrecebido,
                           Ff102Descconcedido = ff102.Ff102Descconcedido,
                           Ff102Valorpago = ff102.Ff102Valorpago,
                           Ff102DataRecto = ff102.Ff102DataRecto,
                           Ff102DataCredito = ff102.Ff102DataCredito,
                           Ff102DataBxaut = ff102.Ff102DataBxaut,
                           Ff102HoraBxaut = ff102.Ff102HoraBxaut,
                           Ff102DataProtesto = ff102.Ff102DataProtesto,
                           Ff102Diasprotesto = ff102.Ff102Diasprotesto,
                           Ff102Prazorecto = ff102.Ff102Prazorecto,
                           Ff102DataLimrecto = ff102.Ff102DataLimrecto,
                           Ff102CodigoErroApi = ff102.Ff102CodigoErroApi,
                           Ff102VersaoErroApi = ff102.Ff102VersaoErroApi,
                           Ff102MsgErroApi = ff102.Ff102MsgErroApi,
                           Ff102OcorErroApi = ff102.Ff102OcorErroApi,
                           Ff102OcorrenciaApi = ff102.Ff102OcorrenciaApi,
                           Ff102LiqApi = ff102.Ff102LiqApi,
                           Ff102BaixaApi = ff102.Ff102BaixaApi,
                           Ff102DataAtualizacao = ff102.Ff102DataAtualizacao,
                           Ff102HoraAtualizacao = ff102.Ff102HoraAtualizacao,
                           Ff102Flagbxtes = ff102.Ff102Flagbxtes,
                           Ff102Isaprovacao = ff102.Ff102Isaprovacao,
                           Ff102AdtoId = ff102.Ff102AdtoId,
                           Ff102Vdeduzidoadto = ff102.Ff102Vdeduzidoadto,
                           Ff102Hashcnab = ff102.Ff102Hashcnab,
                           Ff102Cpcodgrfederalid = ff102.Ff102Cpcodgrfederalid,
                           Ff102Cptppagtoid = ff102.Ff102Cptppagtoid,
                           Ff102Cptpprodutobbid = ff102.Ff102Cptpprodutobbid,
                           Ff102PixcobTransactionid = ff102.Ff102PixcobTransactionid,
                           Ff102PixcobQrcode = ff102.Ff102PixcobQrcode,
                           Ff102PixcobStatus = ff102.Ff102PixcobStatus,
                           Ff102TrilhaApiid = ff102.Ff102TrilhaApiid,
                       } : null,

                       NavFF105 = ff105 != null ? new CSICP_FF105
                       {
                           TenantId = ff105.TenantId,
                           Id = ff105.Id,
                           Ff105Filialid = ff105.Ff105Filialid,
                           Ff105Descricaobordero = ff105.Ff105Descricaobordero,
                           Ff105ClienteInicial = ff105.Ff105ClienteInicial,
                           Ff105ClienteFinal = ff105.Ff105ClienteFinal,
                           Ff105EmissaoInicial = ff105.Ff105EmissaoInicial,
                           Ff105EmissaoFinal = ff105.Ff105EmissaoFinal,
                           Ff105VenctoInicial = ff105.Ff105VenctoInicial,
                           Ff105VenctoFinal = ff105.Ff105VenctoFinal,
                           Ff105CodgcategIni = ff105.Ff105CodgcategIni,
                           Ff105CodgcategFim = ff105.Ff105CodgcategFim,
                           Ff105CodgrotaIni = ff105.Ff105CodgrotaIni,
                           Ff105CodgrotaFim = ff105.Ff105CodgrotaFim,
                           Ff105ValorMinimo = ff105.Ff105ValorMinimo,
                           Ff105Agcobradorid = ff105.Ff105Agcobradorid,
                           Ff105Tipocobrancaid = ff105.Ff105Tipocobrancaid,
                           Ff105InstCobranca1 = ff105.Ff105InstCobranca1,
                           Ff105InstCobranca2 = ff105.Ff105InstCobranca2,
                           Ff105Agencia = ff105.Ff105Agencia,
                           Ff105AgenciaDv = ff105.Ff105AgenciaDv,
                           Ff105ContaCorrente = ff105.Ff105ContaCorrente,
                           Ff105ContaDv = ff105.Ff105ContaDv,
                           Ff105DataEnvio = ff105.Ff105DataEnvio,
                           Ff105ValorBordero = ff105.Ff105ValorBordero,
                           Ff105QtdTitulos = ff105.Ff105QtdTitulos,
                           Ff105Fechado = ff105.Ff105Fechado,
                           Ff105IsActive = ff105.Ff105IsActive,
                           Ff105Status = ff105.Ff105Status,
                           Ff105Protocolnumber = ff105.Ff105Protocolnumber,
                           Ff105ApiId = ff105.Ff105ApiId,
                           Ff105Statusapi = ff105.Ff105Statusapi,
                           Ff105DataCriacao = ff105.Ff105DataCriacao,
                       } : null,

                       NavFF112ApiOcorrencia = ff102OcorrenciaApi != null ? new CSICP_FF112ApiOcorrencium
                       {
                           Id = ff102OcorrenciaApi.Id,
                           Label = ff102OcorrenciaApi.Label,
                           Order = ff102OcorrenciaApi.Order,
                           IsActive = ff102OcorrenciaApi.IsActive,
                           CodgOcorrencia = ff102OcorrenciaApi.CodgOcorrencia,
                           BancoApi = ff102OcorrenciaApi.BancoApi,
                       } : null,

                       NavFF112ApiLiquidacao = ff102LiqApi != null ? new CSICP_FF112ApiLiquidacao
                       {
                           Id = ff102LiqApi.Id,
                           Label = ff102LiqApi.Label,
                           Order = ff102LiqApi.Order,
                           IsActive = ff102LiqApi.IsActive,
                           CodgLiquidacao = ff102LiqApi.CodgLiquidacao,
                           BancoApi = ff102LiqApi.BancoApi,
                       } : null,

                       NavFF112ApiBaixa = ff102BaixaApi != null ? new CSICP_FF112ApiBaixa
                       {
                           Id = ff102BaixaApi.Id,
                           Label = ff102BaixaApi.Label,
                           Order = ff102BaixaApi.Order,
                           IsActive = ff102BaixaApi.IsActive,
                           CodgBaixa = ff102BaixaApi.CodgBaixa,
                           BancoApi = ff102BaixaApi.BancoApi,
                       } : null,
                   };
        }
    }
}