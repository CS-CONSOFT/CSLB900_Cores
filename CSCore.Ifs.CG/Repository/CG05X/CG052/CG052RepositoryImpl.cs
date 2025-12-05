using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG05X.CG052;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG05X.CG052
{
    public class CG052RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg052>, ICG052Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG052RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg052Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg052?> GetByIdAsync(int InTenantID, long InCG052ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg052s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg052Id == InCG052ID)
                .Include(e => e.NavModuloID_CG052)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg052>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg052> query = _appDbContext.Osusr8dwCsicpCg052s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID)
                .Include(e => e.NavModuloID_CG052);

            var queryCount = query;
            var count = await queryCount.CountAsync();
            query = query.OrderByDescending(e => e.Cg052Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}