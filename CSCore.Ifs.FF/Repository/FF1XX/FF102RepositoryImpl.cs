using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using NPOI.HPSF;
using System;
using System.Collections.Generic;
using System.Linq;
using static CSCore.Domain.ComboTypes;


namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF102RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF102>(appDbContext, "Id"), IFF102Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<RepoDtoCSICP_FF102?> GetByIdAsync(int in_tenant, string? in_ff102Id, int? in_tipoRegistro)
        {
            IQueryable<RepoDtoCSICP_FF102> query = GetQueryBase(in_tenant);
            //1.Contas a Receber, 2.Cartao Credito, 3.Contas a Pagar
            if (in_tipoRegistro != null)
            {
                query = query.Where(e => e.Ff102Tiporegistro == in_tipoRegistro);
            }
            RepoDtoCSICP_FF102? cSICP_FF102 = await query.FirstOrDefaultAsync(e => e.Id == in_ff102Id);
            return cSICP_FF102;
        }

        private IQueryable<RepoDtoCSICP_FF102> GetQueryBase(int in_tenant)
        {
            return from ff102 in _appDbContext.OsusrE9aCsicpFf102s

                       //42 tabelas
                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on ff102.Ff102Filialid equals bb001.Id into bb001_ff102_join
                   from bb001 in bb001_ff102_join.DefaultIfEmpty()

                   join ff003 in _appDbContext.OsusrE9aCsicpFf003s
                   on ff102.Ff102Especieid equals ff003.Id into ff003_ff102_join
                   from ff003 in ff003_ff102_join.DefaultIfEmpty()

                   join ff102ent in _appDbContext.OsusrE9aCsicpFf102Ents
                   on ff102.Ff102Tipoparcelaid equals ff102ent.Id into ff102ent_ff102_join
                   from ff102ent in ff102ent_ff102_join.DefaultIfEmpty()

                   join bb012conta in _appDbContext.OsusrE9aCsicpBb012s
                   on ff102.Ff102Contaid equals bb012conta.Id into bb012conta_ff102_join
                   from bb012conta in bb012conta_ff102_join.DefaultIfEmpty()

                   join bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                   on bb012conta.Id equals bb01202.Id into bb01202_join
                   from bb01202 in bb01202_join.DefaultIfEmpty()

                   join bb01206 in _appDbContext.OsusrE9aCsicpBb01206s
                    on bb012conta.Id equals bb01206.Id into bb01206_join
                   from bb01206 in bb01206_join.DefaultIfEmpty()

                   join bb012contareal in _appDbContext.OsusrE9aCsicpBb012s
                   on ff102.Ff102Contarealid equals bb012contareal.Id into bb012contareal_ff102_join
                   from bb012contareal in bb012contareal_ff102_join.DefaultIfEmpty()

                   join bb012avalista in _appDbContext.OsusrE9aCsicpBb012s
                   on ff102.Ff102AvalistaId equals bb012avalista.Id into bb012avalista_ff102_join
                   from bb012avalista in bb012avalista_ff102_join.DefaultIfEmpty()

                   join bb003 in _appDbContext.OsusrE9aCsicpBb003s
                   on ff102.Ff102Moedaid equals bb003.Id into bb003_ff102_join
                   from bb003 in bb003_ff102_join.DefaultIfEmpty()

                   join bb005 in _appDbContext.OsusrE9aCsicpBb005s
                   on ff102.Ff102Ccustoid equals bb005.Id into bb005_ff102_join
                   from bb005 in bb005_ff102_join.DefaultIfEmpty()

                   join bb006 in _appDbContext.OsusrE9aCsicpBb006s
                   on ff102.Ff102Agcobradorid equals bb006.Id into bb006_ff102_join
                   from bb006 in bb006_ff102_join.DefaultIfEmpty()

                   join bb007 in _appDbContext.OsusrE9aCsicpBb007s
                   on ff102.Ff102Responsavelid equals bb007.Id into bb007_ff102_join
                   from bb007 in bb007_ff102_join.DefaultIfEmpty()

                   join bb008 in _appDbContext.OsusrE9aCsicpBb008s
                   on ff102.Ff102Condicaoid equals bb008.Id into bb008_ff102_join
                   from bb008 in bb008_ff102_join.DefaultIfEmpty()

                   join bb009 in _appDbContext.OsusrE9aCsicpBb009s
                   on ff102.Ff102Tipocobrancaid equals bb009.Id into bb009_ff102_join
                   from bb009 in bb009_ff102_join.DefaultIfEmpty()

                   join bb019 in _appDbContext.OsusrE9aCsicpBb019s
                   on ff102.Ff102Administradoraid equals bb019.Id into bb019_ff102_join
                   from bb019 in bb019_ff102_join.DefaultIfEmpty()

                   join sy001UsuarioProp in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102Usuarioproprieid equals sy001UsuarioProp.Id into sy001UsuarioProp_ff102_join
                   from sy001UsuarioProp in sy001UsuarioProp_ff102_join.DefaultIfEmpty()

                   join sy001CodCobrador in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102Codcobrador equals sy001CodCobrador.Id into sy001_ff102_join
                   from sy001CodCobrador in sy001_ff102_join.DefaultIfEmpty()

                   join sy001Aprovador in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102cpAprovadorid equals sy001Aprovador.Id into sy001Aprovador_ff102_join
                   from sy001Aprovador in sy001Aprovador_ff102_join.DefaultIfEmpty()

                   join ff102des in _appDbContext.OsusrE9aCsicpFf102Des
                   on ff102.Ff102TipoDesconto equals ff102des.Id into ff102des_ff102_join
                   from ff102des in ff102des_ff102_join.DefaultIfEmpty()

                   join ff102c021 in _appDbContext.OsusrE9aCsicpFf102C021s
                   on ff102.Ff102CnabCodDesconto equals ff102c021.Id into ff102c021_ff102_join
                   from ff102c021 in ff102c021_ff102_join.DefaultIfEmpty()

                   join staticaFluxoCaixa in _appDbContext.E9ACSICP_Statica
                   on ff102.Ff102FluxoCaixa equals staticaFluxoCaixa.Id into staticaFluxoCaixa_ff102_join
                   from staticaFluxoCaixa in staticaFluxoCaixa_ff102_join.DefaultIfEmpty()

                   join ff102sit in _appDbContext.OsusrE9aCsicpFf102Sits
                   on ff102.Ff102Situacaoid equals ff102sit.Id into ff102sit_ff102_join
                   from ff102sit in ff102sit_ff102_join.DefaultIfEmpty()

                   join ff102C018 in _appDbContext.OsusrE9aCsicpFf102C018s
                   on ff102.Ff102CnabCodJurosMora equals ff102C018.Id into ff102C018_ff102_join
                   from ff102C018 in ff102C018_ff102_join.DefaultIfEmpty()

                   join ff102g073 in _appDbContext.OsusrE9aCsicpFf102G073s
                   on ff102.Ff102CnabCodMulta equals ff102g073.Id into ff102g073_ff102_join
                   from ff102g073 in ff102g073_ff102_join.DefaultIfEmpty()

                   join ff102cob in _appDbContext.OsusrE9aCsicpFf102Cobs
                   on ff102.Ff102Tpcobranca equals ff102cob.Id into ff102cob_ff102_join
                   from ff102cob in ff102cob_ff102_join.DefaultIfEmpty()

                   join ff102Aut in _appDbContext.OsusrE9aCsicpFf102Auts
                   on ff102.Ff102cpPagtoautorizadoId equals ff102Aut.Id into ff102Aut_ff102_join
                   from ff102Aut in ff102Aut_ff102_join.DefaultIfEmpty()

                   join staticaConfirmado in _appDbContext.E9ACSICP_Statica
                   on ff102.Ff102cpConfirmadoId equals staticaConfirmado.Id into staticaConfirmado_ff102_join
                   from staticaConfirmado in staticaConfirmado_ff102_join.DefaultIfEmpty()

                   join bb026pagto in _appDbContext.OsusrE9aCsicpBb026s
                   on ff102.Ff10FpagtoId equals bb026pagto.Id into bb026pagto_ff102_join
                   from bb026pagto in bb026pagto_ff102_join.DefaultIfEmpty()

                       //join ws002Ctb in _appDbContextOsusrE9aCsicpWs002Ctbs CONTABILIZA

                   join sy001CtbUsuario in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102CtbUsuarioid equals sy001CtbUsuario.Id into sy001CtbUsuario_ff102_join
                   from sy001CtbUsuario in sy001CtbUsuario_ff102_join.DefaultIfEmpty()

                       //join ws002Ctb in _appDbContextOsusrE9aCsicpWs002Ctbs ESTORNADO

                   join sy001CtbEstUsuarioID in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102CtbEstusuarioid equals sy001CtbEstUsuarioID.Id into sy001CtbEstUsuarioID_ff102_join
                   from sy001CtbEstUsuarioID in sy001CtbEstUsuarioID_ff102_join.DefaultIfEmpty()

                   join bb012_01jur in _appDbContext.OsusrE9aCsicpBb01201Jurs
                   on ff102.Ff102SitespecialId equals bb012_01jur.Id into bb012_01jur_ff102_join
                   from bb012_01jur in bb012_01jur_ff102_join.DefaultIfEmpty()

                   join sy001CtlUsuario in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102CtlUsuarioid equals sy001CtlUsuario.Id into sy001CtlUsuario_ff102_join
                   from sy001CtlUsuario in sy001CtlUsuario_ff102_join.DefaultIfEmpty()

                   join sy001CtlEstUsuario in _appDbContext.OsusrE9aCsicpSy001s
                   on ff102.Ff102CtlEstusuarioid equals sy001CtlEstUsuario.Id into sy001CtlEstUsuario_ff102_join
                   from sy001CtlEstUsuario in sy001CtlEstUsuario_ff102_join.DefaultIfEmpty()

                   join ff102Api in _appDbContext.OsusrE9aCsicpFf102ApiBancos
                   on ff102.Ff102ApiId equals ff102Api.Id into ff102Api_ff102_join
                   from ff102Api in ff102Api_ff102_join.DefaultIfEmpty()

                   join ff102OcorrenciaApi in _appDbContext.OsusrE9aCsicpFf112apiOcorrencia
                   on ff102.Ff102OcorrenciaApi equals ff102OcorrenciaApi.Id into ff102OcorrenciaApi_ff102_join
                   from ff102OcorrenciaApi in ff102OcorrenciaApi_ff102_join.DefaultIfEmpty()

                   join ff102LiqApi in _appDbContext.OsusrE9aCsicpFf112apiLiquidacaos
                   on ff102.Ff102LiqApi equals ff102LiqApi.Id into ff102LiqApi_ff102_join
                   from ff102LiqApi in ff102LiqApi_ff102_join.DefaultIfEmpty()

                   join ff102BaixaApi in _appDbContext.OsusrE9aCsicpFf112apiBaixas
                   on ff102.Ff102BaixaApi equals ff102BaixaApi.Id into ff102BaixaApi_ff102_join
                   from ff102BaixaApi in ff102BaixaApi_ff102_join.DefaultIfEmpty()

                   join ff102Adt in _appDbContext.OsusrE9aCsicpFf102Adts
                   on ff102.Ff102AdtoId equals ff102Adt.Id into ff102Adt_ff102_join
                   from ff102Adt in ff102Adt_ff102_join.DefaultIfEmpty()

                       //join of001 in _appDbContext.OsusrE9aCsicpOf001s CPCodgRFederal

                       //join of002 in _appDbContext.OsusrE9aCsicpOf002tpgs CPTPagtoId

                       //join of002 in _appDbContext.OsusrE9aCsicpOf002prds CPTpProdutoBBID

                   join ff120track in _appDbContext.OsusrE9aCsicpFf120Trackapis
                   on ff102.Ff102TrilhaApiid equals ff120track.Id into ff120track_ff102_join
                   from ff120track in ff120track_ff102_join.DefaultIfEmpty()

                   where ff102.TenantId == in_tenant
                   select new RepoDtoCSICP_FF102
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

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                       } : null,

                       NavBB005 = bb005 != null ? new CSICP_Bb005
                       {
                           TenantId = bb005.TenantId,
                           Id = bb005.Id,
                           Bb005Codigo = bb005.Bb005Codigo,
                           Bb005Nomeccusto = bb005.Bb005Nomeccusto,
                       } : null,

                       NavBB006 = bb006 != null ? new CSICP_Bb006
                       {
                           TenantId = bb006.TenantId,
                           Id = bb006.Id,
                           Bb006Codgbanco = bb006.Bb006Codgbanco,
                           Bb006Banco = bb006.Bb006Banco,
                       } : null,

                       NavBB007 = bb007 != null ? new CSICP_BB007
                       {
                           TenantId = bb007.TenantId,
                           Id = bb007.Id,
                           Bb007Codigo = bb007.Bb007Codigo,
                           Bb007Responsavel = bb007.Bb007Responsavel,
                       } : null,

                       NavBB008 = bb008 != null ? new CSICP_Bb008
                       {
                           TenantId = bb008.TenantId,
                           Id = bb008.Id,
                           Bb008Codigo = bb008.Bb008Codigo,
                           Bb008Condicao = bb008.Bb008Condicao,
                       } : null,

                       NavBB009 = bb009 != null ? new CSICP_Bb009
                       {
                           TenantId = bb009.TenantId,
                           Id = bb009.Id,
                           Bb009Codigo = bb009.Bb009Codigo,
                           Bb009Tipocobranca = bb009.Bb009Tipocobranca,
                       } : null,

                       NavBB019 = bb019 != null ? new CSICP_Bb019
                       {
                           TenantId = bb019.TenantId,
                           Id = bb019.Id,
                           Bb019Codigo = bb019.Bb019Codigo,
                           Bb019Administradora = bb019.Bb019Administradora,
                       } : null,

                       NavBB012 = bb012conta != null ? new CSICP_BB012
                       {
                           TenantId = bb012conta.TenantId,
                           Id = bb012conta.Id,
                           Bb012Codigo = bb012conta.Bb012Codigo,
                           Bb012NomeCliente = bb012conta.Bb012NomeCliente,
                           Bb012GrupocontaId = bb012conta.Bb012GrupocontaId,

                           Nav_BB01202 = bb01202 != null ? new CSICP_BB01202
                           {
                               Id = bb01202.Id,
                               Bb012Cpf = bb01202.Bb012Cpf,
                               Bb012Cnpj = bb01202.Bb012Cnpj,
                           } : null,

                           NavBB01206 = bb01206 != null ? new CSICP_BB01206
                           {
                               Id = bb01206.Id,
                               Bb012Logradouro = bb01206.Bb012Logradouro,
                               Bb012Cep = bb01206.Bb012Cep,
                               Bb012Bairro = bb01206.Bb012Bairro,
                           } : null,
                       } : null,

                       NavBB012ContaRealID = bb012contareal != null ? new CSICP_BB012
                       {
                           TenantId = bb012contareal.TenantId,
                           Id = bb012contareal.Id,
                           Bb012Codigo = bb012contareal.Bb012Codigo,
                           Bb012NomeCliente = bb012contareal.Bb012NomeCliente,
                       } : null,

                       NavBB012AvalistaID = bb012avalista != null ? new CSICP_BB012
                       {
                           TenantId = bb012avalista.TenantId,
                           Id = bb012avalista.Id,
                           Bb012Codigo = bb012avalista.Bb012Codigo,
                           Bb012NomeCliente = bb012avalista.Bb012NomeCliente,
                       } : null,

                       NavBB01201Jur = bb012_01jur != null ? new CSICP_Bb01201Jur
                       {
                           Id = bb012_01jur.Id,
                           Label = bb012_01jur.Label,
                       } : null,

                       NavBB026 = bb026pagto != null ? new CSICP_Bb026
                       {
                           TenantId = bb026pagto.TenantId,
                           Id = bb026pagto.Id,
                           Bb026Codigo = bb026pagto.Bb026Codigo,
                           Bb026Formapagamento = bb026pagto.Bb026Formapagamento,
                       } : null,

                       NavFF003 = ff003 != null ? new CSICP_FF003
                       {
                           TenantId = ff003.TenantId,
                           Id = ff003.Id,
                           Ff003Codigo = ff003.Ff003Codigo,
                           Ff003Descricao = ff003.Ff003Descricao,
                       } : null,

                       NavFF102C021 = ff102c021 != null ? new CSICP_FF102_C021
                       {
                           Id = ff102c021.Id,
                           Label = ff102c021.Label,
                       } : null,

                       NavFF102Des = ff102des != null ? new CSICP_FF102Des
                       {
                           Id = ff102des.Id,
                           Label = ff102des.Label,
                       } : null,

                       NavFF102Ent = ff102ent != null ? new CSICP_FF102Ent
                       {
                           Id = ff102ent.Id,
                           Label = ff102ent.Label,
                       } : null,

                       NavFF102Sit = ff102sit != null ? new CSICP_FF102Sit
                       {
                           Id = ff102sit.Id,
                           Label = ff102sit.Label,
                       } : null,

                       NavFF102C018 = ff102C018 != null ? new CSICP_FF102_C018
                       {
                           Id = ff102C018.Id,
                           Label = ff102C018.Label,
                       } : null,

                       NavFF102G073 = ff102g073 != null ? new CSICP_FF102_G073
                       {
                           Id = ff102g073.Id,
                           Label = ff102g073.Label,
                       } : null,

                       NavFF102Cob = ff102cob != null ? new CSICP_FF102Cob
                       {
                           Id = ff102cob.Id,
                           Label = ff102cob.Label,
                       } : null,

                       NavFF102Aut = ff102Aut != null ? new CSICP_FF102Aut
                       {
                           Id = ff102Aut.Id,
                           Label = ff102Aut.Label,
                       } : null,

                       NavFF102ApiBanco = ff102Api != null ? new CSICP_FF102ApiBanco
                       {
                           Id = ff102Api.Id,
                           Label = ff102Api.Label,
                       } : null,

                       NavFF102Adt = ff102Adt != null ? new CSICP_FF102Adt
                       {
                           Id = ff102Adt.Id,
                           Label = ff102Adt.Label,
                       } : null,

                       NavFF112ApiOcorrencium = ff102OcorrenciaApi != null ? new CSICP_FF112ApiOcorrencium
                       {
                           Id = ff102OcorrenciaApi.Id,
                           Label = ff102OcorrenciaApi.Label,
                           CodgOcorrencia = ff102OcorrenciaApi.CodgOcorrencia,
                           BancoApi = ff102OcorrenciaApi.BancoApi,
                       } : null,

                       NavFF112ApiLiquidacao = ff102LiqApi != null ? new CSICP_FF112ApiLiquidacao
                       {
                           Id = ff102LiqApi.Id,
                           Label = ff102LiqApi.Label,
                           CodgLiquidacao = ff102LiqApi.CodgLiquidacao,
                           BancoApi = ff102LiqApi.BancoApi,
                       } : null,

                       NavFF112ApiBaixa = ff102BaixaApi != null ? new CSICP_FF112ApiBaixa
                       {
                           Id = ff102BaixaApi.Id,
                           Label = ff102BaixaApi.Label,
                           CodgBaixa = ff102BaixaApi.CodgBaixa,
                           BancoApi = ff102BaixaApi.BancoApi,
                       } : null,

                       NavFF120Trackapi = ff120track != null ? new CSICP_FF120TrackApi
                       {
                           Id = ff120track.Id,
                           Label = ff120track.Label,
                       } : null,

                       NavSy001Usuario = sy001UsuarioProp != null ? new Csicp_Sy001
                       {
                           TenantId = sy001UsuarioProp.TenantId,
                           Id = sy001UsuarioProp.Id,
                           Sy001Usuario = sy001UsuarioProp.Sy001Usuario,
                           Sy001Nome = sy001UsuarioProp.Sy001Nome,

                       } : null,

                       NavSy001CodCobrador = sy001CodCobrador != null ? new Csicp_Sy001
                       {
                           TenantId = sy001CodCobrador.TenantId,
                           Id = sy001CodCobrador.Id,
                           Sy001Usuario = sy001CodCobrador.Sy001Usuario,
                           Sy001Nome = sy001CodCobrador.Sy001Nome,
                       } : null,

                       NavSy001Aprovador = sy001Aprovador != null ? new Csicp_Sy001
                       {
                           TenantId = sy001Aprovador.TenantId,
                           Id = sy001Aprovador.Id,
                           Sy001Usuario = sy001Aprovador.Sy001Usuario,
                           Sy001Nome = sy001Aprovador.Sy001Nome,
                       } : null,

                       NavSy001CTBUsuarioID = sy001CtbUsuario != null ? new Csicp_Sy001
                       {
                           TenantId = sy001CtbUsuario.TenantId,
                           Id = sy001CtbUsuario.Id,
                           Sy001Usuario = sy001CtbUsuario.Sy001Usuario,
                           Sy001Nome = sy001CtbUsuario.Sy001Nome,
                       } : null,

                       NavSy001CTBEstUsuarioID = sy001CtbEstUsuarioID != null ? new Csicp_Sy001
                       {
                           TenantId = sy001CtbEstUsuarioID.TenantId,
                           Id = sy001CtbEstUsuarioID.Id,
                           Sy001Usuario = sy001CtbEstUsuarioID.Sy001Usuario,
                           Sy001Nome = sy001CtbEstUsuarioID.Sy001Nome,
                       } : null,

                       NavSy001CTLUsuarioID = sy001CtlUsuario != null ? new Csicp_Sy001
                       {
                           TenantId = sy001CtlUsuario.TenantId,
                           Id = sy001CtlUsuario.Id,
                           Sy001Usuario = sy001CtlUsuario.Sy001Usuario,
                           Sy001Nome = sy001CtlUsuario.Sy001Nome,
                       } : null,

                       NavSy001CTLEstUsuarioID = sy001CtlEstUsuario != null ? new Csicp_Sy001
                       {
                           TenantId = sy001CtlEstUsuario.TenantId,
                           Id = sy001CtlEstUsuario.Id,
                           Sy001Usuario = sy001CtlEstUsuario.Sy001Usuario,
                           Sy001Nome = sy001CtlEstUsuario.Sy001Nome,
                       } : null,

                       NavStaticaFluxoCaixa = staticaFluxoCaixa != null ? new CSICP_Statica
                       {
                           Id = staticaFluxoCaixa.Id,
                           Label = staticaFluxoCaixa.Label,
                           Tiporegistro = staticaFluxoCaixa.Tiporegistro,
                       } : null,

                       NavStaticaConfirmadoID = staticaConfirmado != null ? new CSICP_Statica
                       {
                           Id = staticaConfirmado.Id,
                           Label = staticaConfirmado.Label,
                           Tiporegistro = staticaConfirmado.Tiporegistro,
                       } : null,
                   };
        }

        public async Task<(List<RepoDtoCSICP_FF102>, int)> GetListAsync(int in_tenant, int in_pageNumber, int in_pageSize,
            string? in_estabelecimentoId,
            int in_tipoRegistro,
            string? in_prefixo,
            decimal? in_titulo,
            string? in_sufixo,
            string? in_nomeConta,
            int? in_situacaoId,
            int? in_codigoConta,
            int? in_TpCobranca,
            decimal? in_NoTitulonoBanco,
            string? in_serie,
            decimal? in_numeroNotaf,
            string? in_AgCobrador,
            string? in_centroCusto,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal,
            QualDataFiltro? in_tipoDataFiltro)
        {
            IQueryable<RepoDtoCSICP_FF102> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabelecimentoId, query,
                in_prefixo,
                in_titulo,
                in_sufixo,
                in_nomeConta,
                in_situacaoId,
                in_codigoConta,
                in_TpCobranca,
                in_NoTitulonoBanco,
                in_serie,
                in_numeroNotaf,
                in_AgCobrador,
                in_centroCusto,
                in_dataInicio,
                in_dataFinal,
                in_tipoDataFiltro);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<RepoDtoCSICP_FF102> FiltraQuandoExisteFiltro(string? in_estabelecimentoId,
            IQueryable<RepoDtoCSICP_FF102> query,
            string? in_prefixo,
            decimal? in_titulo,
            string? in_sufixo,
            string? in_nomeConta,
            int? in_situacaoId,
            int? in_codigoConta,
            int? in_TpCobranca,
            decimal? in_NoTitulonoBanco,
            string? in_serie,
            decimal? in_numeroNotaf,
            string? in_AgCobrador,
            string? in_centroCusto,
            DateTime? in_dataInicio,
            DateTime? in_dataFinal,
            QualDataFiltro? in_tipoDataFiltro)
        {
            if (in_estabelecimentoId != null)
                query = query.Where(e => e.Ff102Filialid!.Equals(in_estabelecimentoId));

            if (in_prefixo != null)
                query = query.Where(e => e.Ff102Pfx!.Equals(in_prefixo));

            if (in_titulo != null)
                query = query.Where(e => e.Ff102NoTitulo!.Equals(in_titulo));

            if (in_sufixo != null)
                query = query.Where(e => e.Ff102Sfx!.Equals(in_sufixo));

            if (in_nomeConta != null)
                query = query.Where(e => e.NavBB012!.Bb012NomeCliente!.Contains(in_nomeConta));

            if (in_situacaoId != null)
                query = query.Where(e => e.Ff102Situacaoid!.Equals(in_situacaoId));

            if (in_codigoConta != null)
                query = query.Where(e => e.NavBB012!.Bb012Codigo.Equals(in_codigoConta));

            if (in_TpCobranca != null)
                query = query.Where(e => e.Ff102Tpcobranca!.Equals(in_TpCobranca));

            if (in_NoTitulonoBanco != null)
                query = query.Where(e => e.Ff102NoTitulonobanco!.Equals(in_NoTitulonoBanco));

            if (in_serie != null)
                query = query.Where(e => e.Ff102SerieNf!.Equals(in_serie));

            if (in_numeroNotaf != null)
                query = query.Where(e => e.Ff102NumeroNf!.Equals(in_numeroNotaf));

            if (in_AgCobrador != null)
                query = query.Where(e => e.NavBB006!.Bb006Banco!.Equals(in_AgCobrador));

            if (in_centroCusto != null)
                query = query.Where(e => e.NavBB005!.Bb005Nomeccusto!.Equals(in_centroCusto));

            if (in_tipoDataFiltro == QualDataFiltro.Emissao && in_dataInicio.HasValue && in_dataFinal.HasValue)
                query = query.Where(e => e.Ff102DataEmissao >= in_dataInicio && e.Ff102DataEmissao <= in_dataFinal);

            if (in_tipoDataFiltro == QualDataFiltro.Vencimento && in_dataInicio.HasValue && in_dataFinal.HasValue)
                query = query.Where(e => e.Ff102DataVencimento >= in_dataInicio && e.Ff102DataVencimento <= in_dataFinal);

            if (in_tipoDataFiltro == QualDataFiltro.UltimaBaixa && in_dataInicio.HasValue && in_dataFinal.HasValue)
                query = query.Where(e => e.Ff102DataUltPagto >= in_dataInicio && e.Ff102DataUltPagto <= in_dataFinal);
            //Emissao = 1, Vencimento = 2, UltimaBaixa = 3

            return query;
        }
    }
}
