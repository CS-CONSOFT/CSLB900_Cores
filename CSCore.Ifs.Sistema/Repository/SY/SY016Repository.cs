using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY016Repository : ISY016Repository
    {
        private AppDbContext _appDbContext;

        public SY016Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy016> CreateAsync(Csicp_Sy016 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    
        public async Task<Csicp_Sy016> RemoveAsync(Csicp_Sy016 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy016> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy016> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy016s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy016> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
