using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA012Repository(AppDbContext context) : IAA012Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Aa012> CreateAsync(CSICP_Aa012 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa012?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa012s.AsNoTracking()
                    .Where(e => e.TenantId == tenant)
                    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<CSICP_Aa012>> GetListAsync(int tenant, string? search, int? searchCode)
        {
            IQueryable<CSICP_Aa012> q1 = _appDbContext.OsusrE9aCsicpAa012s.AsNoTracking()
                 .Where(e => e.TenantId == tenant)
                 .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Aa012> RemoveAsync(CSICP_Aa012 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Aa012> UpdateAsync(CSICP_Aa012 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_Aa012> FiltraQuandoExisteFiltros(string? search, int? searchCode, IQueryable<CSICP_Aa012> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa012Descricao ?? "").Contains(search ?? "") ||
                           (entity.Aa012DescricaoGrande ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Aa012Codigo ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }
    }
}
