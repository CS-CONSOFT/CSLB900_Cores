using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB036Repository(AppDbContext context) : IBB036Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb036> CreateAsync(CSICP_Bb036 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb036?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb036>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb036> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb036> RemoveAsync(CSICP_Bb036 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb036> UpdateAsync(CSICP_Bb036 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb036> ChangeActive(CSICP_Bb036 entity)
        {
            entity.Bb036IsActive = !entity.Bb036IsActive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb036> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb036> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb036Descricao ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb036IsActive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb036> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb036s
                .AsSplitQuery()
            .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .Include(e => e.Bb036Atividade);
        }

        private async Task<CSICP_Bb036?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

