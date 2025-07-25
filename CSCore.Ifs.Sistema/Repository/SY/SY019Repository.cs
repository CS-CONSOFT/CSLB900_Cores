using CSCore.Domain.CS_Models.CSICP_SYS.Depreciadas_Tabelas;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY019Repository : ISY019Repository
    {
        private AppDbContext _appDbContext;

        public SY019Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy019> CreateAsync(Csicp_Sy019 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy019> RemoveAsync(Csicp_Sy019 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<Csicp_Sy019> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy019s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        public async Task<Csicp_Sy019> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        private async Task<Csicp_Sy019> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Sy019Id == id);
        }
    }
}
