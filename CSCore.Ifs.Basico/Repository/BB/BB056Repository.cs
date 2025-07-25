using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB056Repository(AppDbContext context) : IBB056Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb056> CreateAsync(CSICP_Bb056 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb056?> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb056>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb056> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }


        public async Task<IEnumerable<CSICP_Bb056>> GetListAsyncByBB055ID(int tenant, string bb055ID)
        {
            IQueryable<CSICP_Bb056> q1 = CreateBaseQuery(tenant)
                .AsSplitQuery()
                .Include(e => e.NavBB012)
                .Where(e => e.Bb056Profid == bb055ID)
                .AsQueryable();

            return await q1.ToArrayAsync();

        }

        public async Task<CSICP_Bb056> RemoveAsync(CSICP_Bb056 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb056> UpdateAsync(CSICP_Bb056 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb056> ChangeActive(CSICP_Bb056 entity)
        {
            entity.Bb056Isactive = !entity.Bb056Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb056> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb056> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb056Mensagem ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb056Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb056> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb056s
                .AsSplitQuery()
                .AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb056?> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant).Include(e => e.NavBB012)
                .FirstOrDefaultAsync(e => e.Bb056Id == id);
        }

    }
}
