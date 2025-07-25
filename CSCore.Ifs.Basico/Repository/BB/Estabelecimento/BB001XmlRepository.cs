using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Estabelecimento;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB001XmlRepository(AppDbContext context) : IBB001XmlRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB001_AXML> CreateAsync(CSICP_BB001_AXML entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_BB001_AXML>> GetAllByParentId(string parentId, int tenant)
        {
            return await CreateBaseQueryParent(tenant, parentId).AsQueryable().ToListAsync();
        }

        public async Task<CSICP_BB001_AXML?> GetEntityAsync(string pkId, int tenant)
        {
            return await CreateBaseQuery(tenant, long.Parse(pkId)).AsQueryable().FirstOrDefaultAsync();
        }

        public async Task<CSICP_BB001_AXML> RemoveAsync(CSICP_BB001_AXML entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_BB001_AXML> CreateBaseQueryParent(int tenant, string BB001_ID)
        {
            return _appDbContext.E9ACSICP_BB001Axmls
                 .Where(c => c.Bb001aEstabid == BB001_ID)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }

        private IQueryable<CSICP_BB001_AXML> CreateBaseQuery(int tenant, long pkId)
        {
            return _appDbContext.E9ACSICP_BB001Axmls
                 .Where(c => c.Bb001aId == pkId)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }
    }
}
