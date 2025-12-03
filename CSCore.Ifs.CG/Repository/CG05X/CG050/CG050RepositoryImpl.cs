using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG05X.CG050;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG05X.CG050
{
    public class CG050RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg050>, ICG050Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG050RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg050Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg050?> GetByIdAsync(int InTenantID, long InCG050ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg050s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg050Id == InCG050ID)
                .Include(e => e.NavUnPeriodo)
                .Include(e => e.NavModuloID)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg050>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg050> query = _appDbContext.Osusr8dwCsicpCg050s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID)
                .Include(e => e.NavUnPeriodo)
                .Include(e => e.NavModuloID);

            var queryCount = query;
            var count = await queryCount.CountAsync();
            query = query.OrderByDescending(e => e.Cg050Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}