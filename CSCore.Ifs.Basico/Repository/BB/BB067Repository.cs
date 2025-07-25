using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB067Repository(AppDbContext context) : IBB067Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb067> CreateAsync(CSICP_Bb067 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb067?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb067>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_Bb067> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb067> RemoveAsync(CSICP_Bb067 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb067> UpdateAsync(CSICP_Bb067 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }




        private static IQueryable<CSICP_Bb067> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_Bb067> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb067Descricao ?? "").Contains(search ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb067> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb067s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant); //verificar
        }

        private async Task<CSICP_Bb067?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb067Id == long.Parse(id));
        }
    }
}

