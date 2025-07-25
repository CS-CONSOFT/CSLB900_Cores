using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA028Repository(AppDbContext context) : IAA028Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa028> CreateAsync(CSICP_Aa028 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa028?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }


        public async Task<CSICP_Aa028?> GetByLocalidadeEUfIdAsync(string ufId, string localidade, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa028s
                .AsNoTracking()
                 .Where(e => e.TenantId == tenant)
                 .Where(e => e.Aa028Cidade == localidade)
                 .Where(e => e.Ufid == ufId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CSICP_Aa028>> GetListAsync(int tenant, string? search, string? ufId)
        {
            IQueryable<CSICP_Aa028> q1 = CreateBaseQuery(tenant).Include(e => e.NavUf).Include(e => e.NavUFBrasil).Include(e => e.NavZonaFranca).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1, ufId);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa028> RemoveAsync(CSICP_Aa028 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa028> UpdateAsync(CSICP_Aa028 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa028> FiltraQuandoExisteFiltros
            (string? search, IQueryable<CSICP_Aa028> query, string? ufId)
        {
            if (search != null)
            {
                query = query
                   .Where(entity => (entity.Aa028Cidade ?? "").Contains(search ?? ""));
            }

            if (ufId != null)
            {
                query = query.Where(e => e.Ufid == ufId);
            }
            return query;
        }


        private IQueryable<CSICP_Aa028> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa028s.AsNoTracking()
          .Where(e => e.TenantId == tenant)
          .OrderBy(e => e.Aa028Cidade);
        }

        private async Task<CSICP_Aa028?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
