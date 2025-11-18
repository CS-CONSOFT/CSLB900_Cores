using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG08X.CG080;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG08X.CG080
{
    public class CG080RepositoryImpl : RepositorioBaseImpl<Osusr8dwCsicpCg080>, ICG080Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG080RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg080Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg080?> GetByIdAsync(int InTenantID, int InCG080ID)
        {
            return await _appDbContext.Osusr8dwCsicpCg080s
                .AsNoTracking()
                .Where(e => e.Cg080Id == InCG080ID && e.TenantId == InTenantID)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg080>, int)> GetListAsync(int InTenantID, string? InNome, int InPageNumber, int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg080> query = _appDbContext.Osusr8dwCsicpCg080s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID);

            // Aplica filtros
            if (!string.IsNullOrWhiteSpace(InNome))
            {
                query = query.Where(e => e.Cg080Nome != null && e.Cg080Nome.Contains(InNome));
            }

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderBy(e => e.Cg080Nome);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}