using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY006Repository : ISY006Repository
    {
        private AppDbContext _appDbContext;

        public SY006Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy006> CreateAsync(Csicp_Sy006 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy006> RemoveAsync(Csicp_Sy006 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<Csicp_Sy006> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy006> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy006s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy006?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
