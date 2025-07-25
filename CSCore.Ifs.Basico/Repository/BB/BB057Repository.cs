using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB057Repository(AppDbContext context) : IBB057Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb057> CreateAsync(CSICP_Bb057 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb057?> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb057>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb057> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb057>> GetListAsyncByBB055ID(int tenant, string bb055ID)
        {
            IQueryable<CSICP_Bb057> q1 = CreateBaseQuery(tenant)
                .AsSplitQuery()
                .Include(e => e.NavBB012)
                .Where(e => e.Bb055Id == bb055ID)
                .AsQueryable();

            return await q1.ToArrayAsync();

        }

        public async Task<CSICP_Bb057> RemoveAsync(CSICP_Bb057 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb057> UpdateAsync(CSICP_Bb057 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_Bb057> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb057s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb057?> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant).Include(e => e.NavBB012)
                .FirstOrDefaultAsync(e => e.Bb057Id == id);
        }
    }
}
