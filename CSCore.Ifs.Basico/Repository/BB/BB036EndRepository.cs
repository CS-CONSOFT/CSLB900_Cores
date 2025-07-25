using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB036EndRepository(AppDbContext context) : IBB036EndRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb036Ender> CreateAsync(CSICP_Bb036Ender entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_Bb036Ender>> GetAllByParentId(string parentId, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpBb036Enders
                          .AsSplitQuery()
                          .AsNoTracking()
                          .Where(c => c.TenantId == tenant && c.Bb036Id == parentId)
                          .Include(c => c.Bb036Candidato)
                          .AsQueryable()
                          .ToListAsync();
        }

        public async Task<CSICP_Bb036Ender?> GetEntityAsync(string pkId, int tenant)
        {
            return await CreateBaseQuery(tenant, pkId).FirstOrDefaultAsync();
        }

        public async Task<CSICP_Bb036Ender> RemoveAsync(CSICP_Bb036Ender entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_Bb036Ender> CreateBaseQuery(int tenant, string id)
        {
            return _appDbContext.OsusrE9aCsicpBb036Enders
                .AsNoTracking()
                .Where(c => c.TenantId == tenant)
                .Where(c => c.Bb036Id == id)
                .Include(c => c.Bb036Candidato);
        }
    }
}

