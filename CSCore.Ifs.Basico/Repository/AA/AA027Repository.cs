using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA027Repository(AppDbContext context) : IAA027Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa027> CreateAsync(CSICP_Aa027 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa027?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<CSICP_Aa027?> GetByIdFilterBySigla(int tenant, string sigla)
        {
            return await _appDbContext.OsusrE9aCsicpAa027s.Where(e => e.Aa027Sigla == sigla).Where(e => e.TenantId == tenant).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CSICP_Aa027>> GetListAsync(int tenant, string? search, string? paisId, string? regiaoId)
        {
            IQueryable<CSICP_Aa027> q1 = CreateBaseQuery(tenant)
                .Include(e => e.Pais).Include(e => e.Regiao).AsQueryable();

            if (paisId != null)
                q1 = q1.Where(e => e.Paisid == paisId);

            q1 = FiltraQuandoExisteFiltros(search, q1, regiaoId);

            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa027> RemoveAsync(CSICP_Aa027 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa027> UpdateAsync(CSICP_Aa027 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa027> FiltraQuandoExisteFiltros(
            string? search, IQueryable<CSICP_Aa027> query, string? regiaoId)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa027Sigla ?? "").Contains(search ?? "") ||
                           (entity.Descricao ?? "").Contains(search ?? ""));
            }

            if (regiaoId != null)
            {
                query = query.Where(e => e.Regiaoid == regiaoId);
            }


            return query;
        }


        private IQueryable<CSICP_Aa027> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa027s
            .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Aa027Sigla);
        }

        private async Task<CSICP_Aa027?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }


    }
}
