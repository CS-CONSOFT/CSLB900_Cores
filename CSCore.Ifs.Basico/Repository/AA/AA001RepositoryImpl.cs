
using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA001RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_AA001>(appDbContext), IAA001Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_AA001?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpAa001s
                .AsNoTracking()
                .Include(e => e.FilialBB001)
                .AsSplitQuery()
                .Where(e => e.Id == id && e.TenantId == tenant).FirstOrDefaultAsync();
        }

        public async Task<CSICP_AA001?> GetByIdentificacao(int tenant, string in_identificacao)
        {
            return await _appDbContext.OsusrE9aCsicpAa001s
               .AsNoTracking()
               .Where(e => e.Aa001Identificacao == in_identificacao && e.TenantId == tenant).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CSICP_AA001>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_AA001> q1 = _appDbContext.OsusrE9aCsicpAa001s
                 .Where(e => e.TenantId == tenant)
                 .Include(e => e.FilialBB001)
                 .AsNoTracking()
                 .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        private static IQueryable<CSICP_AA001> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_AA001> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa001Descricao ?? "").StartsWith(search ?? "") ||
                           (entity.Aa001Identificacao ?? "").StartsWith(search ?? ""));
            }
            return query;
        }

      
    }
}
