using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG019RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG019>(appDbContext),
        IGG019Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG019?> GetByIdAsync(string id, string Produto_ID, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg019s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Id == id)
                 .Include(e => e.NavGG08Conversao)
                 .Include(e => e.NavGg019Tipocbarra)
                 .Include(e => e.NavGg007Un)
                 .AsSplitQuery()
                 .FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG019>, int)> GetListAsync(string Produto_ID, int tenant, int pageSize, int page)
        {
            IQueryable<CSICP_GG019> query = _appDbContext.OsusrE9aCsicpGg019s
                 .Where(e => e.TenantId == tenant)
                 .Where(e => e.Gg019Produtoid == Produto_ID)
                 .Include(e => e.NavGG08Conversao)
                 .Include(e => e.NavGg019Tipocbarra)
                 .Include(e => e.NavGg007Un)
                 .AsNoTracking()
                 .AsQueryable(); // adicionar orderby tabela codg de barras.

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }



    }
}

