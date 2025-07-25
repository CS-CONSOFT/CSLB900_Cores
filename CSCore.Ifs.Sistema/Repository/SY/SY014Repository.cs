using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY014Repository : ISY014Repository
    {
        private AppDbContext _appDbContext;

        public SY014Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy014> CreateAsync(Csicp_Sy014 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

    
        public async Task<Csicp_Sy014> RemoveAsync(Csicp_Sy014 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy014> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy014> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy014s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy014> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}