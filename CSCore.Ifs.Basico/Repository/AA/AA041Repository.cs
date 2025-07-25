using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA041Repository(AppDbContext context) : IAA041Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa041> CreateAsync(CSICP_Aa041 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa041?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Aa041>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Aa041> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa041> RemoveAsync(CSICP_Aa041 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa041> UpdateAsync(CSICP_Aa041 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private static IQueryable<CSICP_Aa041> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Aa041> query)
        {
            if (search != null)
            {
                query = query
                     .Where(entity => (entity.Aa041Descricao ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                              .Where(entity => (entity.Aa041Codigo ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Aa041> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa041s
            .AsSplitQuery()
            .AsNoTracking()
            .Include(e => e.Aa041Tabsped)
            .Where(e => e.TenantId == tenant);
        }


        private async Task<CSICP_Aa041?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Aa041Id == long.Parse(id));
        }
    }
}

