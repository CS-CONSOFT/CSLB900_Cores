using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA026Repository(AppDbContext context) : IAA026Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa026> CreateAsync(CSICP_Aa026 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa026?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Aa026>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Aa026> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1
            .ToListAsync();
        }

        public async Task<CSICP_Aa026> RemoveAsync(CSICP_Aa026 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa026> UpdateAsync(CSICP_Aa026 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa026> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Aa026> query)
        {
            if (search != null)
            {
                query = query
                   .Where(entity => (entity.Aa026Descricao ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                  .Where(entity => (entity.Aa026Codigoibge.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Aa026> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa026s.AsNoTracking()
           .Where(e => e.TenantId == tenant)
           .OrderBy(e => e.Aa026Descricao);
        }

        private async Task<CSICP_Aa026?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
