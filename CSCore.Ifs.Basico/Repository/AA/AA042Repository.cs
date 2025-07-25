using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA042Repository(AppDbContext context) : IAA042Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa042> CreateAsync(CSICP_Aa042 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa042?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Aa042>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Aa042> q1 = CreateBaseQuery(tenant).AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa042> RemoveAsync(CSICP_Aa042 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa042> UpdateAsync(CSICP_Aa042 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_Aa042> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa042s
            .AsSplitQuery()
            .AsNoTracking()
            .Include(e => e.Aa042Cfop)
            .Include(e => e.Aa042Coddecla)
            .Include(e => e.Aa042Cst)
            .Include(e => e.Aa042CstOrigem)
            .Include(e => e.Uf)
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Aa042?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Aa042Id == long.Parse(id));
        }
    }
}
