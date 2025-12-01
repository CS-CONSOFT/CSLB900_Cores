using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG06X.CG062;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG06X.CG062
{
    public class CG062RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg062>, ICG062Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG062RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg062Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg062?> GetByIdAsync(int InTenantID, long InCG062ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg062s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg062Id == InCG062ID)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg062>, int)> GetListAsync(
            int InTenantID,
            long? InRegramentoID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg062> query = _appDbContext.Osusr8dwCsicpCg062s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID);

            // Filtro opcional por regramento
            if (InRegramentoID.HasValue)
            {
                query = query.Where(e => e.Cg062Regramentoid == InRegramentoID.Value);
            }

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderByDescending(e => e.Cg062Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}