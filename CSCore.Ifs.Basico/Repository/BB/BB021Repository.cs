using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB021Repository(AppDbContext context) : IBB021Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb021> CreateAsync(CSICP_Bb021 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb021?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb021>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Bb021> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb021> RemoveAsync(CSICP_Bb021 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb021> UpdateAsync(CSICP_Bb021 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private static IQueryable<CSICP_Bb021> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Bb021> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb021NomeAutorizador ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb021Codautorizador.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb021> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb021s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }


        private async Task<CSICP_Bb021?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

