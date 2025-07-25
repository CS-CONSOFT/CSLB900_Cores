using CSCore.Application.Dto.Dtos;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{


    public class GG008RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG008>(appDbContext), IGG008Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;


        public async Task<CSICP_GG008?> GetByIdAsync(string gg008ID, int tenant)
        {
            IQueryable<CSICP_GG008> query = GetQueryParaLista(tenant);
            query = query.AsNoTracking();

            CSICP_GG008? cSICP_GG008 = await query.FirstOrDefaultAsync(e => e.Id == gg008ID);
            return cSICP_GG008;
        }


        public async Task<(IEnumerable<CSICP_GG008>, int)> GetListAsync(
            int tenant,
            int pageSize, int page,
            string? search,
            decimal? codigo,
            string? grupoDescricao,
            string? classeDescricao,
            string? marcaDescricao,
            string? artigoDescricao,
            bool? isForaDaLinha,
            string? subGrupoDescricao,
            bool? isEComerce,
            bool? isActive,
            bool? isComNcm)
        {
            IQueryable<CSICP_GG008> query = GetQueryParaLista(tenant);
            query = query.AsNoTracking();

            query = FiltraQuandoExisteFiltros
                (search,
                codigo,
                query,
                grupoDescricao,
                classeDescricao,
                marcaDescricao,
                artigoDescricao,
                isForaDaLinha,
                subGrupoDescricao,
                isEComerce,
                isActive,
                isComNcm);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.OrderBy(x => x.Id);
            query = query.PaginacaoNoBanco(page, pageSize);
            List<CSICP_GG008> csicpGg008List = await query.ToListAsync();
            return (csicpGg008List, count);
        }


        /// <summary>
        /// Pesquisa de produtos
        /// </summary>
        public async Task<(IEnumerable<RepoDtoResponseGG008Kdx>, int)> GetQueryParaListaComKardex(
            PrmPesquisaProdutos prmPesquisaProdutos)
        {
            IQueryable<RepoDtoResponseGG008Kdx> query_2 = GetQueryParaListaComKardexESaldo(
                prmPesquisaProdutos.tenant, prmPesquisaProdutos.in_estabelecimentoLogadoID,
                prmPesquisaProdutos.isSomenteComSaldo, prmPesquisaProdutos.codigoBarraGG019);


            query_2 = FiltraQuandoExisteFiltros
                (prmPesquisaProdutos.search,
                prmPesquisaProdutos.codigo,
                query_2,
                prmPesquisaProdutos.grupoDescricao,
                prmPesquisaProdutos.classeDescricao,
                prmPesquisaProdutos.marcaDescricao,
                prmPesquisaProdutos.artigoDescricao,
                prmPesquisaProdutos.isForaDaLinha,
                prmPesquisaProdutos.subGrupoDescricao,
                prmPesquisaProdutos.isEComerce,
                prmPesquisaProdutos.isActive,
                prmPesquisaProdutos.isComNcm);

            var queryCount = query_2;
            var count = queryCount.Count();

            query_2 = query_2.OrderBy(x => x.Id);
            query_2 = query_2.PaginacaoNoBanco(prmPesquisaProdutos.page, prmPesquisaProdutos.pageSize);
            List<RepoDtoResponseGG008Kdx> csicpGg008List = await query_2.ToListAsync();
            return (csicpGg008List, count);
        }


        private IQueryable<CSICP_GG008> GetQueryParaLista(int tenant)
        {
            return from _GG008 in _appDbContext.OsusrE9aCsicpGg008s
                   where _GG008.TenantId == tenant

                   join _GG003 in _appDbContext.OsusrE9aCsicpGg003s
                   on _GG008.Gg008Grupoid equals _GG003.Id into _GG008_003_JOIN
                   from _GG003 in _GG008_003_JOIN.DefaultIfEmpty()

                   join _GG002 in _appDbContext.OsusrE9aCsicpGg002s
                  on _GG008.Gg008Tipoprodutoid equals _GG002.Id into _GG008_002_JOIN
                   from _GG002 in _GG008_002_JOIN.DefaultIfEmpty()

                   join _GG021 in _appDbContext.OsusrE9aCsicpGg021s
                   on _GG008.Gg008Ncmid equals _GG021.Id into _GG008_021_JOIN
                   from _GG021 in _GG008_021_JOIN.DefaultIfEmpty()

                   join _GG021Cest in _appDbContext.OsusrE9aCsicpGg021cests
                   on _GG021.Gg021CestId equals _GG021Cest.Id into _GG021_021Cest_JOIN
                   from _GG021Cest in _GG021_021Cest_JOIN.DefaultIfEmpty()

                   join _GG015 in _appDbContext.OsusrE9aCsicpGg015s
                   on _GG008.Gg008Subgrupoid equals _GG015.Id into _GG008_015_JOIN
                   from _GG015 in _GG008_015_JOIN.DefaultIfEmpty()

                   join _GG006 in _appDbContext.OsusrE9aCsicpGg006s
                   on _GG008.Gg008Marcaid equals _GG006.Id into _GG008_006_JOIN
                   from _GG006 in _GG008_006_JOIN.DefaultIfEmpty()

                   join _GG005 in _appDbContext.OsusrE9aCsicpGg005s
                   on _GG008.Gg008Artigoid equals _GG005.Id into _GG008_005_JOIN
                   from _GG005 in _GG008_005_JOIN.DefaultIfEmpty()

                   join _GG004 in _appDbContext.OsusrE9aCsicpGg004s
                   on _GG008.Gg008Classeid equals _GG004.Id into _GG008_004_JOIN
                   from _GG004 in _GG008_004_JOIN.DefaultIfEmpty()

                   join _GG011 in _appDbContext.OsusrE9aCsicpGg011s
                   on _GG008.Gg008Qualidadeid equals _GG011.Id into _GG011_JOIN
                   from _GG011 in _GG011_JOIN.DefaultIfEmpty()

                   join GG014 in _appDbContext.OsusrE9aCsicpGg014s
                     on _GG008.Gg008Linhaid equals GG014.Id into _GG008_014_JOIN
                   from GG014 in _GG008_014_JOIN.DefaultIfEmpty()

                   join GG009 in _appDbContext.OsusrE9aCsicpGg009s
                     on _GG008.Gg008Padraoid equals GG009.Id into _GG008_009_JOIN
                   from GG009 in _GG008_009_JOIN.DefaultIfEmpty()

                   join GG010 in _appDbContext.OsusrE9aCsicpGg010s
                     on _GG008.Gg008Tipoid equals GG010.Id into _GG008_010_JOIN
                   from GG010 in _GG008_010_JOIN.DefaultIfEmpty()

                   join GG029 in _appDbContext.OsusrE9aCsicpGg029s
                     on _GG008.Gg008AnpId equals GG029.Gg029Id into _GG008_029_JOIN
                   from GG029 in _GG008_029_JOIN.DefaultIfEmpty()

                   select new CSICP_GG008
                   {
                       TenantId = _GG008.TenantId,
                       Id = _GG008.Id,
                       Gg008Filialid = _GG008.Gg008Filialid,
                       Gg008Filial = _GG008.Gg008Filial,
                       Gg008Codgproduto = _GG008.Gg008Codgproduto,
                       Gg008TipoProduto = _GG008.Gg008TipoProduto,
                       Gg008CodigoGrupo = _GG008.Gg008CodigoGrupo,
                       Gg008CodigoClasse = _GG008.Gg008CodigoClasse,
                       Gg008CodigoArtigo = _GG008.Gg008CodigoArtigo,
                       Gg008CodigoMarca = _GG008.Gg008CodigoMarca,
                       Gg008CodigoPadrao = _GG008.Gg008CodigoPadrao,
                       Gg008CodigoTipo = _GG008.Gg008CodigoTipo,
                       Gg008CodigoQualidade = _GG008.Gg008CodigoQualidade,
                       Gg008Tipoprodutoid = _GG008.Gg008Tipoprodutoid,
                       Gg008Grupoid = _GG008.Gg008Grupoid,
                       Gg008Subgrupoid = _GG008.Gg008Subgrupoid,
                       Gg008Classeid = _GG008.Gg008Classeid,
                       Gg008Artigoid = _GG008.Gg008Artigoid,
                       Gg008Marcaid = _GG008.Gg008Marcaid,
                       Gg008Linhaid = _GG008.Gg008Linhaid,
                       Gg008Padraoid = _GG008.Gg008Padraoid,
                       Gg008Tipoid = _GG008.Gg008Tipoid,
                       Gg008Qualidadeid = _GG008.Gg008Qualidadeid,
                       Gg008Referencia = _GG008.Gg008Referencia,
                       Gg008Complemento = _GG008.Gg008Complemento,
                       Gg008Codindustrial = _GG008.Gg008Codindustrial,

                       Gg008Safradiamesinicio = _GG008.Gg008Safradiamesinicio,
                       Gg008SafraDiamesfim = _GG008.Gg008SafraDiamesfim,
                       Gg008Etiqueta = _GG008.Gg008Etiqueta,
                       Gg008Ncm = _GG008.Gg008Ncm,
                       Gg008ExNcm = _GG008.Gg008ExNcm,
                       Gg008Ncmid = _GG008.Gg008Ncmid,
                       Gg008PesoBruto = _GG008.Gg008PesoBruto,
                       Gg008PesoLiquido = _GG008.Gg008PesoLiquido,
                       Gg008Tamanho = _GG008.Gg008Tamanho,
                       Gg008Largura = _GG008.Gg008Largura,
                       Gg008Espessura = _GG008.Gg008Espessura,
                       Gg008Embalagem1 = _GG008.Gg008Embalagem1,
                       Gg008Embalagem2 = _GG008.Gg008Embalagem2,
                       Gg008QtdEmbalagem1 = _GG008.Gg008QtdEmbalagem1,
                       Gg008QtdEmbalagem2 = _GG008.Gg008QtdEmbalagem2,
                       Gg008Comprimentoarmaz = _GG008.Gg008Comprimentoarmaz,
                       Gg008LarguraArmaz = _GG008.Gg008LarguraArmaz,
                       Gg008AlturaArmaz = _GG008.Gg008AlturaArmaz,
                       Gg008FatorArmaz = _GG008.Gg008FatorArmaz,
                       Gg008Empilhagem = _GG008.Gg008Empilhagem,
                       Gg008Descreduzida = _GG008.Gg008Descreduzida,
                       Gg008UsaNroSerie = _GG008.Gg008UsaNroSerie,
                       Gg008Refersimilar = _GG008.Gg008Refersimilar,
                       Gg008Przgarancompra = _GG008.Gg008Przgarancompra,
                       Gg008Przgaranvenda = _GG008.Gg008Przgaranvenda,
                       Gg008Servico = _GG008.Gg008Servico,
                       Gg008Montavel = _GG008.Gg008Montavel,
                       Gg008Classifvegetal = _GG008.Gg008Classifvegetal,
                       Gg008IsActive = _GG008.Gg008IsActive,
                       Gg008EstadofisicoId = _GG008.Gg008EstadofisicoId,
                       Gg008TpgarantiacompraId = _GG008.Gg008TpgarantiacompraId,
                       Gg008TpgarantiavendaId = _GG008.Gg008TpgarantiavendaId,
                       Gg008TipokitId = _GG008.Gg008TipokitId,
                       Gg008PesavelId = _GG008.Gg008PesavelId,
                       Gg008Isforalinha = _GG008.Gg008Isforalinha,
                       Gg008Dataforalinha = _GG008.Gg008Dataforalinha,
                       Gg008ListservicoId = _GG008.Gg008ListservicoId,
                       Gg008Grpsubgrupoid = _GG008.Gg008Grpsubgrupoid,
                       Gg008Sequence = _GG008.Gg008Sequence,
                       Gg008Dultalteracao = _GG008.Gg008Dultalteracao,
                       Gg008Entregar = _GG008.Gg008Entregar,
                       Gg008Isecommerce = _GG008.Gg008Isecommerce,
                       Gg008AnpId = _GG008.Gg008AnpId,
                       Gg008Dregistro = _GG008.Gg008Dregistro,
                       Gg008Usuariopropid = _GG008.Gg008Usuariopropid,
                       Gg008Usuarioaltid = _GG008.Gg008Usuarioaltid,
                       Gg008Ierelevanteid = _GG008.Gg008Ierelevanteid,
                       Gg008Cnpjfabricante = _GG008.Gg008Cnpjfabricante,
                       Gg008Nomefabricante = _GG008.Gg008Nomefabricante,
                       Gg008Vicmsproprio = _GG008.Gg008Vicmsproprio,
                       Gg008Descespecial1 = _GG008.Gg008Descespecial1,
                       Gg008Descespecial2 = _GG008.Gg008Descespecial2,
                       NavSubGrupoProdutoGG015 = _GG015 != null ? new CSICP_GG015
                       {
                           Id = _GG015.Id,
                           Gg015Filialid = _GG015.Gg015Filialid,
                           Gg015Subgrupo = _GG015.Gg015Subgrupo,
                           Gg015IsActive = _GG015.Gg015IsActive
                       } : null,
                       NavGrupoProdutoGG003 = _GG003 != null ? new CSICP_GG003
                       {
                           Id = _GG003.Id,
                           TenantId = _GG003.TenantId,
                           Gg003Descgrupo = _GG003.Gg003Descgrupo,
                       } : null,
                       NavGG029_ANP = GG029 != null ? GG029 : null,
                       NavNCMProdutoGG021 = _GG021 != null ? new CSICP_GG021
                       {
                           TenantId = _GG021.TenantId,
                           Id = _GG021.Id,
                           Gg021Ncm = _GG021.Gg021Ncm,
                           Gg021ExNcm = _GG021.Gg021ExNcm,
                           Gg021Descricao = _GG021.Gg021Descricao,
                           Gg021Unidade = _GG021.Gg021Unidade,
                           Gg021Unid = _GG021.Gg021Unid,
                           Gg021PercIpi = _GG021.Gg021PercIpi,
                           Gg021PercIcms = _GG021.Gg021PercIcms,
                           Gg021Tipi = _GG021.Gg021Tipi,
                           Gg021ExNbm = _GG021.Gg021ExNbm,
                           Gg021IsActive = _GG021.Gg021IsActive,
                           Gg021NcmGenero = _GG021.Gg021NcmGenero,
                           Gg021Mp255Id = _GG021.Gg021Mp255Id,
                           Gg021GeneroId = _GG021.Gg021GeneroId,
                           Gg021CnaeId = _GG021.Gg021CnaeId,
                           Gg021IsinalanteId = _GG021.Gg021IsinalanteId,
                           Gg021CestId = _GG021.Gg021CestId,
                           Gg021CestN2 = _GG021.Gg021CestN2,
                           Gg021CestN3 = _GG021.Gg021CestN3,
                           Gg021PercCsll = _GG021.Gg021PercCsll,
                           Gg021PercCofins = _GG021.Gg021PercCofins,
                           Gg021PercPis = _GG021.Gg021PercPis,
                           Gg021IcmsPauta = _GG021.Gg021IcmsPauta,
                           Gg021IpiPauta = _GG021.Gg021IpiPauta,
                           Gg021AliquotaIrpj = _GG021.Gg021AliquotaIrpj,
                           Gg021Ierelevanteid = _GG021.Gg021Ierelevanteid,
                           Gg021Dtiniciovigencia = _GG021.Gg021Dtiniciovigencia,
                           Gg021Dtfimvigencia = _GG021.Gg021Dtfimvigencia,
                           NavGg021Cest = _GG021Cest
                       } : null,
                       NavMarcaProdutoGG006 = _GG006 != null ? new CSICP_GG006
                       {
                           Id = _GG006.Id,
                           TenantId = _GG006.TenantId,
                           Gg006Descmarca = _GG006.Gg006Descmarca
                       } : null,
                       NavArtigoProdutoGG005 = _GG005 != null ? _GG005 : null,
                       NavClasseProdutoGG004 = _GG004 != null ? _GG004 : null,
                       NavQualidadeProdutoGG011 = _GG011 != null ? new CSICP_GG011
                       {

                           TenantId = _GG011.TenantId,
                           Id = _GG011.Id,
                           Gg011Filial = _GG011.Gg011Filial,
                           Gg011Filialid = _GG011.Gg011Filialid,
                           Gg011CodigoQualidade = _GG011.Gg011CodigoQualidade,
                           Gg011Descricaoqualidade = _GG011.Gg011Descricaoqualidade,
                           Gg011IsActive = _GG011.Gg011IsActive,
                       } : null,
                       NavTipodeProdutosGG002 = _GG002 != null ? _GG002 : null,
                       NavPadraoProdutoGG009 = GG009 != null ? GG009 : null,
                       NavTipoPadraoProdutoGG010 = GG010 != null ? GG010 : null,
                       NavLinhaProdutoGG014 = GG014 != null ? GG014 : null
                   };
        }


        private IQueryable<RepoDtoResponseGG008Kdx> GetQueryParaListaComKardexESaldo(
            int tenant,
            string? in_estabelecimentoLogadoID,
            bool isSomenteComSaldo,
            string? codigoDeBarrasGG019)
        {
            var query_produtos =
         from _GG008 in _appDbContext.OsusrE9aCsicpGg008s
         where _GG008.TenantId == tenant

         join _GG003 in _appDbContext.OsusrE9aCsicpGg003s
             on _GG008.Gg008Grupoid equals _GG003.Id into _GG008_003_JOIN
         from _GG003 in _GG008_003_JOIN.DefaultIfEmpty()

         join _GG021 in _appDbContext.OsusrE9aCsicpGg021s
             on _GG008.Gg008Ncmid equals _GG021.Id into _GG008_021_JOIN
         from _GG021 in _GG008_021_JOIN.DefaultIfEmpty()

         join _GG021Cest in _appDbContext.OsusrE9aCsicpGg021cests
             on _GG021.Gg021CestId equals _GG021Cest.Id into _GG021_021Cest_JOIN
         from _GG021Cest in _GG021_021Cest_JOIN.DefaultIfEmpty()

         join _GG015 in _appDbContext.OsusrE9aCsicpGg015s
             on _GG008.Gg008Subgrupoid equals _GG015.Id into _GG008_015_JOIN
         from _GG015 in _GG008_015_JOIN.DefaultIfEmpty()

         join _GG006 in _appDbContext.OsusrE9aCsicpGg006s
             on _GG008.Gg008Marcaid equals _GG006.Id into _GG008_006_JOIN
         from _GG006 in _GG008_006_JOIN.DefaultIfEmpty()

         join _GG005 in _appDbContext.OsusrE9aCsicpGg005s
             on _GG008.Gg008Artigoid equals _GG005.Id into _GG008_005_JOIN
         from _GG005 in _GG008_005_JOIN.DefaultIfEmpty()

         join _GG004 in _appDbContext.OsusrE9aCsicpGg004s
             on _GG008.Gg008Classeid equals _GG004.Id into _GG008_004_JOIN
         from _GG004 in _GG008_004_JOIN.DefaultIfEmpty()

         join _GG011 in _appDbContext.OsusrE9aCsicpGg011s
             on _GG008.Gg008Qualidadeid equals _GG011.Id into _GG011_JOIN
         from _GG011 in _GG011_JOIN.DefaultIfEmpty()


         let caracteristica = (_appDbContext.OsusrE9aCsicpGg008cs
             .Where(e => e.TenantId == tenant)
             .Where(e => e.Gg008cProdutoid == _GG008.Id)
             .Where(e => e.Gg008cTiporegistro == "2")
             .FirstOrDefault())

         let fichaTecnica = (_appDbContext.OsusrE9aCsicpGg008cs
             .Where(e => e.TenantId == tenant)
             .Where(e => e.Gg008cProdutoid == _GG008.Id)
             .Where(e => e.Gg008cTiporegistro == "1")
             .FirstOrDefault())


         let imagens = (_appDbContext.OsusrE9aCsicpGg008cs
             .Where(e => e.TenantId == tenant)
             .Where(e => e.Gg008cProdutoid == _GG008.Id)
             .Where(e => e.Gg008cTiporegistro == "3")
             .ToList())

         let lerPrecosEstabelecimentoLogadoKdx = (
             from _gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
             join _gg008P in _appDbContext.OsusrE9aCsicpGg008ps
                 on _gg008Kdx.Gg008Kardexid equals _gg008P.Gg008Id
             where _gg008Kdx.TenantId == tenant
                 && _gg008Kdx.Gg008Produtoid == _GG008.Id
                 && _gg008Kdx.Gg008Filialid == in_estabelecimentoLogadoID
             select new CSICP_GG008Kdx
             {
                 TenantId = _gg008Kdx.TenantId,
                 Gg008Kardexid = _gg008Kdx.Gg008Kardexid,
                 Gg008Prcpromocional = _gg008Kdx.Gg008Prcpromocional,
                 Gg008Prcecommerce = _gg008Kdx.Gg008Prcecommerce,
                 Gg008PrcVendavarejo = _gg008Kdx.Gg008PrcVendavarejo,
                 NavGG008pOutrosPrecos = _gg008P != null ? _gg008P : null
             }).FirstOrDefault()

         let saldo = (
             from _gg520 in _appDbContext.OsusrE9aCsicpGg520s
             join _gg008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                 on _gg520.Gg520KardexId equals _gg008Kdx.Gg008Kardexid
             where _gg520.TenantId == tenant
                 && _gg008Kdx.Gg008Produtoid == _GG008.Id
                 && (_gg520.Gg520NsNumerosaldo > 0)
             select new
             {
                 _gg520.Gg520Saldo
             }
         ).Sum(s => (decimal?)s.Gg520Saldo) ?? 0

         where !isSomenteComSaldo || saldo > 0
         where string.IsNullOrEmpty(codigoDeBarrasGG019) ||
               _appDbContext.OsusrE9aCsicpGg019s.Any(g =>
                   g.Gg019Produtoid == _GG008.Id &&
                   g.Gg019Codbarrasalfa == codigoDeBarrasGG019)

         select new RepoDtoResponseGG008Kdx
         {
             TenantId = _GG008.TenantId,
             Id = _GG008.Id,
             Gg008Filialid = _GG008.Gg008Filialid,
             Gg008Filial = _GG008.Gg008Filial,
             Gg008Codgproduto = _GG008.Gg008Codgproduto,
             Gg008TipoProduto = _GG008.Gg008TipoProduto,
             CS_KardexId = lerPrecosEstabelecimentoLogadoKdx.Gg008Kardexid,
             Gg008CodigoGrupo = _GG008.Gg008CodigoGrupo,
             Gg008CodigoClasse = _GG008.Gg008CodigoClasse,
             Gg008CodigoArtigo = _GG008.Gg008CodigoArtigo,
             Gg008CodigoMarca = _GG008.Gg008CodigoMarca,
             Gg008CodigoPadrao = _GG008.Gg008CodigoPadrao,
             Gg008CodigoTipo = _GG008.Gg008CodigoTipo,
             Gg008CodigoQualidade = _GG008.Gg008CodigoQualidade,
             Gg008Tipoprodutoid = _GG008.Gg008Tipoprodutoid,
             Gg008Grupoid = _GG008.Gg008Grupoid,
             Gg008Subgrupoid = _GG008.Gg008Subgrupoid,
             Gg008Classeid = _GG008.Gg008Classeid,
             Gg008Artigoid = _GG008.Gg008Artigoid,
             Gg008Marcaid = _GG008.Gg008Marcaid,
             Gg008Linhaid = _GG008.Gg008Linhaid,
             Gg008Padraoid = _GG008.Gg008Padraoid,
             Gg008Tipoid = _GG008.Gg008Tipoid,
             Gg008Qualidadeid = _GG008.Gg008Qualidadeid,
             Gg008Referencia = _GG008.Gg008Referencia,
             Gg008Complemento = _GG008.Gg008Complemento,
             Gg008Codindustrial = _GG008.Gg008Codindustrial,
             Gg008Safradiamesinicio = _GG008.Gg008Safradiamesinicio,
             Gg008SafraDiamesfim = _GG008.Gg008SafraDiamesfim,
             Gg008Etiqueta = _GG008.Gg008Etiqueta,
             Gg008Ncm = _GG008.Gg008Ncm,
             Gg008ExNcm = _GG008.Gg008ExNcm,
             Gg008Ncmid = _GG008.Gg008Ncmid,
             Gg008PesoBruto = _GG008.Gg008PesoBruto,
             Gg008PesoLiquido = _GG008.Gg008PesoLiquido,
             Gg008Tamanho = _GG008.Gg008Tamanho,
             Gg008Largura = _GG008.Gg008Largura,
             Gg008Espessura = _GG008.Gg008Espessura,
             Gg008Embalagem1 = _GG008.Gg008Embalagem1,
             Gg008Embalagem2 = _GG008.Gg008Embalagem2,
             Gg008QtdEmbalagem1 = _GG008.Gg008QtdEmbalagem1,
             Gg008QtdEmbalagem2 = _GG008.Gg008QtdEmbalagem2,
             Gg008Comprimentoarmaz = _GG008.Gg008Comprimentoarmaz,
             Gg008LarguraArmaz = _GG008.Gg008LarguraArmaz,
             Gg008AlturaArmaz = _GG008.Gg008AlturaArmaz,
             Gg008FatorArmaz = _GG008.Gg008FatorArmaz,
             Gg008Empilhagem = _GG008.Gg008Empilhagem,
             Gg008Descreduzida = _GG008.Gg008Descreduzida,
             Gg008UsaNroSerie = _GG008.Gg008UsaNroSerie,
             Gg008Refersimilar = _GG008.Gg008Refersimilar,
             Gg008Przgarancompra = _GG008.Gg008Przgarancompra,
             Gg008Przgaranvenda = _GG008.Gg008Przgaranvenda,
             Gg008Servico = _GG008.Gg008Servico,
             Gg008Montavel = _GG008.Gg008Montavel,
             Gg008Classifvegetal = _GG008.Gg008Classifvegetal,
             Gg008IsActive = _GG008.Gg008IsActive,
             Gg008EstadofisicoId = _GG008.Gg008EstadofisicoId,
             Gg008TpgarantiacompraId = _GG008.Gg008TpgarantiacompraId,
             Gg008TpgarantiavendaId = _GG008.Gg008TpgarantiavendaId,
             Gg008TipokitId = _GG008.Gg008TipokitId,
             Gg008PesavelId = _GG008.Gg008PesavelId,
             Gg008Isforalinha = _GG008.Gg008Isforalinha,
             Gg008Dataforalinha = _GG008.Gg008Dataforalinha,
             Gg008ListservicoId = _GG008.Gg008ListservicoId,
             Gg008Grpsubgrupoid = _GG008.Gg008Grpsubgrupoid,
             Gg008Sequence = _GG008.Gg008Sequence,
             Gg008Dultalteracao = _GG008.Gg008Dultalteracao,
             Gg008Entregar = _GG008.Gg008Entregar,
             Gg008Isecommerce = _GG008.Gg008Isecommerce,
             Gg008AnpId = _GG008.Gg008AnpId,
             Gg008Dregistro = _GG008.Gg008Dregistro,
             Gg008Usuariopropid = _GG008.Gg008Usuariopropid,
             Gg008Usuarioaltid = _GG008.Gg008Usuarioaltid,
             Gg008Ierelevanteid = _GG008.Gg008Ierelevanteid,
             Gg008Cnpjfabricante = _GG008.Gg008Cnpjfabricante,
             Gg008Nomefabricante = _GG008.Gg008Nomefabricante,
             Gg008Vicmsproprio = _GG008.Gg008Vicmsproprio,
             Gg008Descespecial1 = _GG008.Gg008Descespecial1,
             Gg008Descespecial2 = _GG008.Gg008Descespecial2,
             CS_SaldoTotal = saldo,
             CS_EstabelecimentoLogadoPrecos = lerPrecosEstabelecimentoLogadoKdx,
             NavSubGrupoProdutoGG015 = _GG015 != null ? new CSICP_GG015
             {
                 Id = _GG015.Id,
                 Gg015Filialid = _GG015.Gg015Filialid,
                 Gg015Subgrupo = _GG015.Gg015Subgrupo,
                 Gg015IsActive = _GG015.Gg015IsActive
             } : null,
             NavGrupoProdutoGG003 = _GG003 != null ? new CSICP_GG003
             {
                 Id = _GG003.Id,
                 TenantId = _GG003.TenantId,
                 Gg003Descgrupo = _GG003.Gg003Descgrupo,
             } : null,
             NavNCMProdutoGG021 = _GG021 != null ? new CSICP_GG021
             {
                 TenantId = _GG021.TenantId,
                 Id = _GG021.Id,
                 Gg021Ncm = _GG021.Gg021Ncm,
                 Gg021ExNcm = _GG021.Gg021ExNcm,
                 Gg021Descricao = _GG021.Gg021Descricao,
                 Gg021Unidade = _GG021.Gg021Unidade,
                 Gg021Unid = _GG021.Gg021Unid,
                 Gg021PercIpi = _GG021.Gg021PercIpi,
                 Gg021PercIcms = _GG021.Gg021PercIcms,
                 Gg021Tipi = _GG021.Gg021Tipi,
                 Gg021ExNbm = _GG021.Gg021ExNbm,
                 Gg021IsActive = _GG021.Gg021IsActive,
                 Gg021NcmGenero = _GG021.Gg021NcmGenero,
                 Gg021Mp255Id = _GG021.Gg021Mp255Id,
                 Gg021GeneroId = _GG021.Gg021GeneroId,
                 Gg021CnaeId = _GG021.Gg021CnaeId,
                 Gg021IsinalanteId = _GG021.Gg021IsinalanteId,
                 Gg021CestId = _GG021.Gg021CestId,
                 Gg021CestN2 = _GG021.Gg021CestN2,
                 Gg021CestN3 = _GG021.Gg021CestN3,
                 Gg021PercCsll = _GG021.Gg021PercCsll,
                 Gg021PercCofins = _GG021.Gg021PercCofins,
                 Gg021PercPis = _GG021.Gg021PercPis,
                 Gg021IcmsPauta = _GG021.Gg021IcmsPauta,
                 Gg021IpiPauta = _GG021.Gg021IpiPauta,
                 Gg021AliquotaIrpj = _GG021.Gg021AliquotaIrpj,
                 Gg021Ierelevanteid = _GG021.Gg021Ierelevanteid,
                 Gg021Dtiniciovigencia = _GG021.Gg021Dtiniciovigencia,
                 Gg021Dtfimvigencia = _GG021.Gg021Dtfimvigencia,
                 NavGg021Cest = _GG021Cest
             } : null,
             NavMarcaProdutoGG006 = _GG006 != null ? new CSICP_GG006
             {
                 Id = _GG006.Id,
                 TenantId = _GG006.TenantId,
                 Gg006Descmarca = _GG006.Gg006Descmarca
             } : null,
             NavArtigoProdutoGG005 = _GG005 != null ? _GG005 : null,
             NavClasseProdutoGG004 = _GG004 != null ? _GG004 : null,
             NavQualidadeProdutoGG011 = _GG011 != null ? new CSICP_GG011
             {
                 TenantId = _GG011.TenantId,
                 Id = _GG011.Id,
                 Gg011Filial = _GG011.Gg011Filial,
                 Gg011Filialid = _GG011.Gg011Filialid,
                 Gg011CodigoQualidade = _GG011.Gg011CodigoQualidade,
                 Gg011Descricaoqualidade = _GG011.Gg011Descricaoqualidade,
                 Gg011IsActive = _GG011.Gg011IsActive,
             } : null,
             CS_NavCaracteristica = caracteristica ?? null,
             CS_NavFichaTecnica = fichaTecnica ?? null,
             CS_NavListImagens = imagens
         };

            if (in_estabelecimentoLogadoID != null)
                query_produtos = query_produtos.Where(e => e.Gg008Filialid == in_estabelecimentoLogadoID);

            return query_produtos;
        }


        private static IQueryable<CSICP_GG008> FiltraQuandoExisteFiltros(
            string? search,
            decimal? codigo,
            IQueryable<CSICP_GG008> query,
            string? grupoDescricao,
            string? classeDescricao,
            string? marcaDescricao,
            string? artigoDescricao,
            bool? isForaDaLinha,
            string? subGrupoDescricao,
            bool? isEComerce,
            bool? isActive,
            bool? isComNcm)
        {
            query = query.Where(e => e.Gg008IsActive == isActive);

            if (search != null) query = query
                    .Where(entity => (entity.Gg008Descreduzida ?? "").Contains(search ?? ""));

            if (codigo != null) query = query.Where(entity => entity.Gg008Codgproduto == codigo);

            if (grupoDescricao != null) query = query
                    .Where(e => e.NavGrupoProdutoGG003.Gg003Descgrupo.Contains(grupoDescricao));

            if (classeDescricao != null) query = query
                    .Where(e => e.NavClasseProdutoGG004.Gg004Descclasse.Contains(classeDescricao));

            if (marcaDescricao != null) query = query
                    .Where(e => e.NavMarcaProdutoGG006.Gg006Descmarca.Contains(marcaDescricao));

            if (artigoDescricao != null) query = query
                    .Where(e => e.NavArtigoProdutoGG005.Gg005Descartigo.Contains(artigoDescricao));

            if (artigoDescricao != null) query = query
                    .Where(e => e.NavArtigoProdutoGG005.Gg005Descartigo.Contains(artigoDescricao));

            if (subGrupoDescricao != null) query = query
                    .Where(e => e.NavSubGrupoProdutoGG015.Gg015Subgrupo.Contains(subGrupoDescricao));


            if (isForaDaLinha != null) query = query.Where(e => e.Gg008Isforalinha == isForaDaLinha);

            if (isEComerce != null) query = query.Where(e => e.Gg008Isecommerce == isEComerce);

            if (isComNcm == true) query = query.Where(e => e.Gg008Ncmid != null);

            return query;
        }

        private static IQueryable<RepoDtoResponseGG008Kdx> FiltraQuandoExisteFiltros(
        string? search,
        decimal? codigo,
        IQueryable<RepoDtoResponseGG008Kdx> query,
        string? grupoDescricao,
        string? classeDescricao,
        string? marcaDescricao,
        string? artigoDescricao,
        bool? isForaDaLinha,
        string? subGrupoDescricao,
        bool? isEComerce,
        bool? isActive,
        bool? isComNcm)
        {
            query = query.Where(e => e.Gg008IsActive == isActive);

            if (search != null) query = query
                    .Where(entity => (entity.Gg008Descreduzida ?? "").Contains(search ?? ""));

            if (codigo != null) query = query.Where(entity => entity.Gg008Codgproduto == codigo);

            if (grupoDescricao != null) query = query
                    .Where(e => e.NavGrupoProdutoGG003.Gg003Descgrupo.Contains(grupoDescricao));

            if (classeDescricao != null) query = query
                    .Where(e => e.NavClasseProdutoGG004.Gg004Descclasse.Contains(classeDescricao));

            if (marcaDescricao != null) query = query
                    .Where(e => e.NavMarcaProdutoGG006.Gg006Descmarca.Contains(marcaDescricao));

            if (artigoDescricao != null) query = query
                    .Where(e => e.NavArtigoProdutoGG005.Gg005Descartigo.Contains(artigoDescricao));

            if (artigoDescricao != null) query = query
                    .Where(e => e.NavArtigoProdutoGG005.Gg005Descartigo.Contains(artigoDescricao));

            if (subGrupoDescricao != null) query = query
                    .Where(e => e.NavSubGrupoProdutoGG015.Gg015Subgrupo.Contains(subGrupoDescricao));


            if (isForaDaLinha != null) query = query.Where(e => e.Gg008Isforalinha == isForaDaLinha);

            if (isEComerce != null) query = query.Where(e => e.Gg008Isecommerce == isEComerce);

            if (isComNcm == true) query = query.Where(e => e.Gg008Ncmid != null);

            return query;
        }


        public async Task<CSICP_GG008> PrepararEntidadeAntesDeCriarAsync(CSICP_GG008 entity)
        {
            if (entity.Gg008Codgproduto == 0 || entity.Gg008Codgproduto == null)
            {
                int? ultimoCodigoGG000 = await _appDbContext.OsusrE9aCsicpGg000s
                    .Where(e => e.TenantId == entity.TenantId)
                    .MaxAsync(e => e.Gg000Ultcodigo);

                entity.Gg008Codgproduto = ultimoCodigoGG000 + 1;
            }

            bool codigoJaExisite = await _appDbContext.OsusrE9aCsicpGg008s
                .AnyAsync(e => e.TenantId == entity.TenantId
                && e.Gg008Codgproduto == entity.Gg008Codgproduto);

            if (codigoJaExisite)
                throw new InvalidDataException("Este código já existe!");

            return entity;
        }

        public async Task<bool> VerificaSeCodigoJaExiste(int codigo, int tenant)
        {
            bool existeCodigo = await _appDbContext.OsusrE9aCsicpGg008s
                .AnyAsync(e => e.TenantId == tenant
                && e.Gg008Codgproduto == codigo);
            return existeCodigo;
        }
    }
}

