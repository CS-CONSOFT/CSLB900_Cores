using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._03X
{
    public class GG031RepositoryImpl(AppDbContext appDbContext)
          : RepositorioBaseImpl<CSICP_GG031>(appDbContext), IGG031Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<bool> ProcessaAjustePreco(
               string movimentoId,
               int tenantId,
               int in_StID_Gg030Status_Solicitado,
               int in_StID_Gg023_Val_Venda,
               int in_StID_Gg023_Val_CustoReal,
               int in_StID_Gg023_Val_Custo,
               int in_StID_Gg023_Val_Reposicao,
               int in_StID_Gg023_Val_CustoMedio,
               int in_StID_Gg023_Val_ECommmerce,
               int in_StID_Gg030_Atendido
               )
        {
            var transaction = await _appDbContext.Database.BeginTransactionAsync();
            try
            {
                CSICP_GG030 movimento = await GetMovimento_GG030(movimentoId, tenantId, in_StID_Gg030Status_Solicitado);
                List<CSICP_GG031> getDetalhesProdutoList = await GetDetalhesProdutosList_GG031(movimentoId, tenantId);

                await PercorreDetalhesProdutosListEAtualizaPrecos(
                    tenantId,
                    in_StID_Gg023_Val_Venda,
                    in_StID_Gg023_Val_CustoReal,
                    in_StID_Gg023_Val_Custo,
                    in_StID_Gg023_Val_Reposicao,
                    in_StID_Gg023_Val_CustoMedio,
                    in_StID_Gg023_Val_ECommmerce,
                    getDetalhesProdutoList);

                movimento.Gg030Status = in_StID_Gg030_Atendido;
                _appDbContext.OsusrE9aCsicpGg030s.Update(movimento);

                List<string?> listaFiliaisID = await RecuperaListaFiliaisIdDoMovimentoAtual_GG030Est(movimentoId, tenantId);

                var combinacoesListaFiliaisID_DetalhesProduto = from filialId in listaFiliaisID
                                                                from gg031 in getDetalhesProdutoList
                                                                select new { filialId, gg031 };

                foreach (var currentCombinacao in combinacoesListaFiliaisID_DetalhesProduto)
                {
                    var currentKardex = await _appDbContext.OsusrE9aCsicpGg008Kdxes
                        .Where(x => x.Gg008Produtoid == currentCombinacao.gg031.Gg031Produtoid)
                        .Where(x => x.Gg008Filialid == currentCombinacao.filialId)
                        .FirstOrDefaultAsync()
                        ?? throw new KeyNotFoundException("Kardex nao encontrado: " + currentCombinacao.gg031.Gg031KardexId);

                    CSICP_GG008p? gg008p = await RecuperaGG008pPeloKardex(tenantId, currentCombinacao.gg031);

                    AtualizarPrecos(
                        in_StID_Gg023_Val_CustoReal,
                        in_StID_Gg023_Val_Venda,
                        in_StID_Gg023_Val_Custo,
                        in_StID_Gg023_Val_Reposicao,
                        in_StID_Gg023_Val_CustoMedio,
                        in_StID_Gg023_Val_ECommmerce,
                        currentCombinacao.gg031,
                        currentKardex,
                        gg008p,
                        _appDbContext
                        );

                    _appDbContext.OsusrE9aCsicpGg008Kdxes.Update(currentKardex);
                }
                await _appDbContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }






        public async Task<RepoDto_CSICP_GG031?> GetByIdAsync(string id, int tenant)
        {
            IQueryable<RepoDto_CSICP_GG031> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Id == id);

            RepoDto_CSICP_GG031? csicpGg031Entity = await query.FirstOrDefaultAsync();
            if (csicpGg031Entity is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            return csicpGg031Entity;
        }

        public async Task<bool> PossuiItens(string in_produtoId, string in_gg030Id, string in_kardexId, int tenant)
        {
            var temItens = await _appDbContext.OsusrE9aCsicpGg031s
               .AnyAsync(x =>
                   x.Gg031Produtoid == in_produtoId &&
                   x.Gg030Id == in_gg030Id &&
                   x.Gg031KardexId == in_kardexId &&
                   x.TenantId == tenant
               );

            return temItens;
        }


        public async Task<(IEnumerable<RepoDto_CSICP_GG031>, int)> GetListAsync
            (int tenant,
            string in_gg030_id,
            string? codigo,
            int pageSize,
            int page)
        {
            IQueryable<RepoDto_CSICP_GG031> query = CriaQueryBase(tenant);
            query = query.Where(e => e.Gg030Id == in_gg030_id);
            
            if(codigo is not null)
            {
                query = query.Where(e => e.Gg031Codbarrasalfa == codigo);
            }
            

            query = query.PaginacaoNoBanco(page, pageSize);

            int count = query.GetCountTotal();

            List<RepoDto_CSICP_GG031> listaCSICP_GG031 = await query.ToListAsync();
            return (listaCSICP_GG031, count);
        }

        private IQueryable<RepoDto_CSICP_GG031> CriaQueryBase(int tenant)
        {
            IQueryable<RepoDto_CSICP_GG031> query = from GG031 in _appDbContext.OsusrE9aCsicpGg031s
                                                    where GG031.TenantId == tenant

                                                    join BB001 in _appDbContext.E9ACSICP_BB001s
                                                    on GG031.Gg031Filialid equals BB001.Id into BB001Join
                                                    from BB001 in BB001Join.DefaultIfEmpty()

                                                    join GG030 in _appDbContext.OsusrE9aCsicpGg030s
                                                    on GG031.Gg030Id equals GG030.Id into GG030Join
                                                    from GG030 in GG030Join.DefaultIfEmpty()

                                                    join GG008Kdx in _appDbContext.OsusrE9aCsicpGg008Kdxes
                                                    on GG031.Gg031KardexId equals GG008Kdx.Gg008Kardexid into GG008KdxJoin
                                                    from GG008Kdx in GG008KdxJoin.DefaultIfEmpty()

                                                    join GG008 in _appDbContext.OsusrE9aCsicpGg008s
                                                    on GG008Kdx.Gg008Produtoid equals GG008.Id into GG008Join
                                                    from GG008 in GG008Join.DefaultIfEmpty()

                                                    join GG023Val in _appDbContext.OsusrE9aCsicpGg023Vals
                                                    on GG031.Gg031PrecoajusteId equals GG023Val.Id into GG023ValJoin
                                                    from GG023Val in GG023ValJoin.DefaultIfEmpty()


                                                    select new RepoDto_CSICP_GG031
                                                    {
                                                        TenantId = GG031.TenantId,
                                                        Id = GG031.Id,
                                                        Gg031Filialid = GG031.Gg031Filialid,
                                                        Gg030Id = GG031.Gg030Id,
                                                        Gg031KardexId = GG031.Gg031KardexId,
                                                        Gg031Produto = GG031.Gg031Produto,
                                                        Gg031Produtoid = GG031.Gg031Produtoid,
                                                        Gg031Codigobarra = GG031.Gg031Codigobarra,
                                                        Gg031DataReferente = GG031.Gg031DataReferente,
                                                        Gg031PercAjuste = GG031.Gg031PercAjuste,
                                                        Gg031PrcAnterior = GG031.Gg031PrcAnterior,
                                                        Gg031PrcMovimento = GG031.Gg031PrcMovimento,
                                                        Gg031PrcCalculado = GG031.Gg031PrcCalculado,
                                                        Gg031PrecoajusteId = GG031.Gg031PrecoajusteId,
                                                        Gg031Codbarrasalfa = GG031.Gg031Codbarrasalfa,
                                                        Nav_BB001 = BB001 != null ? new CSICP_BB001
                                                        {
                                                            TenantId = BB001.TenantId,
                                                            Id = BB001.Id,
                                                            Bb001Nomefantasia = BB001.Bb001Nomefantasia,
                                                            Bb001Codigoempresa = BB001.Bb001Codigoempresa,
                                                            Bb001Razaosocial = BB001.Bb001Razaosocial,
                                                        } : null,
                                                        Nav_GG008 = GG008 != null ? new CSICP_GG008
                                                        {
                                                            TenantId = GG008.TenantId,
                                                            Id = GG008.Id,
                                                            Gg008Codgproduto = GG008.Gg008Codgproduto,
                                                            Gg008Descreduzida = GG008.Gg008Descreduzida,
                                                        } : null,
                                                        Nav_GG008_Kdx = GG008Kdx != null ? new CSICP_GG008Kdx
                                                        {
                                                            TenantId = GG008Kdx.TenantId,
                                                            Gg008Kardexid = GG008Kdx.Gg008Kardexid,
                                                            Gg008Filialid = GG008Kdx.Gg008Filialid,
                                                            Gg008Produtoid = GG008Kdx.Gg008Produtoid,
                                                            Gg008Codalmoxpadrao = GG008Kdx.Gg008Codalmoxpadrao,
                                                            Gg008Codalmtransf = GG008Kdx.Gg008Codalmtransf,
                                                            Gg008Almoxpadraoid = GG008Kdx.Gg008Almoxpadraoid,
                                                            Gg008Almoxtransfid = GG008Kdx.Gg008Almoxtransfid,
                                                            Gg008Unidade = GG008Kdx.Gg008Unidade,
                                                            Gg008Unidsecundaria = GG008Kdx.Gg008Unidsecundaria,
                                                            Gg008Unvendavarejoid = GG008Kdx.Gg008Unvendavarejoid,
                                                            Gg008Uncompravarejoid = GG008Kdx.Gg008Uncompravarejoid,
                                                            Gg008Unvendaatacadoid = GG008Kdx.Gg008Unvendaatacadoid,
                                                            Gg008FatorConversao = GG008Kdx.Gg008FatorConversao,
                                                            Gg008AliquotaIpi = GG008Kdx.Gg008AliquotaIpi,
                                                            Gg008AliquotaIcms = GG008Kdx.Gg008AliquotaIcms,
                                                            Gg008AliqIcmsReduzidaPdv = GG008Kdx.Gg008AliqIcmsReduzidaPdv,
                                                            Gg008AliquotaIss = GG008Kdx.Gg008AliquotaIss,
                                                            Gg008Margemlucrosai = GG008Kdx.Gg008Margemlucrosai,
                                                            Gg008Margemlucroent = GG008Kdx.Gg008Margemlucroent,
                                                            Gg008CalculaIrrf = GG008Kdx.Gg008CalculaIrrf,
                                                            Gg008CalculaInss = GG008Kdx.Gg008CalculaInss,
                                                            Gg008PercCsll = GG008Kdx.Gg008PercCsll,
                                                            Gg008PercCofins = GG008Kdx.Gg008PercCofins,
                                                            Gg008PercPis = GG008Kdx.Gg008PercPis,
                                                            Gg008IcmsPauta = GG008Kdx.Gg008IcmsPauta,
                                                            Gg008IpiPauta = GG008Kdx.Gg008IpiPauta,
                                                            Gg008Qtdpedidocompra = GG008Kdx.Gg008Qtdpedidocompra,
                                                            Gg008EstoqueMinimo = GG008Kdx.Gg008EstoqueMinimo,
                                                            Gg008EstoqueMaximo = GG008Kdx.Gg008EstoqueMaximo,
                                                            Gg008TempoReposicao = GG008Kdx.Gg008TempoReposicao,
                                                            Gg008PontoPedido = GG008Kdx.Gg008PontoPedido,
                                                            Gg008LoteEconomico = GG008Kdx.Gg008LoteEconomico,
                                                            Gg008GrauAtendimento = GG008Kdx.Gg008GrauAtendimento,
                                                            Gg008PercTolerancia = GG008Kdx.Gg008PercTolerancia,
                                                            Gg008Abc = GG008Kdx.Gg008Abc,
                                                            Gg008PercComissao = GG008Kdx.Gg008PercComissao,
                                                            Gg008DataFabricacao = GG008Kdx.Gg008DataFabricacao,
                                                            Gg008DataValidade = GG008Kdx.Gg008DataValidade,
                                                            Gg008DiasValidade = GG008Kdx.Gg008DiasValidade,
                                                            Gg008CustoMedio = GG008Kdx.Gg008CustoMedio,
                                                            Gg008PrecoReposicao = GG008Kdx.Gg008PrecoReposicao,
                                                            Gg008PercDescItem = GG008Kdx.Gg008PercDescItem,
                                                            Gg008Prcpromocional = GG008Kdx.Gg008Prcpromocional,
                                                            Gg008QtdPromocional = GG008Kdx.Gg008QtdPromocional,
                                                            Gg008FatorLucro = GG008Kdx.Gg008FatorLucro,
                                                            Gg008PrcVendavarejo = GG008Kdx.Gg008PrcVendavarejo,
                                                            Gg008PrcVndMercado = GG008Kdx.Gg008PrcVndMercado,
                                                            Gg008Ultreajprcvenda = GG008Kdx.Gg008Ultreajprcvenda,
                                                            Gg008PrecoVendaLiq = GG008Kdx.Gg008PrecoVendaLiq,
                                                            Gg008Vlrmargemlucro = GG008Kdx.Gg008Vlrmargemlucro,
                                                            Gg008Alteraprcvenda = GG008Kdx.Gg008Alteraprcvenda,
                                                            Gg008PrecoCusto = GG008Kdx.Gg008PrecoCusto,
                                                            Gg008Ultreajprccusto = GG008Kdx.Gg008Ultreajprccusto,
                                                            Gg008PrecoCustoReal = GG008Kdx.Gg008PrecoCustoReal,
                                                            Gg008CentroCusto = GG008Kdx.Gg008CentroCusto,
                                                            Gg008Ccustoid = GG008Kdx.Gg008Ccustoid,
                                                            Gg008ContaContabil = GG008Kdx.Gg008ContaContabil,
                                                            Gg008ClasseContabil = GG008Kdx.Gg008ClasseContabil,
                                                            Gg008FornecedorCanal = GG008Kdx.Gg008FornecedorCanal,
                                                            Gg008Fornecedorpadrao = GG008Kdx.Gg008Fornecedorpadrao,
                                                            Gg008Contaid = GG008Kdx.Gg008Contaid,
                                                            Gg008Periodicidadeinv = GG008Kdx.Gg008Periodicidadeinv,
                                                            Gg008ControlaSaldo = GG008Kdx.Gg008ControlaSaldo,
                                                            Gg008ControleLote = GG008Kdx.Gg008ControleLote,
                                                            Gg008ControleGrade = GG008Kdx.Gg008ControleGrade,
                                                            Gg008Anuente = GG008Kdx.Gg008Anuente,
                                                            Gg008Restricao = GG008Kdx.Gg008Restricao,
                                                            Gg008Grupocomprasid = GG008Kdx.Gg008Grupocomprasid,
                                                            Gg008Permsldnegativo = GG008Kdx.Gg008Permsldnegativo,
                                                            Gg008Minutaautomatica = GG008Kdx.Gg008Minutaautomatica,
                                                            Gg008Requisautomatica = GG008Kdx.Gg008Requisautomatica,
                                                            Gg008DataDesativacao = GG008Kdx.Gg008DataDesativacao,
                                                            Gg008Localizfixa = GG008Kdx.Gg008Localizfixa,
                                                            Gg008Diversos = GG008Kdx.Gg008Diversos,
                                                            Gg008AliqDifPis = GG008Kdx.Gg008AliqDifPis,
                                                            Gg008AliqDifCofins = GG008Kdx.Gg008AliqDifCofins,
                                                            Gg008EanTributavel = GG008Kdx.Gg008EanTributavel,
                                                            Gg008Untributavelid = GG008Kdx.Gg008Untributavelid,
                                                            Gg008FatorUnidade = GG008Kdx.Gg008FatorUnidade,
                                                            Gg008ValorPis = GG008Kdx.Gg008ValorPis,
                                                            Gg008ValorCofins = GG008Kdx.Gg008ValorCofins,
                                                            Gg008IsActive = GG008Kdx.Gg008IsActive,
                                                            Gg008TipoConversaoId = GG008Kdx.Gg008TipoConversaoId,
                                                            Gg008TipoprazoId = GG008Kdx.Gg008TipoprazoId,
                                                            Gg008TpContribuicaoId = GG008Kdx.Gg008TpContribuicaoId,
                                                            Gg008RiControlequalidade = GG008Kdx.Gg008RiControlequalidade,
                                                            Gg008AliquotaIrpj = GG008Kdx.Gg008AliquotaIrpj,
                                                            Gg008RetencaoAliqInss = GG008Kdx.Gg008RetencaoAliqInss,
                                                            Gg008RetencaoAliqIrrf = GG008Kdx.Gg008RetencaoAliqIrrf,
                                                            Gg008DescontoSuframa = GG008Kdx.Gg008DescontoSuframa,
                                                            Gg008Timestamp = GG008Kdx.Gg008Timestamp,
                                                            Gg008Plucro = GG008Kdx.Gg008Plucro,
                                                            Gg008IsctrlGondola = GG008Kdx.Gg008IsctrlGondola,
                                                            Gg008Qmediaconsumo = GG008Kdx.Gg008Qmediaconsumo,
                                                            Gg008Vmediaconsumo = GG008Kdx.Gg008Vmediaconsumo,
                                                            Gg008Dtultprocle = GG008Kdx.Gg008Dtultprocle,
                                                            Gg008VuncompraCmedio = GG008Kdx.Gg008VuncompraCmedio,
                                                            Gg008VuncompraReposicao = GG008Kdx.Gg008VuncompraReposicao,
                                                            Gg008VuncompraPrcvenda = GG008Kdx.Gg008VuncompraPrcvenda,
                                                            Gg008VuncompraPrcmercado = GG008Kdx.Gg008VuncompraPrcmercado,
                                                            Gg008VuncompraPrccusto = GG008Kdx.Gg008VuncompraPrccusto,
                                                            Gg008VuncompraCustoreal = GG008Kdx.Gg008VuncompraCustoreal,
                                                            Gg008VuncompraVlrmarglucro = GG008Kdx.Gg008VuncompraVlrmarglucro,
                                                            Gg008Moedaid = GG008Kdx.Gg008Moedaid,
                                                            Gg008Vmoeda = GG008Kdx.Gg008Vmoeda,
                                                            Gg008Prcecommerce = GG008Kdx.Gg008Prcecommerce,
                                                            Gg008Auditasn = GG008Kdx.Gg008Auditasn,
                                                            Gg008Possuisaldo = GG008Kdx.Gg008Possuisaldo,
                                                            Gg008Ultrecebimento = GG008Kdx.Gg008Ultrecebimento,
                                                            Gg008Qtdultrecebto = GG008Kdx.Gg008Qtdultrecebto,
                                                            Gg008UltimaVenda = GG008Kdx.Gg008UltimaVenda,
                                                            Gg008QtdeUltVenda = GG008Kdx.Gg008QtdeUltVenda,
                                                            Gg008TpcbarratribId = GG008Kdx.Gg008TpcbarratribId,
                                                        } : null ,
                                                        Nav_GG023_Val = GG023Val != null ? new CSICP_GG023Val
                                                        {

                                                            Id = GG023Val.Id,
                                                            Label = GG023Val.Label,
                                                        } : null,
                                                        Nav_GG030 = GG030 != null  ?new CSICP_GG030
                                                        {
                                                            TenantId = GG030.TenantId,
                                                            Id = GG030.Id,
                                                            Gg030Status = GG030.Gg030Status,
                                                            Gg030DataMovimento = GG030.Gg030DataMovimento,
                                                            Gg030Observacao = GG030.Gg030Observacao,
                                                        } : null
                                                    };
            return query;
        }


        private async Task<List<string?>> RecuperaListaFiliaisIdDoMovimentoAtual_GG030Est(string movimentoId, int tenantId)
        {
            return await _appDbContext.OsusrE9aCsicpGg030ests
                .Where(x => x.Gg030Id == movimentoId && x.TenantId == tenantId)
                .Select(e => e.Bb001Id)
                .ToListAsync();
        }

        private async Task<List<CSICP_GG031>> GetDetalhesProdutosList_GG031(string movimentoId, int tenantId)
        {
            var getDetalhesProdutoList = await _appDbContext.OsusrE9aCsicpGg031s
                                           .Where(x => x.Gg030Id == movimentoId && x.TenantId == tenantId)
                                           .ToListAsync();

            if (getDetalhesProdutoList.Count == 0)
                throw new Exception("Não existem produtos para o movimento: " + movimentoId + ".");
            return getDetalhesProdutoList;
        }

        private async Task<CSICP_GG030> GetMovimento_GG030(string movimentoId, int tenantId, int in_StID_Gg030Status_Solicitado)
        {
            return await _appDbContext.OsusrE9aCsicpGg030s
                .Where(x => x.Id == movimentoId && x.TenantId == tenantId)
                .Where(x => x.Gg030Status == in_StID_Gg030Status_Solicitado)
                .FirstOrDefaultAsync()
                ?? throw new Exception("Movimento não encontrado ou não está como solicitado");
        }


        private async Task PercorreDetalhesProdutosListEAtualizaPrecos(int tenantId,
            int in_StID_Gg023_Val_Venda,
            int in_StID_Gg023_Val_CustoReal,
            int in_StID_Gg023_Val_Custo,
            int in_StID_Gg023_Val_Reposicao,
            int in_StID_Gg023_Val_CustoMedio,
            int in_StID_Gg023_Val_ECommmerce,
            List<CSICP_GG031> getDetalhesProdutoList)
        {

            foreach (var current_gg031 in getDetalhesProdutoList)
            {
                var currentKardex = await _appDbContext.OsusrE9aCsicpGg008Kdxes
                    .Where(x => x.Gg008Kardexid == current_gg031.Gg031KardexId)
                    .FirstOrDefaultAsync() ?? throw new KeyNotFoundException("Kardex nao encontrado: " + current_gg031.Gg031KardexId);

                CSICP_GG008p? gg008p = await RecuperaGG008pPeloKardex(tenantId, current_gg031);

                AtualizarPrecos(
                    in_StID_Gg023_Val_CustoReal,
                    in_StID_Gg023_Val_Venda,
                    in_StID_Gg023_Val_Custo,
                    in_StID_Gg023_Val_Reposicao,
                    in_StID_Gg023_Val_CustoMedio,
                    in_StID_Gg023_Val_ECommmerce,
                    current_gg031,
                    currentKardex,
                    gg008p,
                    _appDbContext);

                _appDbContext.OsusrE9aCsicpGg008Kdxes.Update(currentKardex);
            }
        }

        private async Task<CSICP_GG008p?> RecuperaGG008pPeloKardex(int tenantId, CSICP_GG031 current)
        {
            return await _appDbContext.OsusrE9aCsicpGg008ps
                .Where(x => x.Gg008Id == current.Gg031KardexId && x.TenantId == tenantId)
                .FirstOrDefaultAsync();
        }

        private static void AtualizarPrecos(
            int in_StID_Gg023_Val_CustoReal,
            int in_StID_Gg023_Val_Venda,
            int in_StID_Gg023_Val_Custo,
            int in_StID_Gg023_Val_Reposicao,
            int in_StID_Gg023_Val_CustoMedio,
            int in_StID_Gg023_Val_ECommmerce,
            CSICP_GG031 current_gg031,
            CSICP_GG008Kdx currentKardex,
            CSICP_GG008p? currentGG008p,
            AppDbContext appDbContext)
        {
            if (current_gg031.Gg031PrecoajusteId == in_StID_Gg023_Val_CustoReal)
            {
                currentKardex.Gg008PrecoCustoReal = current_gg031.Gg031PrcMovimento;
            }
            else if (current_gg031.Gg031PrecoajusteId == in_StID_Gg023_Val_Venda)
            {
                currentKardex.Gg008PrcVendavarejo = current_gg031.Gg031PrcMovimento;
                currentKardex.Gg008Ultreajprcvenda = DateTime.UtcNow.ToLocalTime();

                if (currentGG008p is null)
                {
                    var gg008pNew = new CSICP_GG008p
                    {
                        Gg008Id = current_gg031.Gg031KardexId ?? "",
                        Gg008pPrecoBase = current_gg031.Gg031PrcMovimento,
                    };
                    appDbContext.OsusrE9aCsicpGg008ps.Add(gg008pNew);
                }
                else
                {
                    RecalculaPrecosVenda(currentGG008p);
                    appDbContext.OsusrE9aCsicpGg008ps.Update(currentGG008p);
                }
            }
            else if (current_gg031.Gg031PrecoajusteId == in_StID_Gg023_Val_Custo)
            {
                currentKardex.Gg008PrecoCusto = current_gg031.Gg031PrcMovimento;
                currentKardex.Gg008Ultreajprcvenda = DateTime.UtcNow.ToLocalTime();
            }
            else if (current_gg031.Gg031PrecoajusteId == in_StID_Gg023_Val_Reposicao)
            {
                currentKardex.Gg008PrecoReposicao = current_gg031.Gg031PrcMovimento;
            }
            else if (current_gg031.Gg031PrecoajusteId == in_StID_Gg023_Val_CustoMedio)
            {
                currentKardex.Gg008CustoMedio = current_gg031.Gg031PrcMovimento;
            }
            else if (current_gg031.Gg031PrecoajusteId == in_StID_Gg023_Val_ECommmerce)
            {
                currentKardex.Gg008Prcecommerce = current_gg031.Gg031PrcMovimento;
            }
        }

        private static void RecalculaPrecosVenda(CSICP_GG008p gg008p)
        {
            gg008p.Gg008pPrecoVenda1 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoBase * (gg008p.Gg008pPrecoVenda1 / 100)) + 1;
            gg008p.Gg008pPrecoVenda2 = CalculaPreco(gg008p.Gg008pPrecoBase, gg008p.Gg008pPrecoVenda1, gg008p.Gg008pPrecoVenda2);
            gg008p.Gg008pPrecoVenda3 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda2 * (gg008p.Gg008pPrecoVenda3 / 100)) + 1;
            gg008p.Gg008pPrecoVenda4 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda3 * (gg008p.Gg008pPrecoVenda4 / 100)) + 1;
            gg008p.Gg008pPrecoVenda5 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda4 * (gg008p.Gg008pPrecoVenda5 / 100)) + 1;
            gg008p.Gg008pPrecoVenda6 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda5 * (gg008p.Gg008pPrecoVenda6 / 100)) + 1;
            gg008p.Gg008pPrecoVenda7 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda6 * (gg008p.Gg008pPrecoVenda7 / 100)) + 1;
            gg008p.Gg008pPrecoVenda8 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda7 * (gg008p.Gg008pPrecoVenda8 / 100)) + 1;
            gg008p.Gg008pPrecoVenda9 = gg008p.Gg008pPrecoBase == 0 ? 0 : (gg008p.Gg008pPrecoVenda8 * (gg008p.Gg008pPrecoVenda9 / 100)) + 1;
        }

        private static decimal CalculaPreco(decimal? in_precoBase, decimal? in_precoVenda_init, decimal? in_precoVenda_fim)
        {
            return in_precoBase == 0 ? 0 : (in_precoVenda_init * (in_precoVenda_fim / 100)) + 1 ?? 0;
        }

    }
}
