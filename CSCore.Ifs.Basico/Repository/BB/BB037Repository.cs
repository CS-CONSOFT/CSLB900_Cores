using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB037Repository(AppDbContext context) : IBB037Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb037> CreateAsync(CSICP_Bb037 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb037?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb037>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb037> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb037> RemoveAsync(CSICP_Bb037 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb037> UpdateAsync(CSICP_Bb037 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb037> ChangeActive(CSICP_Bb037 entity)
        {
            entity.Bb037Isactive = !entity.Bb037Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb037> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb037> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb037Descricao ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb037Codigo ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb037Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb037> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb037s.AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb037Descricao);
        }

        private async Task<CSICP_Bb037?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
