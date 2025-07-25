using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA013Repository(AppDbContext context) : IAA013Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa013> CreateAsync(CSICP_Aa013 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa013?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa013s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.Filial)
                .Include(e => e.Aa013Mod)
                .Where(e => e.Id == id)
                .Where(e => e.TenantId == tenant)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CSICP_Aa013>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_Aa013> q1 = _appDbContext.OsusrE9aCsicpAa013s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.Filial)
                .Include(e => e.Aa013Mod)
                .Where(e => e.TenantId == tenant)
                .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa013> RemoveAsync(CSICP_Aa013 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa013> UpdateAsync(CSICP_Aa013 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa013> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_Aa013> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa013Serie ?? "").Contains(search ?? "") ||
                           (entity.Aa013Numero.ToString() ?? "").Contains(search ?? ""));
            }
            return query;
        }
    }
}

