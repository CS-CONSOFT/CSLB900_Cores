using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB002CscRepository(AppDbContext context) : IBB002CscRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB002CSC> CreateAsync(CSICP_BB002CSC entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB002CSC?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_BB002CSC>> GetListAsync(int tenant, string bb002Id)
        {
            IQueryable<CSICP_BB002CSC> q1 = CreateBaseQuery(tenant).Where(e => e.Bb002Id == bb002Id).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_BB002CSC> RemoveAsync(CSICP_BB002CSC entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB002CSC> UpdateAsync(CSICP_BB002CSC entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private IQueryable<CSICP_BB002CSC> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb002Cscs
                .Where(e => e.TenantId == tenant)
                .AsNoTracking();
        }

        private async Task<CSICP_BB002CSC?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
