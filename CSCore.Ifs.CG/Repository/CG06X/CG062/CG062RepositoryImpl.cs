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
                .Include(e => e.NavCG005HistDeb_CG062)
                .Include(e => e.NavCG005HistCred_CG062)
                .Include(e => e.NavCG006ContaDeb_CG062)
                .Include(e => e.NavCG006ContaCred_CG062)
                .Include(e => e.NavCG011CtaGerencial_DebN2ID)
                .Include(e => e.NavCG011CtaGerencial_DebN3ID)
                .Include(e => e.NavCG011CtaGerencial_DebN4ID)
                .Include(e => e.NavCG011CtaGerencial_CredN2ID)
                .Include(e => e.NavCG011CtaGerencial_CredN3ID)
                .Include(e => e.NavCG011CtaGerencial_CredN4ID)
                .Include(e => e.NavCG060RegramentoID_CG062)
                .Include(e => e.NavCG054EventoValorTpID_CG062)
                .Include(e => e.NavCG054EventoValorTpDebID_CG062)
                .Include(e => e.NavCG054EventoValorTpCredID_CG062)
                .FirstOrDefaultAsync();
        }
        public async Task<(List<Osusr8dwCsicpCg062>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg062> query = _appDbContext.Osusr8dwCsicpCg062s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID);

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderByDescending(e => e.Cg062Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}