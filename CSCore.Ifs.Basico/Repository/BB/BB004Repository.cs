using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB004Repository(AppDbContext context) : IBB004Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB004> CreateAsync(CSICP_BB004 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB004?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_BB004>> GetListAsync(int tenant, int? searchCode)
        {
            IQueryable<CSICP_BB004> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_BB004> RemoveAsync(CSICP_BB004 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB004> UpdateAsync(CSICP_BB004 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_BB004> FiltraQuandoExisteFiltros(int? searchCode, IQueryable<CSICP_BB004> query)
        {
            if (searchCode != null)
            {
                query = query
                    .Where(entity => (entity.Bb004Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            return query;
        }


        private IQueryable<CSICP_BB004> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb004s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_BB004?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }


    }
}


