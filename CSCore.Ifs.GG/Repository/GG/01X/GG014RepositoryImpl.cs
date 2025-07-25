using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG014RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG014>(appDbContext),
        IGG014Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG014?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg014s
                  .Where(e => e.TenantId == tenant).AsNoTracking()
                  .Where(e => e.Id == id)
                  .Include(e => e.NavFilialBB001)
                  .FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG014>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, bool isActive)
        {
            IQueryable<CSICP_GG014> query = _appDbContext.OsusrE9aCsicpGg014s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .AsQueryable()
                 .OrderBy(e => e.Gg014Linha);

            query = FiltraQuandoExisteFiltros(search, query, isActive);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG014> FiltraQuandoExisteFiltros
            (string? search, IQueryable<CSICP_GG014> query, bool isAtivo)
        {
            query = query.Where(e => e.Gg014IsActive == isAtivo);
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg014Linha ?? "").Contains(search ?? ""));
            }

            return query;
        }

    }
}
