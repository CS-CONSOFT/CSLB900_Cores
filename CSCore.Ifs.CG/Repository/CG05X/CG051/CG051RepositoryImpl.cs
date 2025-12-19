using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG05X.CG051;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG05X.CG051
{
    public class CG051RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg051>, ICG051Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG051RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg051Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<Osusr8dwCsicpCg051>, int)> GetListAsync(
            int InTenantID,
            long InCG050ID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg051> query = _appDbContext.Osusr8dwCsicpCg051s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Cg051Eventotpid == InCG050ID)
                .Include(e => e.NavCG050TipoEvento_CG051)
                .Include(e => e.NavCG052PrmEvento_CG051);

            var queryCount = query;
            var count = await queryCount.CountAsync();
            query = query.OrderByDescending(e => e.Cg051Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}