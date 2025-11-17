using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos;
using CSCore.Domain.Interfaces.Calculos.CalculoAtrasoMultaJurosTitulos.Parametros;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF018;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF018RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF018>(appDbContext, "Id"), IFF018Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<CSICP_FF018>, int)> GetListAsync(int in_tenant, string in_ff017Id,
            int in_pageNumber, int in_pageSize, bool? devePaginar = true)
        {
            IQueryable<CSICP_FF018> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff017Id, query);

            var queryCount = query;
            var count = queryCount.Count();

            if(devePaginar == true)
                query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }


        public async Task<CSICP_FF018> GetById(int in_tenant, string ID)
        {
            return await GetQueryBase(in_tenant).FirstOrDefaultAsync(e => e.Id == ID)
                ?? throw new KeyNotFoundException("FF018 Não encontrada!");
        }


        public async Task<bool> VarrerListaECalcularJuros(CSICP_FF017 WorkFF017, ICalculoAtrasoMultaJurosTitulos ICalculoAtraso)
        {
            var ListWorkFF018 = await this.GetListAsync(WorkFF017.TenantId, WorkFF017.Id, in_pageNumber: 1, in_pageSize: 9999, devePaginar: false);
            if (ListWorkFF018.Item1.Count() == 0) return false;
            foreach (var currentFF018 in ListWorkFF018.Item1)
            {
                var has = _appDbContext.ChangeTracker.Entries().Any(e => e.Entity == currentFF018);
                PrmRetornoCalculo retornoCalculos = CalcularRetornoJurosMulta(WorkFF017, ICalculoAtraso, currentFF018);

                currentFF018.Ff018ValorJuros = retornoCalculos.OutValorJuros;
                currentFF018.Ff018ValorMulta = retornoCalculos.OutValorMulta;
                currentFF018.Ff018ValorAberto = (currentFF018.NavFF102?.Ff102ValorTitulo ?? 0)
                    + (currentFF018.Ff018ValorJuros ?? 0)
                    + (currentFF018.Ff018ValorMulta ?? 0)
                    - (currentFF018.Ff018ValorDescontos ?? 0);

                _appDbContext.ChangeTracker.Clear();
                _appDbContext.Entry(currentFF018).State = EntityState.Modified;
            }
            return true;
        }


        private static PrmRetornoCalculo CalcularRetornoJurosMulta(CSICP_FF017 WorkFF017
            , ICalculoAtrasoMultaJurosTitulos ICalculoAtraso, CSICP_FF018 currentFF018)
        {
            var WorkPrmCalculoJuros = PrmEntradaCalculo.CreateInstance(
                 inTenantID: WorkFF017.TenantId,
                 inDataVencimento: currentFF018.NavFF102?.Ff102DataVencimento ?? new DateTime(1999, 01, 01),
                 inDiasLiberacao: 0,
                 inValorTitulo: currentFF018.NavFF102?.Ff102ValorTitulo ?? 0,
                 inPercentualCorrecaoMonetaria: 0,
                 inPercentualMulta: WorkFF017.Ff017Multa,
                 inPercentualJuros: WorkFF017.Ff017PercJuros,
                 inPercentualHonorarios: 0,
                 inEstabID: WorkFF017.Ff017Filialid ?? string.Empty,
                 inFinacEspJurosMulta: false,
                 inValorMulta: currentFF018.NavFF102?.Ff102cpValorMulta,
                 inValorJurosDia: currentFF018.NavFF102?.Ff102cpValorJurosDia
             );

            var retornoCalculos = ICalculoAtraso.CalcularContasAPagar(WorkPrmCalculoJuros);
            return retornoCalculos;
        }


        private IQueryable<CSICP_FF018> FiltraQuandoExisteFiltro(string in_ff017Id, IQueryable<CSICP_FF018> query)
        {
            if (!string.IsNullOrEmpty(in_ff017Id))
                query = query.Where(e => e.Ff017Id == in_ff017Id);
            return query;
        }

        private IQueryable<CSICP_FF018> GetQueryBase(int in_tenant)
        {
            return from ff018 in _appDbContext.OsusrE9aCsicpFf018s
                   .AsNoTracking()

                   join ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   on ff018.Ff102Tituloid equals ff102.Id into ff018_ff102_join
                   from ff102 in ff018_ff102_join.DefaultIfEmpty()

                   join ff102Sit in _appDbContext.OsusrE9aCsicpFf102Sits
                   on ff018.Ff018Situacaotituloid equals ff102Sit.Id into ff018_ff102Sit_join
                   from ff102Sit in ff018_ff102Sit_join.DefaultIfEmpty()

                   where ff018.TenantId == in_tenant

                   select new CSICP_FF018
                   {
                       TenantId = ff018.TenantId,
                       Id = ff018.Id,
                       Ff017Id = ff018.Ff017Id,
                       Ff102Tituloid = ff018.Ff102Tituloid,
                       Ff018ValorTitulo = ff018.Ff018ValorTitulo,
                       Ff018ValorMulta = ff018.Ff018ValorMulta,
                       Ff018ValorJuros = ff018.Ff018ValorJuros,
                       Ff018ValorDescontos = ff018.Ff018ValorDescontos,
                       Ff018ValorAberto = ff018.Ff018ValorAberto,
                       Ff018Situacaotituloid = ff018.Ff018Situacaotituloid,
                       Ff018Filial = ff018.Ff018Filial,
                       Ff018FilialTit = ff018.Ff018FilialTit,
                       Ff018Pfx = ff018.Ff018Pfx,
                       Ff018Titulo = ff018.Ff018Titulo,
                       Ff018Sfx = ff018.Ff018Sfx,
                       Ff018Situacao = ff018.Ff018Situacao,
                       Ff018Protocolnumber = ff018.Ff018Protocolnumber,
                       Ff018Vmultaorig = ff018.Ff018Vmultaorig,
                       Ff018Vjurosorig = ff018.Ff018Vjurosorig,
                       Ff018Vabertoorig = ff018.Ff018Vabertoorig,
                      
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

                       NavFF102Sit = ff102Sit != null ? new CSICP_FF102Sit
                       {
                           Id = ff102Sit.Id,
                           Label = ff102Sit.Label,
                           Order = ff102Sit.Order,
                           IsActive = ff102Sit.IsActive,
                           Codgcs = ff102Sit.Codgcs
                       } : null
                   };
                   
        }


    }
}