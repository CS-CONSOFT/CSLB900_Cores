using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY009Repository : ISY009Repository
    {
        private AppDbContext _appDbContext;

        public SY009Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy009> CreateAsync(Csicp_Sy009 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

    
        public async Task<Csicp_Sy009> RemoveAsync(Csicp_Sy009 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy009> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy009> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy009s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy009> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}