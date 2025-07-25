using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB066Repository(AppDbContext context) : IBB066Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb066> CreateAsync(CSICP_Bb066 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb066?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb066>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb066> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb066>> GetListAsyncByBB064ID(long bb064ID, int tenant)
        {
            IQueryable<CSICP_Bb066> q1 = CreateBaseQuery(tenant).AsQueryable();
            IQueryable<CSICP_Bb066> q2 = q1.Where(e => e.Bb066Fxetariaid == bb064ID);
            return await q2.ToListAsync();
        }

        public async Task<CSICP_Bb066> RemoveAsync(CSICP_Bb066 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb066> UpdateAsync(CSICP_Bb066 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private IQueryable<CSICP_Bb066> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb066s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb066?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb066Id == long.Parse(id));
        }
    }
}
