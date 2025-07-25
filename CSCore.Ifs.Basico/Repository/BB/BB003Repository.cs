using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB003Repository(AppDbContext context) : IBB003Repository
    {
        private readonly AppDbContext _appDbContext = context;
        
        public async Task<CSICP_Bb003> CreateAsync(CSICP_Bb003 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb003?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb003>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_Bb003> q1 = CreateBaseQuery(tenant).AsQueryable();
            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb003> RemoveAsync(CSICP_Bb003 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb003> UpdateAsync(CSICP_Bb003 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Bb003> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_Bb003> query)
        {
            if (search != null)
            {
                query = query
                   .Where(entity => (entity.Bb003Moeda ?? "").Contains(search ?? "") ||
                          (entity.Bb003Sigla ?? "").Contains(search ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb003> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb003s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb003?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
