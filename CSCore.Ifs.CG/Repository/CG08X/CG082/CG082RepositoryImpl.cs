using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG08X.CG082;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG08X.CG082
{
    public class CG082RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg082>, ICG082Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG082RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg082Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<Osusr8dwCsicpCg082>, int)> GetListAsync(int InTenantID, long InCG081ID, int InPageNumber, int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg082> query = _appDbContext.Osusr8dwCsicpCg082s
                .AsNoTracking()
                .Include(e => e.NavCG081ContRelRegID_CG082)
                .Include(e => e.NavCG006ContConta_CG082)
                .Where(e => e.TenantId == InTenantID
                    && e.Cg082Contrelregid == InCG081ID);

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}