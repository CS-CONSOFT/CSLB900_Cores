using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA030Repository(AppDbContext context) : IAA030Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_AA030> CreateAsync(CSICP_AA030 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_AA030?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_AA030>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_AA030> q1 = CreateBaseQuery(tenant).Include(e => e.Aa030Tptoken).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_AA030> RemoveAsync(CSICP_AA030 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_AA030> UpdateAsync(CSICP_AA030 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_AA030> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_AA030> query)
        {
            if (search != null)
            {
                query = query
                     .Where(entity => (entity.Aa030Descricao ?? "").Contains(search ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_AA030> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa030Tokens
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_AA030?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .Include(e => e.Aa030Tptoken)
                .FirstOrDefaultAsync(e => e.Aa030Id == long.Parse(id));
        }
    }
}
