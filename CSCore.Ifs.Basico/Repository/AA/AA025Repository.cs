using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA025Repository(AppDbContext context) : IAA025Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa025> CreateAsync(CSICP_Aa025 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa025?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Aa025>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Aa025> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa025> RemoveAsync(CSICP_Aa025 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa025> UpdateAsync(CSICP_Aa025 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Aa025> ChangeActive(CSICP_Aa025 entity)
        {
            entity.Aa025Isactive = !entity.Aa025Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa025> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Aa025> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa025Descricao ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Aa025Codigopais.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Aa025> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa025s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Aa025Descricao);
        }

        private async Task<CSICP_Aa025?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
