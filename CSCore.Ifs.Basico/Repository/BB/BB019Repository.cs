using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB019Repository(AppDbContext context) : IBB019Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb019> CreateAsync(CSICP_Bb019 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb019?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb019>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb019> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb019> RemoveAsync(CSICP_Bb019 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb019> UpdateAsync(CSICP_Bb019 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb019> ChangeActive(CSICP_Bb019 entity)
        {
            entity.Bb019Isactive = !entity.Bb019Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb019> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb019> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb019Administradora ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query.Where(entity => (entity.Bb019Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb019Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb019> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb019s
                .AsSplitQuery()
                .Include(e => e.NavCSICP_Bb019Tipo)
                .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb019Administradora);
        }
        private async Task<CSICP_Bb019?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
