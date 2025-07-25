using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Estabelecimento;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB001CnaeRepository(AppDbContext context) : IBB001CnaesRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB001Cnaes> CreateAsync(CSICP_BB001Cnaes entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_BB001Cnaes>> GetAllByParentId(string parentId, int tenant)
        {
            return await CreateBaseQueryParent(tenant, parentId).Include(e => e.NavCnae).ToListAsync();
        }

        public async Task<CSICP_BB001Cnaes?> GetEntityAsync(string pkId, int tenant)
        {
            return await CreateBaseQuery(tenant, pkId).FirstOrDefaultAsync();
        }

        public async Task<CSICP_BB001Cnaes> RemoveAsync(CSICP_BB001Cnaes entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_BB001Cnaes> CreateBaseQueryParent(int tenant, string BB001_ID)
        {
            return _appDbContext.OSUSR_E9A_CSICP_BB001_CNAE
                 .Where(c => c.Bb001Id == BB001_ID)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }

        private IQueryable<CSICP_BB001Cnaes> CreateBaseQuery(int tenant, string pkId)
        {
            return _appDbContext.OSUSR_E9A_CSICP_BB001_CNAE
                 .Where(c => c.Bb001PkId == pkId)
                 .Where(c => c.TenantId == tenant)
                 .AsQueryable();
        }
    }
}
