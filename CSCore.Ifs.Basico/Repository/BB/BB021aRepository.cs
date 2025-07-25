using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB021aRepository(AppDbContext context) : IBB021aRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb021a> CreateAsync(CSICP_Bb021a entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb021a?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb021a>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_Bb021a> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb021a> RemoveAsync(CSICP_Bb021a entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb021a> UpdateAsync(CSICP_Bb021a entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private static IQueryable<CSICP_Bb021a> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_Bb021a> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb021aTabela ?? "").Contains(search ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb021a> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb021as
            .Where(e => e.TenantId == tenant)
            .AsNoTracking();
        }


        private async Task<CSICP_Bb021a?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

