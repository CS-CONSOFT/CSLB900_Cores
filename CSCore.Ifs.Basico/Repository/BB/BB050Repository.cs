using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB050Repository(AppDbContext context) : IBB050Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb050> CreateAsync(CSICP_Bb050 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb050?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb050>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb050> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb050> RemoveAsync(CSICP_Bb050 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb050> UpdateAsync(CSICP_Bb050 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_Bb050> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb050s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }


        private async Task<CSICP_Bb050?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb050Id == id);
        }
    }
}

