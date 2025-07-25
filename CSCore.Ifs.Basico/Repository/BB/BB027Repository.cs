using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB027Repository(AppDbContext context) : IBB027Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb027> CreateAsync(CSICP_Bb027 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb027?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb027>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Bb027> q1 = CreateBaseQuery(tenant)

                .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb027> RemoveAsync(CSICP_Bb027 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb027> UpdateAsync(CSICP_Bb027 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Bb027> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Bb027> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb027Descricao ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb027Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb027> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb027s
                .AsSplitQuery()
                .AsNoTracking()
                 .Include(e => e.Bb027Tdevolucao)
            .Where(e => e.TenantId == tenant);
        }

        private async Task<CSICP_Bb027?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
