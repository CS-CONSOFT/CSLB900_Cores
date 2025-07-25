using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY013Repository : ISY013Repository
    {
        private AppDbContext _appDbContext;

        public SY013Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy013> CreateAsync(Csicp_Sy013 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Csicp_Sy013> RemoveAsync(Csicp_Sy013 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy013> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy013> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy013s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy013?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}