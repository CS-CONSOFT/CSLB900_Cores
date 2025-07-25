using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY005Repository : ISY005Repository
    {
        private AppDbContext _appDbContext;

        public SY005Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy005> CreateAsync(Csicp_Sy005 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Csicp_Sy005> RemoveAsync(Csicp_Sy005 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy005> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }
        private IQueryable<Csicp_Sy005> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy005s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy005?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
