using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.DD;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.DD.Repository.DD
{
    public class DD156RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_DD156>(appDbContext, "Dd156Id"), IDD156Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_DD156?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrDfwCsicpDd156s
                    .AsSplitQuery()
                   .Where(e => e.TenantId == tenant).AsNoTracking()
                   .Where(e => e.Dd156Id == id)
                   .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_DD156>, int)> GetListAsync(int tenant, int pageSize, int page)
        {

            IQueryable<CSICP_DD156> q1 = _appDbContext.OsusrDfwCsicpDd156s
                .AsSplitQuery()
                .Where(e => e.TenantId == tenant).AsNoTracking();

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }
    }
}
