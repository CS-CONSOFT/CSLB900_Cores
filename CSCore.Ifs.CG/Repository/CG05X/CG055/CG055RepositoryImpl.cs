using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG05X.CG055;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG05X.CG055
{
    public class CG055RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg055>, ICG055Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG055RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg055Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg055?> GetByIdAsync(int InTenantID, long InCG055ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg055s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg055Id == InCG055ID)
                .Include(e => e.NavModuloID_CG055)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg055>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg055> query = _appDbContext.Osusr8dwCsicpCg055s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID)
                .Include(e => e.NavModuloID_CG055);

            var count = await query.CountAsync();
            query = query.OrderByDescending(e => e.Cg055Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}