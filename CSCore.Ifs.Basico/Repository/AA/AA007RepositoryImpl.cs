

using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA007RepositoryImpl(AppDbContext context) : RepositorioBaseImpl<CSICP_Aa007>(context), IAA007Repository
    {
        private AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa007?> GetByIdAsync(long id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa007s
                    .AsNoTracking()
                    .Where(e => e.TenantId == tenant)
                    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<CSICP_Aa007>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Aa007> q1 = _appDbContext.OsusrE9aCsicpAa007s
                 .Where(e => e.TenantId == tenant)
                 .AsNoTracking()
                 .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa007> ChangeActive(CSICP_Aa007 entity)
        {
            entity.Isactive = !entity.Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private static IQueryable<CSICP_Aa007> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Aa007> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa007Descricao ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                    .Where(e => e.Isactive == isActive);
            }

            return query;
        }

    }
}
