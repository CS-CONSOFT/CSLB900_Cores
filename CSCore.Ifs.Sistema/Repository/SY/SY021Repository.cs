using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY021Repository : ISY021Repository
    {
        private AppDbContext _appDbContext;

        public SY021Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy021> CreateAsync(Csicp_Sy021 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    
        public async Task<Csicp_Sy021> RemoveAsync(Csicp_Sy021 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
  
        private IQueryable<Csicp_Sy021> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy021s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }
 
        public async Task<Csicp_Sy021> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        
        private async Task<Csicp_Sy021> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Sy021Id == id);
        }
    }
}
