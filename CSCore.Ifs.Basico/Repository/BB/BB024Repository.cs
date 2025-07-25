using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB024Repository(AppDbContext context) : IBB024Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb024> CreateAsync(CSICP_Bb024 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb024?> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb024>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Bb024> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_Bb024>> GetListByBB025ID(int tenant, string bb025id)
        {
            IQueryable<CSICP_Bb024> q1 = CreateBaseQuery(tenant).AsQueryable();
            q1 = q1.Where(e => e.Bb025NatoperacaoId == bb025id);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb024> RemoveAsync(CSICP_Bb024 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb024> UpdateAsync(CSICP_Bb024 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private IQueryable<CSICP_Bb024> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb024s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.osusr66CSpedInCfop)
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb024?> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb024Id == id);
        }
    }
}
