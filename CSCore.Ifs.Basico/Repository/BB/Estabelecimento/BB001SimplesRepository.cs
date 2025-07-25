using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Estabelecimento;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB001SimplesRepository(AppDbContext context) : IBB001SplsRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB001Spls> CreateAsync(CSICP_BB001Spls entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_BB001Spls>> GetAllByParentId(string parentId, int tenant)
        {
            return await CreateBaseQueryParent(tenant, parentId).Include(e => e.Bb001Simplespart).ToListAsync();
        }

        public async Task<CSICP_BB001Spls?> GetEntityAsync(string pkId, int tenant)
        {
            return await CreateBaseQuery(tenant, pkId).FirstOrDefaultAsync();
        }

        public async Task<CSICP_BB001Spls> RemoveAsync(CSICP_BB001Spls entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_BB001Spls> CreateBaseQueryParent(int tenant, string BB001_ID)
        {
            return _appDbContext.OsusrE9aCsicpBb001Spls
                 .Where(c => c.Bb001Id == BB001_ID)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }

        private IQueryable<CSICP_BB001Spls> CreateBaseQuery(int tenant, string pkId)
        {
            return _appDbContext.OsusrE9aCsicpBb001Spls
                 .Where(c => c.Bb001SimplesId == pkId)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }
    }
}
