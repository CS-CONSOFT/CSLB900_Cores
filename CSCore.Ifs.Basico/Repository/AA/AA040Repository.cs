using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA040Repository(AppDbContext context) : IAA040Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa040> CreateAsync(CSICP_Aa040 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa040?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Aa040>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Aa040> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa040> RemoveAsync(CSICP_Aa040 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa040> UpdateAsync(CSICP_Aa040 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private IQueryable<CSICP_Aa040> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa040s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Aa040?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Aa040Id == id);
        }
    }
}

