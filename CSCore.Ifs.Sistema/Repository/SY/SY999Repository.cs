using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY999Repository : ISY999Repository
    {
        private AppDbContext _appDbContext;

        public SY999Repository(AppDbContext context) => _appDbContext = context;

       
        public async Task<Csicp_Sy999> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        private IQueryable<Csicp_Sy999> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy999s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy999> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }


    }
}
