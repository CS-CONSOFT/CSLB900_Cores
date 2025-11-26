using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG008KdxRepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG008Kdx>(appDbContext, "Gg008Kardexid"),
        IGG008KdxRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG008Kdx?> GetByIdAsync(string gg008KdxID, string produtoGG008_ID, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg008Kdxes
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Gg008Kardexid == gg008KdxID)
                .Where(e => e.Gg008Produtoid == produtoGG008_ID)
                .Include(e => e.NavGG008pOutrosPrecos)
                .Include(e => e.NavBB001Filial)
                .Include(e => e.NavGG008Produto)
                .Include(e => e.NavGG001AlmoxarifadoPadrao)
                .Include(e => e.NavGG001AlmoxarifadoTransferencia)
                .Include(e => e.NavGG007UNVendaVarejo)
                .Include(e => e.NavGG007UNCompraVarejo)
                .Include(e => e.NavGG007UNVendaAtacado)
                .Include(e => e.NavGG007UNTributavel)
                .Include(e => e.NavBB005_CCusto)
                .Include(e => e.NavBB003_Moeda)
                .Include(e => e.NavBB012_Conta)
                .Include(e => e.NavGG008_Tipo_Conversao)
                .Include(e => e.NavGG008_TipoPrazo)
                .Include(e => e.NavGG019_tpCBarraTrib)
                .Include(e => e.NavGG008_Tp_Contribuicao)
                .Include(e => e.NavGG008_AuditaSN)
                .Include(e => e.NavGG008_Desconto_SUFRAMA)
                .Include(e => e.NavGG008_Calcula_IRRF)
                .Include(e => e.NavGG008_Calcula_INSS)
                .Include(e => e.NavGG008_AlteraPrcVenda)
                .Include(e => e.NavGG008_Fornecedor_Canal)
                .Include(e => e.NavGG008_Controla_Saldo)
                .Include(e => e.NavGG008_Controle_Lote)
                .Include(e => e.NavGG008_Controle_Grade)
                .Include(e => e.NavGG008_Anuente)
                .Include(e => e.NavGG008_Restricao)
                .Include(e => e.NavGG008_PermSldNegativo)
                .Include(e => e.NavGG008_RequisAutomatica)
                .AsNoTracking()
                .AsSplitQuery()
                .FirstOrDefaultAsync();
        }

        public async Task<CSICP_GG008Kdx?> GetByIdPorEmpresaParaExibicaoAsync(string? BB001_filialID, string produtoGG008_ID, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg008Kdxes

                .Where(e => e.TenantId == tenant)
                .AsNoTracking()
                .Where(e => e.Gg008Filialid == BB001_filialID)
                .Where(e => e.Gg008Produtoid == produtoGG008_ID)
                .AsSplitQuery()
                .FirstOrDefaultAsync();
        }

        public async Task<List<CSICP_GG008Kdx>> GetListAsyncParaPesquisaParaProdutoS
            (int tenant, string produtoGG008_ID)
        {

            var lista = await _appDbContext.OsusrE9aCsicpGg008Kdxes
                                        .Where(kdx => kdx.TenantId == tenant && kdx.Gg008Produtoid == produtoGG008_ID)
                                        .Select(kdx => new CSICP_GG008Kdx
                                        {
                                            TenantId = kdx.TenantId,
                                            Gg008Kardexid = kdx.Gg008Kardexid,
                                            Gg008Produtoid = kdx.Gg008Produtoid,
                                            Gg008PrecoReposicao = kdx.Gg008PrecoReposicao,
                                            Gg008Unidade = kdx.Gg008Unidade,
                                            Gg008PrecoVendaLiq = kdx.Gg008PrecoVendaLiq,
                                            Gg008PrecoCusto = kdx.Gg008PrecoCusto,
                                            Gg008PrecoCustoReal = kdx.Gg008PrecoCustoReal,
                                            NavGG008pOutrosPrecos = _appDbContext.OsusrE9aCsicpGg008ps
                                                .Where(gg008P => gg008P.TenantId == tenant && gg008P.Gg008Id == kdx.Gg008Kardexid)
                                                .FirstOrDefault(),
                                            NavBB001Filial = _appDbContext.E9ACSICP_BB001s
                                                .Where(e => e.TenantId == tenant && e.Id == kdx.Gg008Filialid && e.Bb001Isactive == true)
                                                .FirstOrDefault()
                                        })
                                        .ToListAsync();


            return lista;
        }
        public async Task<(IEnumerable<CSICP_GG008Kdx>, int)> GetListAsync(int tenant, string produtoGG008_ID,bool? isActive, int pageSize, int page)
        {
            IQueryable<CSICP_GG008Kdx> query = PreparaQueryBaseGG008Kdx(tenant, produtoGG008_ID, isActive);
            query = query
            .Include(e => e.NavGG008pOutrosPrecos)
            .Include(e => e.NavBB001Filial)
            .Include(e => e.NavGG008Produto)
            .Include(e => e.NavGG001AlmoxarifadoPadrao)
            .Include(e => e.NavGG001AlmoxarifadoTransferencia)
            .Include(e => e.NavGG007UNVendaVarejo)
            .Include(e => e.NavGG007UNCompraVarejo)
            .Include(e => e.NavGG007UNVendaAtacado)
            .Include(e => e.NavGG007UNTributavel)
            .Include(e => e.NavBB005_CCusto)
            .Include(e => e.NavBB003_Moeda)
            .Include(e => e.NavBB012_Conta)
            .Include(e => e.NavGG008_Tipo_Conversao)
            .Include(e => e.NavGG008_TipoPrazo)
            .Include(e => e.NavGG019_tpCBarraTrib)
            .Include(e => e.NavGG008_Tp_Contribuicao)
            .Include(e => e.NavGG008_AuditaSN)
            .Include(e => e.NavGG008_Desconto_SUFRAMA)
            .Include(e => e.NavGG008_Calcula_IRRF)
            .Include(e => e.NavGG008_Calcula_INSS)
            .Include(e => e.NavGG008_AlteraPrcVenda)
            .Include(e => e.NavGG008_Fornecedor_Canal)
            .Include(e => e.NavGG008_Controla_Saldo)
            .Include(e => e.NavGG008_Controle_Lote)
            .Include(e => e.NavGG008_Controle_Grade)
            .Include(e => e.NavGG008_Anuente)
            .Include(e => e.NavGG008_Restricao)
            .Include(e => e.NavGG008_PermSldNegativo)
            .Include(e => e.NavGG008_RequisAutomatica)
            .AsSplitQuery();


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }



        public async Task<CSICP_GG008Kdx> CreateAsyncc(CSICP_GG008Kdx entity, CSICP_GG008p entity_gg008p, CSICP_GG520 cSICP_GG520)
        {
            entity.NavGG008pOutrosPrecos = null;
            _appDbContext.Add(entity);
            await CommitToDatabase();
            _appDbContext.Add(entity_gg008p);
            await CommitToDatabase();
            cSICP_GG520.TenantId = entity.TenantId;
            cSICP_GG520.NavGG001Almox = null;
            cSICP_GG520.Gg520Codbarras = null;
            cSICP_GG520.NavGG016Gradecoluna = null;
            cSICP_GG520.NavGG016Gradlinha = null;
            cSICP_GG520.Nav_GG008Kardex = null;
            _appDbContext.Add(cSICP_GG520);
            await CommitToDatabase();
            return entity;
        }
        public async Task<CSICP_GG008Kdx> UpdateMoedaAsync(string id, int tenant, string? Gg008Moedaid, decimal? valorMoeda, string produtoID)
        {
            return await AtualizaKardexApenasMoeda(id, tenant, Gg008Moedaid, valorMoeda, produtoID);
        }


        public async Task UpdateTodasMoedaAsync(int tenant, string? Gg008Moedaid, decimal? valorMoeda, string produtoID)
        {
            IQueryable<CSICP_GG008Kdx> query = PreparaQueryBaseGG008Kdx(tenant, produtoID, isActive: null);
            List<CSICP_GG008Kdx> listaKDX = await query.ToListAsync();
            listaKDX.ForEach(async curr => await AtualizaKardexApenasMoeda(curr.Gg008Kardexid, tenant, Gg008Moedaid, valorMoeda, produtoID));
        }

        public async Task<CSICP_GG008Kdx> UpdateAsync(string id, int tenant, CSICP_GG008Kdx entity, CSICP_GG008p entity_gg008p)
        {
            _appDbContext.Update(entity);
            _appDbContext.Update(entity_gg008p);
            await _appDbContext.SaveChangesAsync();

            return entity;
        }


        private async Task<CSICP_GG008Kdx> AtualizaKardexApenasMoeda(string kdxID, int tenant, string? Gg008Moedaid, decimal? valorMoeda, string produtoID)
        {
            CSICP_GG008Kdx? csicp_gg008kdx = await GetGG008KdxParaAtualizar(kdxID, tenant, produtoID);

            csicp_gg008kdx.Gg008Moedaid = Gg008Moedaid;
            csicp_gg008kdx.Gg008Vmoeda = valorMoeda;

            _appDbContext.Update(csicp_gg008kdx);
            await CommitToDatabase();
            return csicp_gg008kdx;
        }

        private async Task<CSICP_GG008Kdx> GetGG008KdxParaAtualizar(string id, int tenant, string produtoID)
        {
            CSICP_GG008Kdx? csicp_gg008kdx = await _appDbContext.OsusrE9aCsicpGg008Kdxes
                            .Where(e => e.TenantId == tenant)
                            .Where(e => e.Gg008Produtoid == produtoID)
                            .Where(e => e.Gg008Kardexid == id).FirstOrDefaultAsync();
            if (csicp_gg008kdx is null) throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);
            return csicp_gg008kdx;
        }

        private IQueryable<CSICP_GG008Kdx> PreparaQueryBaseGG008Kdx(int tenant, string produtoGG008_ID, bool? isActive)
        {
            var query = _appDbContext.OsusrE9aCsicpGg008Kdxes
                             .Where(e => e.TenantId == tenant)
                             .Where(e => e.Gg008Produtoid == produtoGG008_ID)
                             .AsNoTracking();
            if(isActive != null) query = query.Where(e => e.Gg008IsActive== isActive);
            return query;
        }

        public async Task<CSICP_GG008Kdx?> GetByIdSimplesParaAtualizarAsync(string gg008KdxID, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg008Kdxes
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Gg008Kardexid == gg008KdxID)
                .FirstOrDefaultAsync();
        }
    }
}
