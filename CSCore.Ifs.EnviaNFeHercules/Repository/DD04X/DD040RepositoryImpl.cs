using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.Staticas.AA;
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

        public async Task<CSICP_DD040?> GetByIdAsync(int in_tenant, string in_dd040Id)
        {
            IQueryable<CSICP_DD040> query = GetQueryBase(in_tenant);
            CSICP_DD040? cSICP_DD040 = await query.FirstOrDefaultAsync(e => e.Dd040Id == in_dd040Id);
            return cSICP_DD040;
        }

   
        public async Task<List<CSICP_BB001_AXML>> GetListAsyncBB001AXML(int in_tenant, string? in_bb001Id)
        {
            IQueryable<CSICP_BB001_AXML> query = _appDbContext.E9ACSICP_BB001Axmls
                .Where(e => e.TenantId == in_tenant)
                .Where(e => e.Bb001aEstabid == in_bb001Id);
            return await query.ToListAsync();
        }

        private IQueryable<CSICP_DD040> GetQueryBase(int in_tenant)
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

                   join bb001CfgFis in _appDbContext.E9ACSICP_BB001Cfgfis
                   on bb001.Id equals bb001CfgFis.Bb001EmpresaId into bb001CfgFis_bb001_join
                   from bb001CfgFis in bb001CfgFis_bb001_join.DefaultIfEmpty()

                   join aa030Regime in _appDbContext.E9ACSICP_AA030Regimes
                   on bb001CfgFis.Bb001Regimetributarioid equals aa030Regime.Id into aa030Regime_bb001CfgFis_join
                   from aa030Regime in aa030Regime_bb001CfgFis_join.DefaultIfEmpty()

                   join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                   on dd040.Dd040ContaId equals bb012.Id into bb012_dd040_join
                   from bb012 in bb012_dd040_join.DefaultIfEmpty()

                       //-----------tabelas estaticas da bb012 adicionadas dia 02/10/2025----------------// 
                   join bb01201 in _appDbContext.OsusrE9aCsicpBb01201s
                   on bb012.Id equals bb01201.Id into bb01201_bb012_join //verificar a propriedadeID "bb012.Id" se está correta
                   from bb01201 in bb01201_bb012_join.DefaultIfEmpty()

                   join bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                   on bb012.Id equals bb01202.Id into bb01202_bb012_join
                   from bb01202 in bb01202_bb012_join.DefaultIfEmpty()

                   join bb012ins in _appDbContext.OsusrE9aCsicpBb01202Ins
                   on bb01202.Bb012InscEstSniId equals bb012ins.Id into bb012ins_bb012_join
                   from bb012ins in bb012ins_bb012_join.DefaultIfEmpty()

                   join bb012gructa in _appDbContext.OsusrE9aCsicpBb012Gructa
                   on bb012.Bb012GrupocontaId equals bb012gructa.Id into bb012gructa_bb012_join
                   from bb012gructa in bb012gructa_bb012_join.DefaultIfEmpty()
                   //-------------------------------------------------------------------//

                   join dd909 in _appDbContext.OsusrTeiCsicpDd909s
                   on dd040.Dd040Tpemis equals dd909.Id into dd909_dd040_join
                   from dd909 in dd909_dd040_join.DefaultIfEmpty()

                   join spedIcms in _appDbContext.OsusrNnxSpedInDocIcms
                   on dd040.Dd040ModId equals spedIcms.Id into spedIcms_dd040_join
                   from spedIcms in spedIcms_dd040_join.DefaultIfEmpty()

                   join dd040Tnt in _appDbContext.OsusrTeiCsicpDd040Tnts
                   on dd040.Dd040TiponotaId equals dd040Tnt.Id into dd040Tnt_dd040_join
                   from dd040Tnt in dd040Tnt_dd040_join.DefaultIfEmpty()

                   join dd040IPres in _appDbContext.OsusrTeiCsicpDd040Ipres
                   on dd040.Dd040Indpres equals dd040IPres.Id into dd040IPres_dd040_join
                   from dd040IPres in dd040IPres_dd040_join.DefaultIfEmpty()

                   join dd041Frete in _appDbContext.OsusrTeiCsicpDd041Fretes
                   on dd040.Dd040Modalidadefrete equals dd041Frete.Id into dd041Frete_dd040_join
                   from dd041Frete in dd041Frete_dd040_join.DefaultIfEmpty()

                   join aa145Tpdebcre in _appDbContext.OsusrE9aCsicpAa145Tpdebcres
                   on dd040.DD040_TPDEBCREID equals aa145Tpdebcre.Id into aa145Tpdebcre_dd040_join
                   from aa145Tpdebcre in aa145Tpdebcre_dd040_join.DefaultIfEmpty()

                   join aa149Tpopgov in _appDbContext.OsusrE9aCsicpAa149Tpopgovs
                   on dd040.B34_TPOPERGOVID equals aa149Tpopgov.Id into aa149Tpopgov_dd040_join
                   from aa149Tpopgov in aa149Tpopgov_dd040_join.DefaultIfEmpty()

                   select new CSICP_DD040
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
                       //--------Reforma Tributária-----------------//
                       W33_VIS = dd040.W33_VIS,
                       W35_VBCIBSCBS = dd040.W35_VBCIBSCBS,
                       W38_IBSUF_VDIF = dd040.W38_IBSUF_VDIF,
                       W39_IBSUF_VDEVTRIB = dd040.W39_IBSUF_VDEVTRIB,
                       W41_VIBSUF = dd040.W41_VIBSUF,
                       W43_IBSMUN_VDIF = dd040.W43_IBSMUN_VDIF,
                       W44_IBSMUN__VDEVTRIB = dd040.W44_IBSMUN__VDEVTRIB,
                       W46_VIBSMUN = dd040.W46_VIBSMUN,
                       W47_VIBSTOT = dd040.W47_VIBSTOT,
                       W48_VCREDPRES = dd040.W48_VCREDPRES,
                       W49_VCREDPRESCONDSUS = dd040.W49_VCREDPRESCONDSUS,
                       W53_CBS_VDIF = dd040.W53_CBS_VDIF,
                       W54_CBS_VDEVTRIB = dd040.W54_CBS_VDEVTRIB,
                       W56A_CBS_VCREDPRES = dd040.W56A_CBS_VCREDPRES,
                       W56B_CBS_VCREDPRESCONDSUS = dd040.W56B_CBS_VCREDPRESCONDSUS,
                       W58_VTOTIBSMONO = dd040.W58_VTOTIBSMONO,
                       W59_VTOTCBSMONO = dd040.W59_VTOTCBSMONO,
                       DD040_TPDEBCREID = dd040.DD040_TPDEBCREID,
                       W59B_VCBSMONORETEN = dd040.W59B_VCBSMONORETEN,
                       W59C_VIBSMONORETEN = dd040.W59C_VIBSMONORETEN,
                       W59D_VCBSMONORET = dd040.W59D_VCBSMONORET,
                       W60_VTOTNF = dd040.W60_VTOTNF,
                       B33_PREDUTOR = dd040.B33_PREDUTOR,
                       B34_TPOPERGOVID = dd040.B34_TPOPERGOVID,

                       NavBB012Conta = bb012 != null ? new CSICP_BB012
                       {
                           TenantId = bb012.TenantId,
                           Id = bb012.Id,
                           Bb012Codigo = bb012.Bb012Codigo,
                           Bb012NomeCliente = bb012.Bb012NomeCliente,
                           Bb012NomeFantasia = bb012.Bb012NomeFantasia,
                           Bb012DataAniversario = bb012.Bb012DataAniversario,
                           Bb012DataCadastro = bb012.Bb012DataCadastro,
                           Bb012Telefone = bb012.Bb012Telefone,
                           Bb012Faxcelular = bb012.Bb012Faxcelular,
                           Bb012HomePage = bb012.Bb012HomePage,
                           Bb012Email = bb012.Bb012Email,
                           Bb012DataEntradaSit = bb012.Bb012DataEntradaSit,
                           Bb012DataSaidaSit = bb012.Bb012DataSaidaSit,
                           Bb012Descricao = bb012.Bb012Descricao,
                           Bb012IsActive = bb012.Bb012IsActive,
                           Bb012TipoContaId = bb012.Bb012TipoContaId,
                           Bb012GrupocontaId = bb012.Bb012GrupocontaId,
                           Bb012ClassecontaId = bb012.Bb012ClassecontaId,
                           Bb012StatuscontaId = bb012.Bb012StatuscontaId,
                           Bb012SitContaId = bb012.Bb012SitContaId,
                           Bb012ModrelacaoId = bb012.Bb012ModrelacaoId,
                           Bb012Sequence = bb012.Bb012Sequence,
                           Bb012Dultalteracao = bb012.Bb012Dultalteracao,
                           Bb012Estabcadid = bb012.Bb012Estabcadid,
                           Bb012Keyacess = bb012.Bb012Keyacess,
                           Bb012IdIndicador = bb012.Bb012IdIndicador,
                           Bb012Countappmcon = bb012.Bb012Countappmcon,
                           Bb012Oricadastroid = bb012.Bb012Oricadastroid,
                           OsusrE9aCsicpBb01201 = bb01201 != null ? new CSICP_BB01201
                           {
                               TenantId = bb01201.TenantId,
                               Id = bb01201.Id,
                               Bb012Zonaid = bb01201.Bb012Zonaid,
                               Bb012Atividadeid = bb01201.Bb012Atividadeid,
                               Bb012Limitecredito = bb01201.Bb012Limitecredito,
                               Bb012Limcreditosecun = bb01201.Bb012Limcreditosecun,
                               Bb012Limiteccredito = bb01201.Bb012Limiteccredito,
                               Bb012Diavenctocartao = bb01201.Bb012Diavenctocartao,
                               Bb012Contaconvenio = bb01201.Bb012Contaconvenio,
                               Bb012Diaspagtoconv = bb01201.Bb012Diaspagtoconv,
                               Bb012Padraobancoid = bb01201.Bb012Padraobancoid,
                               Bb012Bcoagenciaconta = bb01201.Bb012Bcoagenciaconta,
                               Bb012Revenda = bb01201.Bb012Revenda,
                               Bb012TaxaAdministracaoCon = bb01201.Bb012TaxaAdministracaoCon,
                               Bb012Requisicao = bb01201.Bb012Requisicao,
                               Bb012Contacontabil = bb01201.Bb012Contacontabil,
                               Bb012Historicocontabilid = bb01201.Bb012Historicocontabilid,
                               Bb012Contratocartao = bb01201.Bb012Contratocartao,
                               Bb012Datacontratocartao = bb01201.Bb012Datacontratocartao,
                               Bb012Dtvalidadecartao = bb01201.Bb012Dtvalidadecartao,
                               Bb012Modalidadecredcartao = bb01201.Bb012Modalidadecredcartao,
                               Bb012Perclimcredito = bb01201.Bb012Perclimcredito,
                               Bb012Prazoentregafornec = bb01201.Bb012Prazoentregafornec,
                               Bb012Condpagtofornec = bb01201.Bb012Condpagtofornec,
                               Bb012Natoperacaoid = bb01201.Bb012Natoperacaoid,
                               Bb012Condpagtoid = bb01201.Bb012Condpagtoid,
                               Bb012Textonotaid = bb01201.Bb012Textonotaid,
                               Bb012GrauRisco = bb01201.Bb012GrauRisco,
                               Bb012ClasseCredito = bb01201.Bb012ClasseCredito,
                               Bb012Dtvalidcadastro = bb01201.Bb012Dtvalidcadastro,
                               Bb012PercIcms = bb01201.Bb012PercIcms,
                               Bb012Codgcategoria = bb01201.Bb012Codgcategoria,
                               Bb012Categoriaid = bb01201.Bb012Categoriaid,
                               Bb012Limitecredparcela = bb01201.Bb012Limitecredparcela,
                               Bb012NumUltFatura = bb01201.Bb012NumUltFatura,
                               Bb012Totcompracarnet = bb01201.Bb012Totcompracarnet,
                               Bb012ValorEntrada = bb01201.Bb012ValorEntrada,
                               Bb012MaiorCompra = bb01201.Bb012MaiorCompra,
                               Bb012MenorCompra = bb01201.Bb012MenorCompra,
                               Bb012Totdiasatraso = bb01201.Bb012Totdiasatraso,
                               Bb012MaiorAtraso = bb01201.Bb012MaiorAtraso,
                               Bb012MenorAtraso = bb01201.Bb012MenorAtraso,
                               Bb012Mediadeatraso = bb01201.Bb012Mediadeatraso,
                               Bb012Maiorsaldo = bb01201.Bb012Maiorsaldo,
                               Bb012Numcompras = bb01201.Bb012Numcompras,
                               Bb012Dtprimcompra = bb01201.Bb012Dtprimcompra,
                               Bb012Dtultcompra = bb01201.Bb012Dtultcompra,
                               Bb012Vlrmaiorpagto = bb01201.Bb012Vlrmaiorpagto,
                               Bb012Numpagtodia = bb01201.Bb012Numpagtodia,
                               Bb012Numpagtoatraso = bb01201.Bb012Numpagtoatraso,
                               Bb012Saldodevedor = bb01201.Bb012Saldodevedor,
                               Bb012Saldopedido = bb01201.Bb012Saldopedido,
                               Bb012Qtdtitprotestado = bb01201.Bb012Qtdtitprotestado,
                               Bb012Ultprotesto = bb01201.Bb012Ultprotesto,
                               Bb012Qtdchqdevolvido = bb01201.Bb012Qtdchqdevolvido,
                               Bb012Ultchqdevolvido = bb01201.Bb012Ultchqdevolvido,
                               Bb012ConvenioId = bb01201.Bb012ConvenioId,
                               Bb012TipogeracaoId = bb01201.Bb012TipogeracaoId,
                               Bb012SitespecialId = bb01201.Bb012SitespecialId,
                               Bb012Entmtgrotaid = bb01201.Bb012Entmtgrotaid,
                               Bb012Vendarotaid = bb01201.Bb012Vendarotaid,
                               Bb012Diavenctoid = bb01201.Bb012Diavenctoid,
                               Bb012Codgbcodebconta = bb01201.Bb012Codgbcodebconta,
                           } : null,

                           Nav_BB01202 = bb01202 != null ? new CSICP_BB01202
                           {
                               TenantId = bb01202.TenantId,
                               Id = bb01202.Id,
                               Bb012Cnpj = bb01202!.Bb012Cnpj,
                               Bb012Inscestadual = bb01202.Bb012Inscestadual,
                               Bb012Suframa = bb01202.Bb012Suframa,
                               Bb012Regsuframavalido = bb01202.Bb012Regsuframavalido,
                               Bb012Regjuntacomercial = bb01202.Bb012Regjuntacomercial,
                               Bb012Dataregjunta = bb01202.Bb012Dataregjunta,
                               Bb012Patrimonio = bb01202.Bb012Patrimonio,
                               Bb012CapitalSocial = bb01202.Bb012CapitalSocial,
                               Bb012Cpf = bb01202.Bb012Cpf,
                               Bb012Rg = bb01202.Bb012Rg,
                               Bb012Complementorg = bb01202.Bb012Complementorg,
                               Bb012Emissaorg = bb01202.Bb012Emissaorg,
                               Bb012Pis = bb01202.Bb012Pis,
                               Bb012Residedesde = bb01202.Bb012Residedesde,
                               Bb012Nrodependentes = bb01202.Bb012Nrodependentes,
                               Bb012Empadmissao = bb01202.Bb012Empadmissao,
                               Bb012EmpProfissao = bb01202.Bb012EmpProfissao,
                               Bb012Valorremuneracao = bb01202.Bb012Valorremuneracao,
                               Bb012Outrosrendimentos = bb01202.Bb012Outrosrendimentos,
                               Bb012Origemoutrosrend = bb01202.Bb012Origemoutrosrend,
                               Bb012InscEstSniId = bb01202.Bb012InscEstSniId,
                               Bb012SexoId = bb01202.Bb012SexoId,
                               Bb012EstadocivilId = bb01202.Bb012EstadocivilId,
                               Bb012TipodomicilioId = bb01202.Bb012TipodomicilioId,
                               Bb012Compresid01Id = bb01202.Bb012Compresid01Id,
                               Bb012Compresid02Id = bb01202.Bb012Compresid02Id,
                               Bb012GescolaridadeId = bb01202.Bb012GescolaridadeId,
                               Bb012OcupacaoId = bb01202.Bb012OcupacaoId,
                               Bb012NaturaldeId = bb01202.Bb012NaturaldeId,
                               Bb012TptributacaoId = bb01202.Bb012TptributacaoId,
                               Bb012IdentEstrangeiro = bb01202.Bb012IdentEstrangeiro,
                               Bb012Empresa = bb01202.Bb012Empresa,
                               Bb012EmpEndereco = bb01202.Bb012EmpEndereco,
                               Bb012EmpGrupoId = bb01202.Bb012EmpGrupoId,
                               Bb012Motdesoneracaoid = bb01202.Bb012Motdesoneracaoid,
                               BB012_Insc_Est_SNI = bb012ins != null ? new CSICP_Bb01202Ins
                               {
                                   Id = bb012ins.Id,
                                   Label = bb012ins.Label,
                                   Order = bb012ins.Order,
                                   IsActive = bb012ins.IsActive
                               } : null,
                           } : null,
                           BB012_GrupoConta = bb012gructa != null ? new CSICP_Bb012Gructa
                           {
                               Id = bb012gructa.Id,
                               Label = bb012gructa.Label,
                               Order = bb012gructa.Order,
                               IsActive = bb012gructa.IsActive,
                               Usocs = bb012gructa.Usocs
                           } : null,
                       } : null,

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
                           Cidade = aa028 != null ? new CSICP_Aa028
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
                               NavUf = aa027 != null ? new CSICP_Aa027
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
                                   Pais = aa025 != null ? new CSICP_Aa025
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
                               } : null,
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
                                   Bb001Regimetributario = aa030Regime != null ? new CSICP_AA030Regime
                                   {
                                       Id = aa030Regime.Id,
                                       Label = aa030Regime.Label,
                                       Order = aa030Regime.Order,
                                       IsActive = aa030Regime.IsActive,
                                       CrtDigito = aa030Regime.CrtDigito,
                                   } : null,
                               } : null,
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
                       } : null,

                       NavAa145Tpdebcre = aa145Tpdebcre != null ? new OsusrE9aCsicpAa145Tpdebcre
                       {
                           Id = aa145Tpdebcre.Id,
                           Label = aa145Tpdebcre.Label,
                           Order = aa145Tpdebcre.Order,
                           IsActive = aa145Tpdebcre.IsActive,
                           Tiponotacredeb = aa145Tpdebcre.Tiponotacredeb,
                           Debcre = aa145Tpdebcre.Debcre,
                       } : null,

                       NavAa149Tpopgov = aa149Tpopgov != null ? new OsusrE9aCsicpAa149Tpopgov
                       {
                           Id = aa149Tpopgov.Id,
                           Label = aa149Tpopgov.Label,
                           Order = aa149Tpopgov.Order,
                           IsActive = aa149Tpopgov.IsActive,
                           CodgCs = aa149Tpopgov.CodgCs,
                       } : null,
                   };
        }

        public async Task<List<CSICP_DD041>> GetListAsyncDD041(int in_tenant, string in_dd040Id)
        {
            var query = from dd041 in _appDbContext.OsusrTeiCsicpDd041s

                        where dd041.TenantId == in_tenant
                        && dd041.Dd040Id == in_dd040Id

                        join bb012conta in _appDbContext.OsusrE9aCsicpBb012s
                        on dd041.Dd041ContaId equals bb012conta.Id into bb012conta_join
                        from bb012conta in bb012conta_join.DefaultIfEmpty() //adicionar no dto/mapper

                        join bb012gructa in _appDbContext.OsusrE9aCsicpBb012Gructa
                        on bb012conta.Bb012GrupocontaId equals bb012gructa.Id into bb012gructa_join
                        from bb012gructa in bb012gructa_join.DefaultIfEmpty() //adicionar no dto/mapper

                        join bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                        on bb012conta.Id equals bb01202.Id into bb01202_join
                        from bb01202 in bb01202_join.DefaultIfEmpty() //adicionar no dto/mapper

                        join bb012ins in _appDbContext.OsusrE9aCsicpBb01202Ins
                        on bb01202.Bb012InscEstSniId equals bb012ins.Id into bb012ins_join
                        from bb012ins in bb012ins_join.DefaultIfEmpty() //adicionar no dto/mapper

                        join bb012Trasportadora in _appDbContext.OsusrE9aCsicpBb012s
                        on dd041.Dd041TransportadoraId equals bb012Trasportadora.Id into bb012Trasportadora_join
                        from bb012Trasportadora in bb012Trasportadora_join.DefaultIfEmpty()

                        join aa028cidade in _appDbContext.OsusrE9aCsicpAa028s
                        on dd041.Dd041CidadeId equals aa028cidade.Id into aa028cidade_join
                        from aa028cidade in aa028cidade_join.DefaultIfEmpty()

                        join aa027uf in _appDbContext.OsusrE9aCsicpAa027s
                        on aa028cidade.Ufid equals aa027uf.Id into aa027uf_join
                        from aa027uf in aa027uf_join.DefaultIfEmpty()

                        join aa025pais in _appDbContext.OsusrE9aCsicpAa025s
                        on aa027uf.Paisid equals aa025pais.Id into aa025pais_join
                        from aa025pais in aa025pais_join.DefaultIfEmpty()

                        join dd041doc in _appDbContext.OsusrTeiCsicpDd041Doctos
                        on dd041.Dd041Tipodocto equals dd041doc.Id into dd041doc_join
                        from dd041doc in dd041doc_join.DefaultIfEmpty()

                        join dd040 in _appDbContext.OsusrTeiCsicpDd040s
                        on dd041.Dd040Id equals dd040.Dd040Id into dd040_join
                        from dd040 in dd040_join.DefaultIfEmpty()

                        select new CSICP_DD041
                        {
                            TenantId = dd041.TenantId,
                            Dd041Id = dd041.Dd041Id,
                            Dd040Id = dd041.Dd040Id,
                            Dd041Tipo = dd041.Dd041Tipo,
                            Dd041ContaId = dd041.Dd041ContaId,
                            Dd041Tipodocto = dd041.Dd041Tipodocto,
                            Dd041CnpjCpf = dd041.Dd041CnpjCpf,
                            Dd041Nome = dd041.Dd041Nome,
                            Dd041Logradouro = dd041.Dd041Logradouro,
                            Dd041Numero = dd041.Dd041Numero,
                            Dd041Complemento = dd041.Dd041Complemento,
                            Dd041Perimetro = dd041.Dd041Perimetro,
                            Dd041BairroId = dd041.Dd041BairroId,
                            Dd041Nomebairro = dd041.Dd041Nomebairro,
                            Dd041Cep = dd041.Dd041Cep,
                            Dd041PaisId = dd041.Dd041PaisId,
                            Dd041UfId = dd041.Dd041UfId,
                            Dd041CidadeId = dd041.Dd041CidadeId,
                            Dd041IeRg = dd041.Dd041IeRg,
                            Dd041Suframa = dd041.Dd041Suframa,
                            Dd041Telefone = dd041.Dd041Telefone,
                            Dd041Email = dd041.Dd041Email,
                            Dd041TransportadoraId = dd041.Dd041TransportadoraId,
                            Dd041Nometransp = dd041.Dd041Nometransp,
                            Dd041Modalidadefrete = dd041.Dd041Modalidadefrete,
                            Dd041Placaveiculo = dd041.Dd041Placaveiculo,
                            Dd041Ufveiculo = dd041.Dd041Ufveiculo,
                            Dd041Marcaveiculo = dd041.Dd041Marcaveiculo,
                            Dd041Numtransp = dd041.Dd041Numtransp,
                            Dd041Placareboque = dd041.Dd041Placareboque,
                            Dd041UfreboqueId = dd041.Dd041UfreboqueId,
                            Dd041Numtranspreboq = dd041.Dd041Numtranspreboq,
                            Dd041Vagao = dd041.Dd041Vagao,
                            Dd041Balsa = dd041.Dd041Balsa,
                            Dd041EnderecoId = dd041.Dd041EnderecoId,
                            Dd041SendEmail = dd041.Dd041SendEmail,
                            Dd041SendSms = dd041.Dd041SendSms,
                            Dd041UserOperadorId = dd041.Dd041UserOperadorId,
                            Dd041DataCaixa = dd041.Dd041DataCaixa,
                            Dd041Sms = dd041.Dd041Sms,
                            Dd041Indfinal = dd041.Dd041Indfinal,
                            Dd041IdentEstrangeiro = dd041.Dd041IdentEstrangeiro,

                            NavBB012Conta = bb012conta != null ? new CSICP_BB012
                            {
                                TenantId = bb012conta.TenantId,
                                Id = bb012conta.Id,
                                Bb012Codigo = bb012conta.Bb012Codigo,
                                Bb012NomeCliente = bb012conta.Bb012NomeCliente,
                                Bb012NomeFantasia = bb012conta.Bb012NomeFantasia,
                                Bb012DataAniversario = bb012conta.Bb012DataAniversario,
                                Bb012DataCadastro = bb012conta.Bb012DataCadastro,
                                Bb012Telefone = bb012conta.Bb012Telefone,
                                Bb012Faxcelular = bb012conta.Bb012Faxcelular,
                                Bb012HomePage = bb012conta.Bb012HomePage,
                                Bb012Email = bb012conta.Bb012Email,
                                Bb012DataEntradaSit = bb012conta.Bb012DataEntradaSit,
                                Bb012DataSaidaSit = bb012conta.Bb012DataSaidaSit,
                                Bb012Descricao = bb012conta.Bb012Descricao,
                                Bb012IsActive = bb012conta.Bb012IsActive,
                                Bb012TipoContaId = bb012conta.Bb012TipoContaId,
                                Bb012GrupocontaId = bb012conta.Bb012GrupocontaId,
                                Bb012ClassecontaId = bb012conta.Bb012ClassecontaId,
                                Bb012StatuscontaId = bb012conta.Bb012StatuscontaId,
                                Bb012SitContaId = bb012conta.Bb012SitContaId,
                                Bb012ModrelacaoId = bb012conta.Bb012ModrelacaoId,
                                Bb012Sequence = bb012conta.Bb012Sequence,
                                Bb012Dultalteracao = bb012conta.Bb012Dultalteracao,
                                Bb012Estabcadid = bb012conta.Bb012Estabcadid,
                                Bb012Keyacess = bb012conta.Bb012Keyacess,
                                Bb012IdIndicador = bb012conta.Bb012IdIndicador,
                                Bb012Countappmcon = bb012conta.Bb012Countappmcon,
                                Bb012Oricadastroid = bb012conta.Bb012Oricadastroid,
                                
                                Nav_BB01202 = bb01202 != null ? new CSICP_BB01202
                                {
                                    TenantId = bb01202.TenantId,
                                    Id = bb01202.Id,
                                    Bb012Cnpj = bb01202!.Bb012Cnpj,
                                    Bb012Inscestadual = bb01202.Bb012Inscestadual,
                                    Bb012Suframa = bb01202.Bb012Suframa,
                                    Bb012Regsuframavalido = bb01202.Bb012Regsuframavalido,
                                    Bb012Regjuntacomercial = bb01202.Bb012Regjuntacomercial,
                                    Bb012Dataregjunta = bb01202.Bb012Dataregjunta,
                                    Bb012Patrimonio = bb01202.Bb012Patrimonio,
                                    Bb012CapitalSocial = bb01202.Bb012CapitalSocial,
                                    Bb012Cpf = bb01202.Bb012Cpf,
                                    Bb012Rg = bb01202.Bb012Rg,
                                    Bb012Complementorg = bb01202.Bb012Complementorg,
                                    Bb012Emissaorg = bb01202.Bb012Emissaorg,
                                    Bb012Pis = bb01202.Bb012Pis,
                                    Bb012Residedesde = bb01202.Bb012Residedesde,
                                    Bb012Nrodependentes = bb01202.Bb012Nrodependentes,
                                    Bb012Empadmissao = bb01202.Bb012Empadmissao,
                                    Bb012EmpProfissao = bb01202.Bb012EmpProfissao,
                                    Bb012Valorremuneracao = bb01202.Bb012Valorremuneracao,
                                    Bb012Outrosrendimentos = bb01202.Bb012Outrosrendimentos,
                                    Bb012Origemoutrosrend = bb01202.Bb012Origemoutrosrend,
                                    Bb012InscEstSniId = bb01202.Bb012InscEstSniId,
                                    Bb012SexoId = bb01202.Bb012SexoId,
                                    Bb012EstadocivilId = bb01202.Bb012EstadocivilId,
                                    Bb012TipodomicilioId = bb01202.Bb012TipodomicilioId,
                                    Bb012Compresid01Id = bb01202.Bb012Compresid01Id,
                                    Bb012Compresid02Id = bb01202.Bb012Compresid02Id,
                                    Bb012GescolaridadeId = bb01202.Bb012GescolaridadeId,
                                    Bb012OcupacaoId = bb01202.Bb012OcupacaoId,
                                    Bb012NaturaldeId = bb01202.Bb012NaturaldeId,
                                    Bb012TptributacaoId = bb01202.Bb012TptributacaoId,
                                    Bb012IdentEstrangeiro = bb01202.Bb012IdentEstrangeiro,
                                    Bb012Empresa = bb01202.Bb012Empresa,
                                    Bb012EmpEndereco = bb01202.Bb012EmpEndereco,
                                    Bb012EmpGrupoId = bb01202.Bb012EmpGrupoId,
                                    Bb012Motdesoneracaoid = bb01202.Bb012Motdesoneracaoid,
                                    BB012_Insc_Est_SNI = bb012ins != null ? new CSICP_Bb01202Ins
                                    {
                                        Id = bb012ins.Id,
                                        Label = bb012ins.Label,
                                        Order = bb012ins.Order,
                                        IsActive = bb012ins.IsActive
                                    } : null,
                                } : null,

                                BB012_GrupoConta = bb012gructa != null ? new CSICP_Bb012Gructa
                                {
                                    Id = bb012gructa.Id,
                                    Label = bb012gructa.Label,
                                    Order = bb012gructa.Order,
                                    IsActive = bb012gructa.IsActive,
                                    Usocs = bb012gructa.Usocs,
                                } : null,
                            } : null,

                            NavAA028 = aa028cidade != null ? new CSICP_Aa028
                            {
                                TenantId = aa028cidade.TenantId,
                                Id = aa028cidade.Id,
                                Aa028Cidade = aa028cidade.Aa028Cidade,
                                Aa028Percicmscontrib = aa028cidade.Aa028Percicmscontrib,
                                A028Percicmsncontrib = aa028cidade.A028Percicmsncontrib,
                                A028Percsubsttribut = aa028cidade.A028Percsubsttribut,
                                A028Mascinsestadual = aa028cidade.A028Mascinsestadual,
                                A028Percicmsentrada = aa028cidade.A028Percicmsentrada,
                                A028Mascieimpressao = aa028cidade.A028Mascieimpressao,
                                Aa028Codgibge = aa028cidade.Aa028Codgibge,
                                Aa028Zonafranca = aa028cidade.Aa028Zonafranca,
                                Aa028Estadobrasil = aa028cidade.Aa028Estadobrasil,
                                Ufid = aa028cidade.Ufid,
                                Aa028ExportCidadeid = aa028cidade.Aa028ExportCidadeid,
                                Aa027ExportUfid = aa028cidade.Aa027ExportUfid
                            } : null,

                            NavAA027 = aa027uf != null ? new CSICP_Aa027
                            {
                                TenantId = aa027uf.TenantId,
                                Id = aa027uf.Id,
                                Aa027Sigla = aa027uf.Aa027Sigla,
                                Descricao = aa027uf.Descricao,
                                Aa027Percicmscontrib = aa027uf.Aa027Percicmscontrib,
                                Aa027Percicmsncontrib = aa027uf.Aa027Percicmsncontrib,
                                Aa027Percsubsttribut = aa027uf.Aa027Percsubsttribut,
                                Aa027Mascinsestadual = aa027uf.Aa027Mascinsestadual,
                                Aa027Percicmsentrada = aa027uf.Aa027Percicmsentrada,
                                Aa027Mascieimpressao = aa027uf.Aa027Mascieimpressao,
                                Aa027Codigoibge = aa027uf.Aa027Codigoibge,
                                Paisid = aa027uf.Paisid,
                                Regiaoid = aa027uf.Regiaoid,
                                Aa027Naturalidade = aa027uf.Aa027Naturalidade,
                                Aa027ExportUfid = aa027uf.Aa027ExportUfid,
                                Aa025ExportPaisid = aa027uf.Aa025ExportPaisid,
                                Aa026ExportRegiaoid = aa027uf.Aa026ExportRegiaoid
                            } : null,
                            NavAA025 = aa025pais != null ? new CSICP_Aa025
                            {
                                TenantId = aa025pais.TenantId,
                                Id = aa025pais.Id,
                                Aa025Codigopais = aa025pais.Aa025Codigopais,
                                Aa025Descricao = aa025pais.Aa025Descricao,
                                Aa025Codigobacen = aa025pais.Aa025Codigobacen,
                                Aa025Codigosiscomex = aa025pais.Aa025Codigosiscomex,
                                Aa025Isactive = aa025pais.Aa025Isactive,
                                Aa025Nacionalidade = aa025pais.Aa025Nacionalidade,
                                Aa025Iso3166A2 = aa025pais.Aa025Iso3166A2,
                                Aa025Iso3166A3 = aa025pais.Aa025Iso3166A3,
                                Aa025Iso3166N3 = aa025pais.Aa025Iso3166N3,
                                Aa025ExportPaisid = aa025pais.Aa025ExportPaisid,
                                Aa025CodigoNacoesunidas = aa025pais.Aa025CodigoNacoesunidas,
                            } : null,

                            NavBB012Trasportadora = bb012Trasportadora != null ? new CSICP_BB012
                            {
                                TenantId = bb012Trasportadora.TenantId,
                                Id = bb012Trasportadora.Id,
                                Bb012Codigo = bb012Trasportadora.Bb012Codigo,
                                Bb012NomeCliente = bb012Trasportadora.Bb012NomeCliente,
                                Bb012NomeFantasia = bb012Trasportadora.Bb012NomeFantasia,
                                Bb012DataAniversario = bb012Trasportadora.Bb012DataAniversario,
                                Bb012DataCadastro = bb012Trasportadora.Bb012DataCadastro,
                                Bb012Telefone = bb012Trasportadora.Bb012Telefone,
                                Bb012Faxcelular = bb012Trasportadora.Bb012Faxcelular,
                                Bb012HomePage = bb012Trasportadora.Bb012HomePage,
                                Bb012Email = bb012Trasportadora.Bb012Email,
                                Bb012DataEntradaSit = bb012Trasportadora.Bb012DataEntradaSit,
                                Bb012DataSaidaSit = bb012Trasportadora.Bb012DataSaidaSit,
                                Bb012Descricao = bb012Trasportadora.Bb012Descricao,
                                Bb012IsActive = bb012Trasportadora.Bb012IsActive,
                                Bb012TipoContaId = bb012Trasportadora.Bb012TipoContaId,
                                Bb012GrupocontaId = bb012Trasportadora.Bb012GrupocontaId,
                                Bb012ClassecontaId = bb012Trasportadora.Bb012ClassecontaId,
                                Bb012StatuscontaId = bb012Trasportadora.Bb012StatuscontaId,
                                Bb012SitContaId = bb012Trasportadora.Bb012SitContaId,
                                Bb012ModrelacaoId = bb012Trasportadora.Bb012ModrelacaoId,
                                Bb012Sequence = bb012Trasportadora.Bb012Sequence,
                                Bb012Dultalteracao = bb012Trasportadora.Bb012Dultalteracao,
                                Bb012Estabcadid = bb012Trasportadora.Bb012Estabcadid,
                                Bb012Keyacess = bb012Trasportadora.Bb012Keyacess,
                                Bb012IdIndicador = bb012Trasportadora.Bb012IdIndicador,
                                Bb012Countappmcon = bb012Trasportadora.Bb012Countappmcon,
                                Bb012Oricadastroid = bb012Trasportadora.Bb012Oricadastroid
                            } : null,

                            NavDD041Doc = dd041doc != null ? new CSICP_DD041Docto
                            {
                                Id = dd041doc.Id,
                                Label = dd041doc.Label,
                                Order = dd041doc.Order,
                                IsActive = dd041doc.IsActive
                            } : null,
                        };
                        
            return await query.ToListAsync();
        }

        public async Task<List<CSICP_DD042>> GetListAsyncDD042(int in_tenant, string in_dd040Id)
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

                        join bb026Tp in _appDbContext.OsusrE9aCsicpBb026Tipos
                        on bb026.Bb026Tipo equals bb026Tp.Id into bb026Tp_join
                        from bb026Tp in bb026Tp_join.DefaultIfEmpty()

                        join bb019 in _appDbContext.OsusrE9aCsicpBb019s
                        on dd042.Dd042Administradoraid equals bb019.Id into bb019_join
                        from bb019 in bb019_join.DefaultIfEmpty() //bandeira do cartão (colocar no dto/mapper)

                        join bb019tipo in _appDbContext.OsusrE9aCsicpBb019Tipos
                        on bb019.Bb019TipofinancId equals bb019tipo.Id into bb019tipo_join
                        from bb019tipo in bb019tipo_join.DefaultIfEmpty() //tipo do cartão (crédito, débito, voucher) (colocar no dto/mapper)

                        join bb012conta in _appDbContext.OsusrE9aCsicpBb012s
                        on bb019.Bb019Contaid equals bb012conta.Id into bb012conta_join
                        from bb012conta in bb012conta_join.DefaultIfEmpty() //conta vinculada à administradora (colocar no dto/mapper)

                        join bb01202 in _appDbContext.OsusrE9aCsicpBb01202s
                        on bb012conta.Id equals bb01202.Id into bb01202_join
                        from bb01202 in bb01202_join.DefaultIfEmpty() //dados bancários da conta vinculada à administradora (colocar no dto/mapper)

                        join dd830 in _appDbContext.OsusrTeiCsicpDd830s
                        on dd042.Dd042Id equals dd830.Dd042Id into dd830_join
                        from dd830 in dd830_join.DefaultIfEmpty() //dados de conciliação bancária (colocar no dto/mapper)

                        let listdd043 = (from dd043 in _appDbContext.OsusrTeiCsicpDd043s
                                         where dd043.TenantId == in_tenant && dd043.Dd042Id == dd042.Dd042Id
                                         select dd043).ToList()

                        select new CSICP_DD042
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

                            NavBB012Conta = bb012conta != null ? new CSICP_BB012
                            {
                                TenantId = bb012conta.TenantId,
                                Id = bb012conta.Id,
                                Bb012Codigo = bb012conta.Bb012Codigo,
                                Bb012NomeCliente = bb012conta.Bb012NomeCliente,
                                Bb012NomeFantasia = bb012conta.Bb012NomeFantasia,
                                Bb012DataAniversario = bb012conta.Bb012DataAniversario,
                                Bb012DataCadastro = bb012conta.Bb012DataCadastro,
                                Bb012Telefone = bb012conta.Bb012Telefone,
                                Bb012Faxcelular = bb012conta.Bb012Faxcelular,
                                Bb012HomePage = bb012conta.Bb012HomePage,
                                Bb012Email = bb012conta.Bb012Email,
                                Bb012DataEntradaSit = bb012conta.Bb012DataEntradaSit,
                                Bb012DataSaidaSit = bb012conta.Bb012DataSaidaSit,
                                Bb012Descricao = bb012conta.Bb012Descricao,
                                Bb012IsActive = bb012conta.Bb012IsActive,
                                Bb012TipoContaId = bb012conta.Bb012TipoContaId,
                                Bb012GrupocontaId = bb012conta.Bb012GrupocontaId,
                                Bb012ClassecontaId = bb012conta.Bb012ClassecontaId,
                                Bb012StatuscontaId = bb012conta.Bb012StatuscontaId,
                                Bb012SitContaId = bb012conta.Bb012SitContaId,
                                Bb012ModrelacaoId = bb012conta.Bb012ModrelacaoId,
                                Bb012Sequence = bb012conta.Bb012Sequence,
                                Bb012Dultalteracao = bb012conta.Bb012Dultalteracao,
                                Bb012Estabcadid = bb012conta.Bb012Estabcadid,
                                Bb012Keyacess = bb012conta.Bb012Keyacess,
                                Bb012IdIndicador = bb012conta.Bb012IdIndicador,
                                Bb012Countappmcon = bb012conta.Bb012Countappmcon,
                                Bb012Oricadastroid = bb012conta.Bb012Oricadastroid,

                                Nav_BB01202 = bb01202 != null ? new CSICP_BB01202
                                {
                                    TenantId = bb01202.TenantId,
                                    Id = bb01202.Id,
                                    Bb012Cnpj = bb01202!.Bb012Cnpj,
                                    Bb012Inscestadual = bb01202.Bb012Inscestadual,
                                    Bb012Suframa = bb01202.Bb012Suframa,
                                    Bb012Regsuframavalido = bb01202.Bb012Regsuframavalido,
                                    Bb012Regjuntacomercial = bb01202.Bb012Regjuntacomercial,
                                    Bb012Dataregjunta = bb01202.Bb012Dataregjunta,
                                    Bb012Patrimonio = bb01202.Bb012Patrimonio,
                                    Bb012CapitalSocial = bb01202.Bb012CapitalSocial,
                                    Bb012Cpf = bb01202.Bb012Cpf,
                                    Bb012Rg = bb01202.Bb012Rg,
                                    Bb012Complementorg = bb01202.Bb012Complementorg,
                                    Bb012Emissaorg = bb01202.Bb012Emissaorg,
                                    Bb012Pis = bb01202.Bb012Pis,
                                    Bb012Residedesde = bb01202.Bb012Residedesde,
                                    Bb012Nrodependentes = bb01202.Bb012Nrodependentes,
                                    Bb012Empadmissao = bb01202.Bb012Empadmissao,
                                    Bb012EmpProfissao = bb01202.Bb012EmpProfissao,
                                    Bb012Valorremuneracao = bb01202.Bb012Valorremuneracao,
                                    Bb012Outrosrendimentos = bb01202.Bb012Outrosrendimentos,
                                    Bb012Origemoutrosrend = bb01202.Bb012Origemoutrosrend,
                                    Bb012InscEstSniId = bb01202.Bb012InscEstSniId,
                                    Bb012SexoId = bb01202.Bb012SexoId,
                                    Bb012EstadocivilId = bb01202.Bb012EstadocivilId,
                                    Bb012TipodomicilioId = bb01202.Bb012TipodomicilioId,
                                    Bb012Compresid01Id = bb01202.Bb012Compresid01Id,
                                    Bb012Compresid02Id = bb01202.Bb012Compresid02Id,
                                    Bb012GescolaridadeId = bb01202.Bb012GescolaridadeId,
                                    Bb012OcupacaoId = bb01202.Bb012OcupacaoId,
                                    Bb012NaturaldeId = bb01202.Bb012NaturaldeId,
                                    Bb012TptributacaoId = bb01202.Bb012TptributacaoId,
                                    Bb012IdentEstrangeiro = bb01202.Bb012IdentEstrangeiro,
                                    Bb012Empresa = bb01202.Bb012Empresa,
                                    Bb012EmpEndereco = bb01202.Bb012EmpEndereco,
                                    Bb012EmpGrupoId = bb01202.Bb012EmpGrupoId,
                                    Bb012Motdesoneracaoid = bb01202.Bb012Motdesoneracaoid,
                                } : null,
                            } : null,

                            NavBB019 = bb019 != null ? new CSICP_Bb019
                            {
                                TenantId = bb019.TenantId,
                                Id = bb019.Id,
                                Empresaid = bb019.Empresaid,
                                Bb019Filial = bb019.Bb019Filial,
                                Bb019Codigo = bb019.Bb019Codigo,
                                Bb019Administradora = bb019.Bb019Administradora,
                                Bb019TaxaDeCobranca = bb019.Bb019TaxaDeCobranca,
                                Bb019Venctopadrao = bb019.Bb019Venctopadrao,
                                Bb019Contaid = bb019.Bb019Contaid,
                                Bb019Usafatoracresc = bb019.Bb019Usafatoracresc,
                                Bb019Finanproprio = bb019.Bb019Finanproprio,
                                Bb019Tac = bb019.Bb019Tac,
                                Bb019Email = bb019.Bb019Email,
                                Bb019Homepage = bb019.Bb019Homepage,
                                Bb019TipofinancId = bb019.Bb019TipofinancId,
                                Bb019Isactive = bb019.Bb019Isactive,
                                Bb019Dialimitevenctopadrao = bb019.Bb019Dialimitevenctopadrao,
                                Bb019Codigocredenciadora = bb019.Bb019Codigocredenciadora,
                                Bb019LogoAdm = bb019.Bb019LogoAdm,
                                Bb019Filename = bb019.Bb019Filename,
                                Bb019Path = bb019.Bb019Path,
                                NavCSICP_Bb019Tipo = bb019tipo != null ? new CSICP_Bb019Tipo
                                {
                                    Id = bb019tipo.Id,
                                    Label = bb019tipo.Label,
                                    Order = bb019tipo.Order,
                                    IsActive = bb019tipo.IsActive,
                                    Tband = bb019tipo.Tband,
                                    CodgbandeiraSitef = bb019tipo.CodgbandeiraSitef,
                                    Codgautorizadora = bb019tipo.Codgautorizadora,
                                } : null,
                            } : null,

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
                                } : null,
                                NavBb026Tipo = bb026Tp != null ? new CSICP_Bb026Tipo
                                {
                                    Id = bb026Tp.Id,
                                    Label = bb026Tp.Label,
                                    Order = bb026Tp.Order,
                                    IsActive = bb026Tp.IsActive,
                                } : null,
                            } : null,

                            NavDD830 = dd830 != null ? new CSICP_DD830
                            {
                                TenantId = dd830.TenantId,
                                Dd830Id = dd830.Dd830Id,
                                Bb001Id = dd830.Bb001Id,
                                Dd830Siptef = dd830.Dd830Siptef,
                                Dd830SidLoja = dd830.Dd830SidLoja,
                                Dd830SidTerminal = dd830.Dd830SidTerminal,
                                Dd830Comando = dd830.Dd830Comando,
                                Dd830Vtransacao = dd830.Dd830Vtransacao,
                                Dd830Ntransacao = dd830.Dd830Ntransacao,
                                Dd830Operador = dd830.Dd830Operador,
                                Dd830Restricoes = dd830.Dd830Restricoes,
                                Dd830Ispinpad = dd830.Dd830Ispinpad,
                                Dd830Isautoconfirma = dd830.Dd830Isautoconfirma,
                                Dd830Dcreate = dd830.Dd830Dcreate,
                                Dd830Progresso = dd830.Dd830Progresso,
                                Dd830Formapagto = dd830.Dd830Formapagto,
                                Dd830Tpparcela = dd830.Dd830Tpparcela,
                                Dd830Qparcela = dd830.Dd830Qparcela,
                                Dd830Intervalopar = dd830.Dd830Intervalopar,
                                Dd830Isprimparcavista = dd830.Dd830Isprimparcavista,
                                Dd830Dprimparcela = dd830.Dd830Dprimparcela,
                                Dd830Status = dd830.Dd830Status,
                                Dd830Hashid = dd830.Dd830Hashid,
                                Dd830RetCompestab = dd830.Dd830RetCompestab,
                                Dd830RetCompcliente = dd830.Dd830RetCompcliente,
                                Dd830RetCompcancestab = dd830.Dd830RetCompcancestab,
                                Dd830RetCompcanc = dd830.Dd830RetCompcanc,
                                Dd830RetProtocoltran = dd830.Dd830RetProtocoltran,
                                Dd830RetDoc = dd830.Dd830RetDoc,
                                Dd830RetNsu = dd830.Dd830RetNsu,
                                Dd830RetDautorizacao = dd830.Dd830RetDautorizacao,
                                Dd830RetHautorizacao = dd830.Dd830RetHautorizacao,
                                Dd830RetIsautorizado = dd830.Dd830RetIsautorizado,
                                Dd830RetMsg = dd830.Dd830RetMsg,
                                Dd042Id = dd830.Dd042Id,
                                Dd072Id = dd830.Dd072Id,
                                Pd014Id = dd830.Pd014Id,
                                Dd830Tptransacao = dd830.Dd830Tptransacao,
                                Dd830RetDcanc = dd830.Dd830RetDcanc,
                                Dd830RetHcanc = dd830.Dd830RetHcanc,
                                Dd830Inferp = dd830.Dd830Inferp,
                                Dd830VendaId = dd830.Dd830VendaId,
                                Dd830Codgbandsitef = dd830.Dd830Codgbandsitef,
                                Dd830IdEsitef = dd830.Dd830IdEsitef,
                                Dd830Tpregistro = dd830.Dd830Tpregistro,
                                Dd830Tipo = dd830.Dd830Tipo
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