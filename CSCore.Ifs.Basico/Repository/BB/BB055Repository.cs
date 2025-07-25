using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB055Repository(AppDbContext context) : IBB055Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb055> CreateAsync(CSICP_Bb055 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb055?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb055>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb055> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb055> RemoveAsync(CSICP_Bb055 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb055> UpdateAsync(CSICP_Bb055 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb055> ChangeActive(CSICP_Bb055 entity)
        {
            entity.Bb055IsActive = !entity.Bb055IsActive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb055> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb055> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb055Nome ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb055IsActive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb055> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb055s.AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb055Nome);
        }

        private async Task<CSICP_Bb055?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb055Id == id);
        }
    }
}

