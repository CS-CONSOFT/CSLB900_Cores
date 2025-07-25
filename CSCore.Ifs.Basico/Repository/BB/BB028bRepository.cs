using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB028bRepository(AppDbContext context) : IBB028bRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb028b> CreateAsync(CSICP_Bb028b entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb028b?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb028b>> GetListAsync(int tenant, int? searchCode)
        {
            IQueryable<CSICP_Bb028b> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(searchCode, q1);
            return await q1.ToListAsync();
        }


        public async Task<IEnumerable<CSICP_Bb028b>> GetListAsyncByBB028(int tenant, string BB028CompradorID)
        {
            IQueryable<CSICP_Bb028b> q1 = CreateBaseQuery(tenant)
                .Where(e => e.Bb028bCompradorId == BB028CompradorID)
                .AsQueryable();
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb028b> RemoveAsync(CSICP_Bb028b entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb028b> UpdateAsync(CSICP_Bb028b entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Bb028b> FiltraQuandoExisteFiltros(int? searchCode, IQueryable<CSICP_Bb028b> query)
        {
            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb028bCodresponsavel.ToString() ?? "").Contains(searchCode.ToString() ?? "")
                   || (entity.Bb028bCodigocliente.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb028b> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb028bs
            .Where(e => e.TenantId == tenant)
            .Include(e => e.NavBB012)
            .AsNoTracking();
        }

        private async Task<CSICP_Bb028b?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
