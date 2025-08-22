using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD._04X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.EnviaNFeHercules.Repository.DD04X
{
    public class DD040RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_DD040>(appDbContext, "Dd040Id"), IDD040Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<RepoDtoCSICP_DD040?> GetByIdAsync(int in_tenant, string in_dd040Id)
        {
            IQueryable<RepoDtoCSICP_DD040> query = GetQueryBase(in_tenant);
            RepoDtoCSICP_DD040? cSICP_DD040 = await query.FirstOrDefaultAsync(e => e.Dd040Id == in_dd040Id);
            return cSICP_DD040;
        }

   
        public async Task<List<CSICP_BB001_AXML>> GetListAsyncBB001AXML(int in_tenant, string? in_bb001Id)
        {
            IQueryable<CSICP_BB001_AXML> query = _appDbContext.E9ACSICP_BB001Axmls
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Bb001aEstabid == in_bb001Id);
            return await query.ToListAsync();
        }

        private IQueryable<RepoDtoCSICP_DD040> GetQueryBase(int in_tenant)
        {
            return from dd040 in _appDbContext.OsusrTeiCsicpDd040s
                   where dd040.TenantId == in_tenant

                   join bb001 in _appDbContext.E9ACSICP_BB001s
                   on dd040.Dd040Empresaid equals bb001.Id into bb001_dd040_join
                   from bb001 in bb001_dd040_join.DefaultIfEmpty()

                   join aa028 in _appDbContext.OsusrE9aCsicpAa028s
                   on bb001.Cidadeid equals aa028.Id into aa028_bb001_join
                   from aa028 in aa028_bb001_join.DefaultIfEmpty()

                   join aa027 in _appDbContext.OsusrE9aCsicpAa027s
                   on aa028.Ufid equals aa027.Id into aa027_aa028_join
                   from aa027 in aa027_aa028_join.DefaultIfEmpty()

                   join aa025 in _appDbContext.OsusrE9aCsicpAa025s
                   on aa027.Paisid equals aa025.Id into aa025_aa027_join
                   from aa025 in aa025_aa027_join.DefaultIfEmpty()

                   join dd040Tnt in _appDbContext.OsusrTeiCsicpDd040Tnts
                   on dd040.Dd040TiponotaId equals dd040Tnt.Id into dd040Tnt_dd040_join
                   from dd040Tnt in dd040Tnt_dd040_join.DefaultIfEmpty()

                   join bb001CfgFis in _appDbContext.E9ACSICP_BB001Cfgfis
                   on bb001.Id equals bb001CfgFis.Bb001EmpresaId into bb001CfgFis_bb001_join
                   from bb001CfgFis in bb001CfgFis_bb001_join.DefaultIfEmpty()

                   join spedIcms in _appDbContext.OsusrNnxSpedInDocIcms
                   on dd040.Dd040ModId equals spedIcms.Id into spedIcms_dd040_join
                   from spedIcms in spedIcms_dd040_join.DefaultIfEmpty()

                   join aa030Regime in _appDbContext.E9ACSICP_AA030Regimes
                   on bb001CfgFis.Bb001Regimetributarioid equals aa030Regime.Id into aa030Regime_bb001CfgFis_join
                   from aa030Regime in aa030Regime_bb001CfgFis_join.DefaultIfEmpty()

                   join dd909 in _appDbContext.OsusrTeiCsicpDd909s
                   on dd040.Dd040Tpemis equals dd909.Id into dd909_dd040_join
                   from dd909 in dd909_dd040_join.DefaultIfEmpty()

                   join dd040IPres in _appDbContext.OsusrTeiCsicpDd040Ipres
                   on dd040.Dd040Indpres equals dd040IPres.Id into dd040IPres_dd040_join
                   from dd040IPres in dd040IPres_dd040_join.DefaultIfEmpty()

                   join dd041Frete in _appDbContext.OsusrTeiCsicpDd041Fretes
                   on dd040.Dd040Modalidadefrete equals dd041Frete.Id into dd041Frete_dd040_join
                   from dd041Frete in dd041Frete_dd040_join.DefaultIfEmpty()

                   select new RepoDtoCSICP_DD040
                   {
                       TenantId = dd040.TenantId,
                       Dd040Id = dd040.Dd040Id,
                       Dd040Empresaid = dd040.Dd040Empresaid,
                       Dd042Chaveacessonfe = dd040.Dd042Chaveacessonfe,
                       Dd040Filial = dd040.Dd040Filial,
                       Dd040TipoMovimento = dd040.Dd040TipoMovimento,
                       Dd040Serie = dd040.Dd040Serie,
                       Dd040NoNf = dd040.Dd040NoNf,
                       Dd040NoPedido = dd040.Dd040NoPedido,
                       Dd040NoEstacao = dd040.Dd040NoEstacao,
                       Dd040NoPdv = dd040.Dd040NoPdv,
                       Dd040SerieCupom = dd040.Dd040SerieCupom,
                       Dd040NoCupom = dd040.Dd040NoCupom,
                       Dd040DataEmissao = dd040.Dd040DataEmissao,
                       Dd040Datahoraemissao = dd040.Dd040Datahoraemissao,
                       Dd040ContaId = dd040.Dd040ContaId,
                       Dd040ContarealId = dd040.Dd040ContarealId,
                       Dd040AvalistaId = dd040.Dd040AvalistaId,
                       Dd040CcustoId = dd040.Dd040CcustoId,
                       Dd040AgcobradorId = dd040.Dd040AgcobradorId,
                       Dd040CondPagtoId = dd040.Dd040CondPagtoId,
                       Dd040ResponsavelId = dd040.Dd040ResponsavelId,
                       Dd040NatoperacaoId = dd040.Dd040NatoperacaoId,
                       Dd040AlmoxdestinoId = dd040.Dd040AlmoxdestinoId,
                       Dd040CodgCcusto = dd040.Dd040CodgCcusto,
                       Dd040CodgAgcobrador = dd040.Dd040CodgAgcobrador,
                       Dd040CodgCondPagto = dd040.Dd040CodgCondPagto,
                       Dd040Codrespvendedor = dd040.Dd040Codrespvendedor,
                       Dd040Codrespcomprador = dd040.Dd040Codrespcomprador,
                       Dd040Codnatoperacao = dd040.Dd040Codnatoperacao,
                       Dd040Codalmoxdestino = dd040.Dd040Codalmoxdestino,
                       Dd040Perc1Desconto = dd040.Dd040Perc1Desconto,
                       Dd040Perc2Desconto = dd040.Dd040Perc2Desconto,
                       Dd040Perc3Desconto = dd040.Dd040Perc3Desconto,
                       Dd040Perc4Desconto = dd040.Dd040Perc4Desconto,
                       Dd040Perc5Desconto = dd040.Dd040Perc5Desconto,
                       Dd040TotalDescsuframa = dd040.Dd040TotalDescsuframa,
                       Dd040TotalBruto = dd040.Dd040TotalBruto,
                       Dd040TotalFrete = dd040.Dd040TotalFrete,
                       Dd040FreteCifFob = dd040.Dd040FreteCifFob,
                       Dd040TotalSeguro = dd040.Dd040TotalSeguro,
                       Dd040TotalOutdespesas = dd040.Dd040TotalOutdespesas,
                       Dd040Desconto = dd040.Dd040Desconto,
                       Dd040Acrescimo = dd040.Dd040Acrescimo,
                       Dd040TotalLiquido = dd040.Dd040TotalLiquido,
                       Dd040TotalServico = dd040.Dd040TotalServico,
                       Dd040Percdescservico = dd040.Dd040Percdescservico,
                       Dd040Vlrdescservico = dd040.Dd040Vlrdescservico,
                       Dd040Totliqservico = dd040.Dd040Totliqservico,
                       Dd040TotalprodEServ = dd040.Dd040TotalprodEServ,
                       Dd040ValorEntrada = dd040.Dd040ValorEntrada,
                       Dd040QtdeParcelas = dd040.Dd040QtdeParcelas,
                       Dd040Vlrafinanciar = dd040.Dd040Vlrafinanciar,
                       Dd040Texto = dd040.Dd040Texto,
                       Dd040QtdVolumes = dd040.Dd040QtdVolumes,
                       Dd040Especie = dd040.Dd040Especie,
                       Dd040Marca = dd040.Dd040Marca,
                       Dd040Nvol = dd040.Dd040Nvol,
                       Dd040PesoLiquido = dd040.Dd040PesoLiquido,
                       Dd040PesoBruto = dd040.Dd040PesoBruto,
                       Dd040DataSaida = dd040.Dd040DataSaida,
                       Dd040HoraSaida = dd040.Dd040HoraSaida,
                       Dd040Codtabelapreco = dd040.Dd040Codtabelapreco,
                       Dd040NumeroPreco = dd040.Dd040NumeroPreco,
                       Dd040UsuarioImp = dd040.Dd040UsuarioImp,
                       Dd040DataImpressao = dd040.Dd040DataImpressao,
                       Dd040HoraImpressao = dd040.Dd040HoraImpressao,
                       Dd040NumImpressoes = dd040.Dd040NumImpressoes,
                       Dd040NroContrato = dd040.Dd040NroContrato,
                       Dd040NroRomaneio = dd040.Dd040NroRomaneio,
                       Dd040Empenho = dd040.Dd040Empenho,
                       Dd040Processo = dd040.Dd040Processo,
                       Dd040NoRequisicao = dd040.Dd040NoRequisicao,
                       Dd040Comissao = dd040.Dd040Comissao,
                       Dd040DataMovimento = dd040.Dd040DataMovimento,
                       Dd040Situacao = dd040.Dd040Situacao,
                       Dd040PrazoEntrega = dd040.Dd040PrazoEntrega,
                       Dd040CiOrcamento = dd040.Dd040CiOrcamento,
                       Dd040CodgAtendente = dd040.Dd040CodgAtendente,
                       Dd040UsuarioAtendenteid = dd040.Dd040UsuarioAtendenteid,
                       Dd040UsuarioProprId = dd040.Dd040UsuarioProprId,
                       Dd040ClassecontaId = dd040.Dd040ClassecontaId,
                       Dd040StatusEstoqueId = dd040.Dd040StatusEstoqueId,
                       Dd040Vbc = dd040.Dd040Vbc,
                       Dd040Vicms = dd040.Dd040Vicms,
                       Dd040Vicmsdeson = dd040.Dd040Vicmsdeson,
                       Dd040Vicmsufdest = dd040.Dd040Vicmsufdest,
                       Dd040Vicmsufremet = dd040.Dd040Vicmsufremet,
                       Dd040Vfcpufdest = dd040.Dd040Vfcpufdest,
                       Dd040Vbcst = dd040.Dd040Vbcst,
                       Dd040Vst = dd040.Dd040Vst,
                       Dd040Vii = dd040.Dd040Vii,
                       Dd040Vipi = dd040.Dd040Vipi,
                       Dd040Vpis = dd040.Dd040Vpis,
                       Dd040Vcofins = dd040.Dd040Vcofins,
                       Dd040Vfcp = dd040.Dd040Vfcp,
                       Dd040Vfcpst = dd040.Dd040Vfcpst,
                       Dd040Vfcpstret = dd040.Dd040Vfcpstret,
                       Dd040Vipidevol = dd040.Dd040Vipidevol,
                       Dd040TotValorAproxImp = dd040.Dd040TotValorAproxImp,
                       Dd040ServVcofins = dd040.Dd040ServVcofins,
                       Dd040ServVbc = dd040.Dd040ServVbc,
                       Dd040ServViss = dd040.Dd040ServViss,
                       Dd040ServVpis = dd040.Dd040ServVpis,
                       Dd040ServDcompet = dd040.Dd040ServDcompet,
                       Dd040ServVissret = dd040.Dd040ServVissret,
                       Dd040ServVoutro = dd040.Dd040ServVoutro,
                       Dd040ServVdescincond = dd040.Dd040ServVdescincond,
                       Dd040ServVdesccond = dd040.Dd040ServVdesccond,
                       Dd040ServCregtrib = dd040.Dd040ServCregtrib,
                       Dd040OrigemNota = dd040.Dd040OrigemNota,
                       Dd040Status = dd040.Dd040Status,
                       Dd040NfEntregueSn = dd040.Dd040NfEntregueSn,
                       Dd040Alfa50 = dd040.Dd040Alfa50,
                       Dd040Isorigemdecupom = dd040.Dd040Isorigemdecupom,
                       Dd040Isgrupada = dd040.Dd040Isgrupada,
                       Dd040Valor1 = dd040.Dd040Valor1,
                       Dd040Valor2 = dd040.Dd040Valor2,
                       Dd040Valor3 = dd040.Dd040Valor3,
                       Dd040Valor4 = dd040.Dd040Valor4,
                       Dd040Valor5 = dd040.Dd040Valor5,
                       Dd040SitNfeId = dd040.Dd040SitNfeId,
                       Dd040TiponotaId = dd040.Dd040TiponotaId,
                       Dd040ModId = dd040.Dd040ModId,
                       Dd040CtrlSerieNfId = dd040.Dd040CtrlSerieNfId,
                       NfeNprot = dd040.NfeNprot,
                       NfeNrec = dd040.NfeNrec,
                       NfeEpecNprot = dd040.NfeEpecNprot,
                       Dd040DispId = dd040.Dd040DispId,
                       Dd040Numeroautorizacao = dd040.Dd040Numeroautorizacao,
                       Dd040CompContaId = dd040.Dd040CompContaId,
                       Dd040Protocolnumber = dd040.Dd040Protocolnumber,
                       Dd040Indpres = dd040.Dd040Indpres,
                       Dd040Tpemis = dd040.Dd040Tpemis,
                       Dd040Finnfe = dd040.Dd040Finnfe,
                       Dd040Dhcont = dd040.Dd040Dhcont,
                       Dd040Xjust = dd040.Dd040Xjust,
                       Dd040Tpamb = dd040.Dd040Tpamb,
                       Dd040Tzd = dd040.Dd040Tzd,
                       Dd040Dhaut = dd040.Dd040Dhaut,
                       Dd040Digval = dd040.Dd040Digval,
                       Dd040Urlqrcode = dd040.Dd040Urlqrcode,
                       Dd040Arquitetoid = dd040.Dd040Arquitetoid,
                       Dd040Natop = dd040.Dd040Natop,
                       Dd040Transcomtef = dd040.Dd040Transcomtef,
                       Dd040Modalidadefrete = dd040.Dd040Modalidadefrete,
                       Dd040Islibentregaliq = dd040.Dd040Islibentregaliq,
                       Dd040CtbIscontabilizadoid = dd040.Dd040CtbIscontabilizadoid,
                       Dd040CtbUsuarioid = dd040.Dd040CtbUsuarioid,
                       Dd040CtbDtregistro = dd040.Dd040CtbDtregistro,
                       Dd040CtbIsestornadoid = dd040.Dd040CtbIsestornadoid,
                       Dd040CtbEstusuarioid = dd040.Dd040CtbEstusuarioid,
                       Dd040CtbEstdtreg = dd040.Dd040CtbEstdtreg,
                       Dd040CtbIdlancto = dd040.Dd040CtbIdlancto,
                       Dd040CtbMsg = dd040.Dd040CtbMsg,
                       Dd040UsuarioEntregaid = dd040.Dd040UsuarioEntregaid,
                       Dd040Dhentrega = dd040.Dd040Dhentrega,
                       Dd040SatChaveCanc = dd040.Dd040SatChaveCanc,
                       Dd040SatSerieCanc = dd040.Dd040SatSerieCanc,
                       Dd040SatNoCfeCanc = dd040.Dd040SatNoCfeCanc,
                       Dd040SatQrcodeCanc = dd040.Dd040SatQrcodeCanc,
                       Dd040DhCanc = dd040.Dd040DhCanc,
                       Dd040Islocksat = dd040.Dd040Islocksat,
                       Dd040Romaneioid = dd040.Dd040Romaneioid,
                       Dd040Motdesoneracaoid = dd040.Dd040Motdesoneracaoid,
                       Dd040Picmsdesonerado = dd040.Dd040Picmsdesonerado,
                       Dd040VicmsdesonsubId = dd040.Dd040VicmsdesonsubId,
                       Dd040Usuariofaturistaid = dd040.Dd040Usuariofaturistaid,
                       Dd040CorreiosCodRastreio = dd040.Dd040CorreiosCodRastreio,
                       Dd040CorreiosSiglaTriagem = dd040.Dd040CorreiosSiglaTriagem,
                       Dd040CorreiosDetalhe = dd040.Dd040CorreiosDetalhe,
                       Dd040Isvendaonline = dd040.Dd040Isvendaonline,
                       Dd040Modentregaid = dd040.Dd040Modentregaid,
                       Dd040StEntregaId = dd040.Dd040StEntregaId,
                       Dd040CnpjMarketplace = dd040.Dd040CnpjMarketplace,
                       Dd040Marketplace = dd040.Dd040Marketplace,
                       Dd040Chavecashback = dd040.Dd040Chavecashback,
                       W06b1Qbcmono = dd040.W06b1Qbcmono,
                       W06cVicmsmono = dd040.W06cVicmsmono,
                       W06c1Qbcmonoreten = dd040.W06c1Qbcmonoreten,
                       W06dVicmsmonoreten = dd040.W06dVicmsmonoreten,
                       W06d1Qbcmonoret = dd040.W06d1Qbcmonoret,
                       W06eVicmsmonoret = dd040.W06eVicmsmonoret,
                       Dd040Origemregpv = dd040.Dd040Origemregpv,
                       Dd040Keyecommerce = dd040.Dd040Keyecommerce,

                       NavBB001 = bb001 != null ? new CSICP_BB001
                       {
                           TenantId = bb001.TenantId,
                           Id = bb001.Id,
                           Bb001Codigoempresa = bb001.Bb001Codigoempresa,
                           Bb001Razaosocial = bb001.Bb001Razaosocial,
                           Bb001Endereco = bb001.Bb001Endereco,
                           Bb001Complemento = bb001.Bb001Complemento,
                           Bb001Numresidencial = bb001.Bb001Numresidencial,
                           Bb001Bairro = bb001.Bb001Bairro,
                           Bb001Cep = bb001.Bb001Cep,
                           Bb001Cnpj = bb001.Bb001Cnpj,
                           Bb001Inscestadual = bb001.Bb001Inscestadual,
                           Bb001Inscjunta = bb001.Bb001Inscjunta,
                           Bb001Datainscricao = bb001.Bb001Datainscricao,
                           Bb001Nomefantasia = bb001.Bb001Nomefantasia,
                           Bb001Telefone = bb001.Bb001Telefone,
                           Bb001Fax = bb001.Bb001Fax,
                           Bb001Slogamempresa1 = bb001.Bb001Slogamempresa1,
                           Bb001Slogamempresa2 = bb001.Bb001Slogamempresa2,
                           Bb001Email = bb001.Bb001Email,
                           Bb001Homepage = bb001.Bb001Homepage,
                           Bb001Ramoempresa = bb001.Bb001Ramoempresa,
                           Bb002Grupoempresa = bb001.Bb002Grupoempresa,
                           Bb001Codgclienteaux = bb001.Bb001Codgclienteaux,
                           Bb001Almoxpadrao = bb001.Bb001Almoxpadrao,
                           Bb001Almoxtransfer = bb001.Bb001Almoxtransfer,
                           Bb001Bddistribuida = bb001.Bb001Bddistribuida,
                           Bb001Cnaefiscal = bb001.Bb001Cnaefiscal,
                           Bb001Suframaemp = bb001.Bb001Suframaemp,
                           Bb001Inscmunicipal = bb001.Bb001Inscmunicipal,
                           Bb001Paisid = bb001.Bb001Paisid,
                           Cidadeid = bb001.Cidadeid,
                           Bb001Ufid = bb001.Bb001Ufid,
                           Bb001Nomeoficial = bb001.Bb001Nomeoficial,
                           Bb001CpfOficial = bb001.Bb001CpfOficial,
                           Bb001Codgcartorio = bb001.Bb001Codgcartorio,
                           Bb001Nomesubstituto = bb001.Bb001Nomesubstituto,
                           Bb001Descricaooficial = bb001.Bb001Descricaooficial,
                           Bb001Capitalmunicipio = bb001.Bb001Capitalmunicipio,
                           Bb001Cor1Hexa = bb001.Bb001Cor1Hexa,
                           Bb001Cor2Hexa = bb001.Bb001Cor2Hexa,
                           Bb001IdiomaId = bb001.Bb001IdiomaId,
                           Bb001Isactive = bb001.Bb001Isactive,
                           Bb001Token = bb001.Bb001Token,
                           Bb001Usuariosirc = bb001.Bb001Usuariosirc,
                           Bb001Senhasirc = bb001.Bb001Senhasirc,
                           Bb001Tenantfiscal = bb001.Bb001Tenantfiscal,
                           Bb001TokenEsitef = bb001.Bb001TokenEsitef,
                           Bb001UrlGoogleplay = bb001.Bb001UrlGoogleplay,
                           Bb001UrlAppstore = bb001.Bb001UrlAppstore,
                           Bb001Cix = bb001.Bb001Cix,
                           Bb001ChaveApl = bb001.Bb001ChaveApl,
                           Bb001AutToken = bb001.Bb001AutToken,
                           Bb001TokenCspix = bb001.Bb001TokenCspix,
                       } : null,

                       NavAA028byBB001 = aa028 != null ? new CSICP_Aa028
                       {
                           TenantId = aa028.TenantId,
                           Id = aa028.Id,
                           Aa028Cidade = aa028.Aa028Cidade,
                           Aa028Percicmscontrib = aa028.Aa028Percicmscontrib,
                           A028Percicmsncontrib = aa028.A028Percicmsncontrib,
                           A028Percsubsttribut = aa028.A028Percsubsttribut,
                           A028Mascinsestadual = aa028.A028Mascinsestadual,
                           A028Percicmsentrada = aa028.A028Percicmsentrada,
                           A028Mascieimpressao = aa028.A028Mascieimpressao,
                           Aa028Codgibge = aa028.Aa028Codgibge,
                           Aa028Zonafranca = aa028.Aa028Zonafranca,
                           Aa028Estadobrasil = aa028.Aa028Estadobrasil,
                           Ufid = aa028.Ufid,
                           Aa028ExportCidadeid = aa028.Aa028ExportCidadeid,
                           Aa027ExportUfid = aa028.Aa027ExportUfid,
                       } : null,

                       NavAA027byBB001 = aa027 != null ? new CSICP_Aa027
                       {
                           TenantId = aa027.TenantId,
                           Id = aa027.Id,
                           Aa027Sigla = aa027.Aa027Sigla,
                           Descricao = aa027.Descricao,
                           Aa027Percicmscontrib = aa027.Aa027Percicmscontrib,
                           Aa027Percicmsncontrib = aa027.Aa027Percicmsncontrib,
                           Aa027Percsubsttribut = aa027.Aa027Percsubsttribut,
                           Aa027Mascinsestadual = aa027.Aa027Mascinsestadual,
                           Aa027Percicmsentrada = aa027.Aa027Percicmsentrada,
                           Aa027Mascieimpressao = aa027.Aa027Mascieimpressao,
                           Aa027Codigoibge = aa027.Aa027Codigoibge,
                           Paisid = aa027.Paisid,
                           Regiaoid = aa027.Regiaoid,
                           Aa027Naturalidade = aa027.Aa027Naturalidade,
                           Aa027ExportUfid = aa027.Aa027ExportUfid,
                           Aa025ExportPaisid = aa027.Aa025ExportPaisid,
                           Aa026ExportRegiaoid = aa027.Aa026ExportRegiaoid,
                       } : null,

                       NavAA025byBB001 = aa025 != null ? new CSICP_Aa025
                       {
                           TenantId = aa025.TenantId,
                           Id = aa025.Id,
                           Aa025Codigopais = aa025.Aa025Codigopais,
                           Aa025Descricao = aa025.Aa025Descricao,
                           Aa025Codigobacen = aa025.Aa025Codigobacen,
                           Aa025Codigosiscomex = aa025.Aa025Codigosiscomex,
                           Aa025Isactive = aa025.Aa025Isactive,
                           Aa025Nacionalidade = aa025.Aa025Nacionalidade,
                           Aa025Iso3166A2 = aa025.Aa025Iso3166A2,
                           Aa025Iso3166A3 = aa025.Aa025Iso3166A3,
                           Aa025Iso3166N3 = aa025.Aa025Iso3166N3,
                           Aa025ExportPaisid = aa025.Aa025ExportPaisid,
                           Aa025CodigoNacoesunidas = aa025.Aa025CodigoNacoesunidas,
                       } : null,

                       NavDD040Tnt = dd040Tnt != null ? new CSICP_DD040Tnt
                       {
                           Id = dd040Tnt.Id,
                           Label = dd040Tnt.Label,
                           Order = dd040Tnt.Order,
                           Finalidadeemissao = dd040Tnt.Finalidadeemissao,
                           Tipooperacao = dd040Tnt.Tipooperacao,
                           IsActive = dd040Tnt.IsActive,
                           CsCodg = dd040Tnt.CsCodg,
                       } : null,

                       NavBB001Cfgfi = bb001CfgFis != null ? new CSICP_BB001Cfgfi
                       {
                           TenantId = bb001CfgFis.TenantId,
                           Bb001CfgId = bb001CfgFis.Bb001CfgId,
                           Bb001EmpresaId = bb001CfgFis.Bb001EmpresaId,
                           Bb001TptributacaoId = bb001CfgFis.Bb001TptributacaoId,
                           Bb001PercIcms = bb001CfgFis.Bb001PercIcms,
                           Bb001PercCsllBc = bb001CfgFis.Bb001PercCsllBc,
                           Bb001PercCsllBcServico = bb001CfgFis.Bb001PercCsllBcServico,
                           Bb001PercIrpjBc = bb001CfgFis.Bb001PercIrpjBc,
                           Bb001PercIrpjBcServico = bb001CfgFis.Bb001PercIrpjBcServico,
                           Bb001NaturezapjId = bb001CfgFis.Bb001NaturezapjId,
                           Bb001TpatividadeId = bb001CfgFis.Bb001TpatividadeId,
                           Bb001Regimetributarioid = bb001CfgFis.Bb001Regimetributarioid,
                       } : null,

                       NavSpedIcm = spedIcms != null ? new OsusrNnxSpedInDocIcm
                       {
                           Id = spedIcms.Id,
                           Label = spedIcms.Label,
                           Codigo = spedIcms.Codigo,
                           Order = spedIcms.Order,
                           IsActive = spedIcms.IsActive,
                           Cupom = spedIcms.Cupom,
                           Docfiscal = spedIcms.Docfiscal,
                       } : null,

                       NavAA030Regime = aa030Regime != null ? new CSICP_AA030Regime
                       {
                           Id = aa030Regime.Id,
                           Label = aa030Regime.Label,
                           Order = aa030Regime.Order,
                           IsActive = aa030Regime.IsActive,
                           CrtDigito = aa030Regime.CrtDigito,
                       } : null,

                       NavDD909 = dd909 != null ? new CSICP_DD909
                       {
                           Id = dd909.Id,
                           Label = dd909.Label,
                           Order = dd909.Order,
                           IsActive = dd909.IsActive,
                           CodgFiscal = dd909.CodgFiscal,
                       } : null,

                       NavDD040Ipre = dd040IPres != null ? new CSICP_DD040Ipre
                       {
                           Id = dd040IPres.Id,
                           Label = dd040IPres.Label,
                           Order = dd040IPres.Order,
                           IsActive = dd040IPres.IsActive,
                           Indpres = dd040IPres.Indpres,
                       } : null,

                       NavDD041Frete = dd041Frete != null ? new CSICP_DD041Frete
                       {
                           Id = dd041Frete.Id,
                           Label = dd041Frete.Label,
                           Order = dd041Frete.Order,
                           IsActive = dd041Frete.IsActive,
                           CodigoSefaz = dd041Frete.CodigoSefaz,
                       } : null
                   };
        }


        public async Task<List<RepoCSICP_DD042>> GetListAsyncDD042(int in_tenant, string in_dd040Id)
        {
            var query = from dd042 in _appDbContext.OsusrTeiCsicpDd042s

                        where dd042.TenantId == in_tenant
                        && dd042.Dd040Id == in_dd040Id

                        join bb026 in _appDbContext.OsusrE9aCsicpBb026s
                        on dd042.Dd042Fpagtoid equals bb026.Id into bb026_join
                        from bb026 in bb026_join.DefaultIfEmpty()

                        join bb026Class in _appDbContext.OsusrE9aCsicpBb026Classes
                        on bb026.Bb026ClasseId equals bb026Class.Id into bb026Class_join
                        from bb026Class in bb026Class_join.DefaultIfEmpty()

                        let listdd043 = (from dd043 in _appDbContext.OsusrTeiCsicpDd043s
                                         where dd043.TenantId == in_tenant && dd043.Dd042Id == dd042.Dd042Id
                                         select dd043).ToList()

                        select new RepoCSICP_DD042
                        {
                            TenantId = dd042.TenantId,
                            Dd042Id = dd042.Dd042Id,
                            Dd040Id = dd042.Dd040Id,
                            Dd042Fpagtoid = dd042.Dd042Fpagtoid,
                            Dd042ValorPago = dd042.Dd042ValorPago,
                            Dd042Qtd = dd042.Dd042Qtd,
                            Dd042ValorTotalpago = dd042.Dd042ValorTotalpago,
                            Dd042ValorTroco = dd042.Dd042ValorTroco,
                            Dd042Condicaoid = dd042.Dd042Condicaoid,
                            Dd042Nroparcelas = dd042.Dd042Nroparcelas,
                            Dd042Valor1aparcela = dd042.Dd042Valor1aparcela,
                            Dd042Administradoraid = dd042.Dd042Administradoraid,
                            Dd042Filial = dd042.Dd042Filial,
                            Dd042Ci = dd042.Dd042Ci,
                            Dd042FormaPagto = dd042.Dd042FormaPagto,
                            Dd042DataMovimento = dd042.Dd042DataMovimento,
                            Dd042Operador = dd042.Dd042Operador,
                            Dd042Regtransferido = dd042.Dd042Regtransferido,
                            Dd042ChaveVincId = dd042.Dd042ChaveVincId,
                            Dd042Produtoservico = dd042.Dd042Produtoservico,
                            Dd042Cnsu = dd042.Dd042Cnsu,
                            Dd042Cdatamovimento = dd042.Dd042Cdatamovimento,
                            Dd042Cpv = dd042.Dd042Cpv,
                            Dd042Cdoc = dd042.Dd042Cdoc,
                            Dd042Caut = dd042.Dd042Caut,
                            Dd042Perccomissao = dd042.Dd042Perccomissao,
                            Dd042Valorcomissao = dd042.Dd042Valorcomissao,
                            Dd042Cnsuctf = dd042.Dd042Cnsuctf,
                            Dd042Cautorizadora = dd042.Dd042Cautorizadora,
                            Dd042Cvanctf = dd042.Dd042Cvanctf,
                            Dd042Cinstituicaoctf = dd042.Dd042Cinstituicaoctf,
                            Dd042Cnsucanc = dd042.Dd042Cnsucanc,
                            Dd042Cdatacanc = dd042.Dd042Cdatacanc,
                            Dd042RetCompestab = dd042.Dd042RetCompestab,
                            Dd042RetCompcliente = dd042.Dd042RetCompcliente,
                            Dd042RetCompcanc = dd042.Dd042RetCompcanc,
                            Dd042Nrotitulo = dd042.Dd042Nrotitulo,
                            Dd042Fatoracresc = dd042.Dd042Fatoracresc,
                            NavDD043 = listdd043,

                            NavBB026 = bb026 != null ? new CSICP_Bb026
                            {
                                TenantId = bb026.TenantId,
                                Id = bb026.Id,
                                Empresaid = bb026.Empresaid,
                                Bb026Filial = bb026.Bb026Filial,
                                Bb026Codigo = bb026.Bb026Codigo,
                                Bb026Formapagamento = bb026.Bb026Formapagamento,
                                Bb026Dadoschequesn = bb026.Bb026Dadoschequesn,
                                Bb026Dadoscartaosn = bb026.Bb026Dadoscartaosn,
                                Bb026Vinccupomfiscal = bb026.Bb026Vinccupomfiscal,
                                Bb026Classificacao = bb026.Bb026Classificacao,
                                Bb026Crplanocontaid = bb026.Bb026Crplanocontaid,
                                Bb026Dbplanocontaid2 = bb026.Bb026Dbplanocontaid2,
                                Bb026NroAutenticacoes = bb026.Bb026NroAutenticacoes,
                                Bb026ValorMinimo = bb026.Bb026ValorMinimo,
                                Bb026ValorMaximo = bb026.Bb026ValorMaximo,
                                Bb026TrocoMaximo = bb026.Bb026TrocoMaximo,
                                Bb026Pontosangria = bb026.Bb026Pontosangria,
                                Bb026Tipo = bb026.Bb026Tipo,
                                Bb026Parcelapordepto = bb026.Bb026Parcelapordepto,
                                Bb026Condpagtofixoid = bb026.Bb026Condpagtofixoid,
                                Bb026Administradoraid = bb026.Bb026Administradoraid,
                                Bb026UtilizaPinpad = bb026.Bb026UtilizaPinpad,
                                Bb026Consultacheque = bb026.Bb026Consultacheque,
                                Bb026Impressaocheque = bb026.Bb026Impressaocheque,
                                Bb026Chequebompara = bb026.Bb026Chequebompara,
                                Bb026Solicitaemitente = bb026.Bb026Solicitaemitente,
                                Bb026Solicitaqtd = bb026.Bb026Solicitaqtd,
                                Bb026Solicitacondpagto = bb026.Bb026Solicitacondpagto,
                                Bb026Aceitapagto = bb026.Bb026Aceitapagto,
                                Bb026Aceitarecebimento = bb026.Bb026Aceitarecebimento,
                                Bb026Permitetroco = bb026.Bb026Permitetroco,
                                Bb026Sangriaautomatica = bb026.Bb026Sangriaautomatica,
                                Bb026Naoabregaveta = bb026.Bb026Naoabregaveta,
                                Bb026TipovinculoId = bb026.Bb026TipovinculoId,
                                Bb026Isactive = bb026.Bb026Isactive,
                                Bb026ClasseId = bb026.Bb026ClasseId,
                                Bb026EspecieId = bb026.Bb026EspecieId,
                                Bb026Meiopagtoimpfiscal = bb026.Bb026Meiopagtoimpfiscal,
                                Bb026Tipoespecie = bb026.Bb026Tipoespecie,
                                Bb026Pcomissaovend = bb026.Bb026Pcomissaovend,
                                Bb026Aceitavpresente = bb026.Bb026Aceitavpresente,
                                Bb026Capturarecebpvpdv = bb026.Bb026Capturarecebpvpdv,
                                Bb026Islibentregaliq = bb026.Bb026Islibentregaliq,
                                Bb026Isaplicaaprovcond = bb026.Bb026Isaplicaaprovcond,
                                Bb026Isagrupa = bb026.Bb026Isagrupa,
                            } : null,

                            NavBb026Classe = bb026Class != null ? new CSICP_Bb026Classe
                            {
                                Id = bb026Class.Id,
                                Label = bb026Class.Label,
                                Imagem = bb026Class.Imagem,
                                Order = bb026Class.Order,
                                IsActive = bb026Class.IsActive,
                                Tpag = bb026Class.Tpag,
                                Usocs = bb026Class.Usocs,
                                UrlFormapagto = bb026Class.UrlFormapagto,
                            } : null

                        };
            return await query.ToListAsync();
        }
        public async Task<List<CSICP_DD044>> GetListAsyncDD044InfoAdicionais(int in_tenant, string in_dd040Id)
        {
            IQueryable<CSICP_DD044> query = _appDbContext.OsusrTeiCsicpDd044s
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Dd040Id == in_dd040Id);
            return await query.ToListAsync();
        }
        public async Task<List<CSICP_DD045>> GetListAsyncDD045Observacoes(int in_tenant, string in_dd040Id)
        {
            IQueryable<CSICP_DD045> query = _appDbContext.OsusrTeiCsicpDd045s
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Dd040Id == in_dd040Id);
            return await query.ToListAsync();
        }

        public async Task<List<CSICP_DD048>> GetListAsyncDD048NotasReferenciadas(int in_tenant, string in_dd040Id)
        {
            IQueryable<CSICP_DD048> query = _appDbContext.OsusrTeiCsicpDd048s
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Dd040Id == in_dd040Id)
                .Select(e => new CSICP_DD048
                {
                    TenantId = e.TenantId,
                    Dd048Id = e.Dd048Id,
                    Dd045Id = e.Dd045Id,
                    Dd040Id = e.Dd040Id,
                    Dd048Filial = e.Dd048Filial,
                    Dd048Ci = e.Dd048Ci,
                    Dd048Tipo = e.Dd048Tipo,
                    Dd048IndOperacao = e.Dd048IndOperacao,
                    Dd048IndEmitente = e.Dd048IndEmitente,
                    Dd048Participante = e.Dd048Participante,
                    Dd048Chaveacesso = e.Dd048Chaveacesso,
                    Dd048Serie = e.Dd048Serie,
                    Dd048SubSerie = e.Dd048SubSerie,
                    Dd048NumDocto = e.Dd048NumDocto,
                    Dd048NumEcf = e.Dd048NumEcf,
                    Dd048ModDocFiscal = e.Dd048ModDocFiscal,
                    Dd048DtEmisDocto = e.Dd048DtEmisDocto,
                    Dd048UfId = e.Dd048UfId,
                    Dd048Uf = e.Dd048Uf,
                    Dd048Cnpj = e.Dd048Cnpj
                });
            return await query.ToListAsync();
        }

       
    }
}