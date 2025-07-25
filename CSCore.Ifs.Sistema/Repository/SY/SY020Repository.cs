using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY020Repository : ISY020Repository
    {
        private AppDbContext _appDbContext;

        public SY020Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy020> CreateAsync(Csicp_Sy020 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy020> RemoveAsync(Csicp_Sy020 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<Csicp_Sy020> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy020s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        public async Task<Csicp_Sy020> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        private async Task<Csicp_Sy020> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Sy020Id == id);
        }
    }
}
