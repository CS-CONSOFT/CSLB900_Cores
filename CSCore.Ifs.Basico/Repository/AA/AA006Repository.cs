

using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA006Repository : IAA006Repository
    {
        private AppDbContext _appDbContext;
        public AA006Repository(AppDbContext context) => _appDbContext = context;

        public async Task<CSICP_AA006> CreateAsync(CSICP_AA006 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_AA006?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa006s
                    .AsNoTracking()
                    .Include(e => e.FilialBB001)
                    .Include(e => e.Aa006CircularNavigation)
                    .AsSplitQuery()
                    .Where(e => e.TenantId == tenant)
                    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<CSICP_AA006>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_AA006> q1 = _appDbContext.OsusrE9aCsicpAa006s
                 .Where(e => e.TenantId == tenant)
                 .Include(e => e.FilialBB001)
                 .AsNoTracking()
                 .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_AA006> RemoveAsync(CSICP_AA006 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_AA006> UpdateAsync(CSICP_AA006 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private static IQueryable<CSICP_AA006> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_AA006> query)
        {
            if (search != null)
            {
                query = query
                  .Where(entity => (entity.Aa006Arquivo ?? "").Contains(search ?? ""));
            }
            return query;
        }
    }
}
