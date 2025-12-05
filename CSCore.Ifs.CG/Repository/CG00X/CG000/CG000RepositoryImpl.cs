using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.CG.CG00X.CG000;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG000.Filtros;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG000
{
    public class CG000RepositoryImpl : RepositorioBaseImplV2<CSICP_CG000> , ICG000Repository
    {
        private readonly AppDbContext _appDbContext;
        public CG000RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg000Id") 
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG000?> GetByIdAsync(int InTenant, string InIDCG000)
        {
            var query = _appDbContext.Osusr8dwCsicpCg000s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG000)
                .Include(e => e.NavStatica_CG000)
                .Where(e => e.TenantId == InTenant 
                && e.Cg000Id == InIDCG000);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<CSICP_CG000?> GetByIdPorEstabIDAsync(int InTenant, string InEstabCG000ID)
        {
            var query = _appDbContext.Osusr8dwCsicpCg000s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG000)
                .Include(e => e.NavStatica_CG000)
                .Where(e => e.TenantId == InTenant
                && e.Cg000Filialid == InEstabCG000ID);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG000>, int)> GetListAsync(int InTenant, PrmFiltrosCG000Repo InPrm)
        {
            IQueryable<CSICP_CG000> query = _appDbContext.Osusr8dwCsicpCg000s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG000)
                .Include(e => e.NavStatica_CG000);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenant, InPrm));

            var queryCount = query;
            var count = await queryCount.CountAsync();
            query = query.OrderBy(e => e.Cg000Id);
            query = query.PaginacaoNoBanco(InPrm.PageNumber, InPrm.PageSize);
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG000>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosCG000Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroEstabIDCG000(filtros.EstabID)
            ];
        }
    }
}