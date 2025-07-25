using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA014Repository(AppDbContext context) : IAA014Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa014> CreateAsync(CSICP_Aa014 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa014?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa014s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .FirstOrDefaultAsync(e => e.Aa014Id == long.Parse(id));
        }

        public async Task<IEnumerable<CSICP_Aa014>> GetListAsync(int tenant)
        {
            IQueryable<CSICP_Aa014> q1 = _appDbContext.OsusrE9aCsicpAa014s
                 .AsNoTracking()
                 .Where(e => e.TenantId == tenant)
                 .AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa014> RemoveAsync(CSICP_Aa014 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa014> UpdateAsync(CSICP_Aa014 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}