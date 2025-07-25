using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB002Repository(AppDbContext context) : IBB002Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB002> CreateAsync(CSICP_BB002 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB002?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_BB002>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_BB002> q1 = CreateBaseQuery(tenant).AsQueryable();
            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_BB002> RemoveAsync(CSICP_BB002 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB002> UpdateAsync(CSICP_BB002 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_BB002> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_BB002> query)
        {
            if (search != null)
            {
                query = query
                   .Where(entity => (entity.Bb002Grupoempresa ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb002Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_BB002> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb002s.AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb002Grupoempresa);
        }

        private async Task<CSICP_BB002?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
