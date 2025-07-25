using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA024Repository(AppDbContext context) : IAA024Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa024> CreateAsync(CSICP_Aa024 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa024?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Aa024>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Aa024> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa024> RemoveAsync(CSICP_Aa024 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa024> UpdateAsync(CSICP_Aa024 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa024> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Aa024> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa024NomeUdh ?? "").Contains(search ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Aa024> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa024s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.NavAA028)
                .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Aa024?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == long.Parse(id));
        }

    }
}
