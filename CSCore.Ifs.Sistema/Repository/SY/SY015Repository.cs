using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY015Repository : ISY015Repository
    {
        private AppDbContext _appDbContext;

        public SY015Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy015> CreateAsync(Csicp_Sy015 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy015> RemoveAsync(Csicp_Sy015 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy015> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy015> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy015s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy015?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
