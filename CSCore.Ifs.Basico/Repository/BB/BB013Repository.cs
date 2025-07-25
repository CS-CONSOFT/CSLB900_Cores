using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB013Repository(AppDbContext context) : IBB013Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb013> CreateAsync(CSICP_Bb013 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb013?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb013>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Bb013> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb013> RemoveAsync(CSICP_Bb013 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb013> UpdateAsync(CSICP_Bb013 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Bb013> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Bb013> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb013Bairro ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb013Codgcidade ?? "").ToString()!.Contains(searchCode.ToString() ?? "") ||
                   (entity.Bb013Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }


            return query;
        }


        private IQueryable<CSICP_Bb013> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb013s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }
        private async Task<CSICP_Bb013?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
