using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG05X.CG054;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG05X.CG054
{
    public class CG054RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg054>, ICG054Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG054RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg054Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<Osusr8dwCsicpCg054>, int)> GetListAsync(
            int InTenantID,
            long InCG050ID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg054> query = _appDbContext.Osusr8dwCsicpCg054s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID)
                .Where(e => e.Cg054Eventotpid == InCG050ID)
                .Include(e => e.NavCG050TipoEvento_CG054)
                .Include(e => e.NavCG055ValorEvento_CG054);

            var queryCount = query;
            var count = await queryCount.CountAsync();
            query = query.OrderByDescending(e => e.Cg054Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}