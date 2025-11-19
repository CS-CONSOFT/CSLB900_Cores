using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG005;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG005.Filtros;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG005
{
    public class CG005RepositoryImpl : RepositorioBaseImpl<CSICP_CG005>, ICG005Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG005RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg005Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG005?> GetByIdAsync(int InTenantID, string InCG005ID)
        {
            var query = _appDbContext.Osusr8dwCsicpCg005s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG005)
                .Where(e => e.Cg005Id == InCG005ID && e.TenantId == InTenantID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG005>, int)> GetListAsync(int InTenantID, PrmFiltrosCG005Repo prm)
        {
            IQueryable<CSICP_CG005> query = _appDbContext.Osusr8dwCsicpCg005s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG005);

            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));

            var count = await query.CountAsync();
            query = query.OrderBy(e => e.Cg005Id);
            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);

            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG005>[] GetOutrosFiltros<TFiltros>(int InTenantID, TFiltros filtros)
        {
            var prm = filtros as PrmFiltrosCG005Repo ?? throw new ArgumentNullException(nameof(filtros));
            return
            [
                new FiltroEstabIDCG005(prm.EstabID),
            ];
        }
    }
}