using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB064Repository(AppDbContext context) : IBB064Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb064> CreateAsync(CSICP_Bb064 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb064?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb064>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb064> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb064> RemoveAsync(CSICP_Bb064 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb064> UpdateAsync(CSICP_Bb064 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb064> ChangeActive(CSICP_Bb064 entity)
        {
            entity.Bb064Isactive = !entity.Bb064Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb064> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb064> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb064Descricao ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb064Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb064> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb064s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb064?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb064Fxetariaid == long.Parse(id));
        }
    }
}
