using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG06X.CG063;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG06X.CG063
{
    public class CG063RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg063>, ICG063Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG063RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg063Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg063?> GetByIdAsync(int InTenantID, long InCG063ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg063s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg063Id == InCG063ID)
                .Include(e => e.NavCG051PrmEvento_CG063)
                .Include(e => e.NavCG060RegramentoID_CG063)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg063>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg063> query = _appDbContext.Osusr8dwCsicpCg063s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID);

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderByDescending(e => e.Cg063Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}