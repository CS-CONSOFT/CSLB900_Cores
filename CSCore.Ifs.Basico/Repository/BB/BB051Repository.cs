using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB051Repository(AppDbContext context) : IBB051Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb051> CreateAsync(CSICP_Bb051 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb051?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb051>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb051> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb051> RemoveAsync(CSICP_Bb051 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb051> UpdateAsync(CSICP_Bb051 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private IQueryable<CSICP_Bb051> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb051s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.Bb050)
                .Include(e => e.Bb051Formapagto)
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb051?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb051Id == id);
        }
    }
}

