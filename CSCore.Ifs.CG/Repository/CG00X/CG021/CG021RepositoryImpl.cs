using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG021;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG021.Filtros;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG021
{
    public class CG021RepositoryImpl : RepositorioBaseImpl<Osusr8dwCsicpCg021>, ICG021Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG021RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg021Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg021?> GetByIdAsync(int InTenant, string InIDCG021)
        {
            var query = _appDbContext.Osusr8dwCsicpCg021s
                .AsNoTracking()
                .Where(e => e.Cg021Id == InIDCG021 && e.TenantId == InTenant);
            
            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg021>, int)> GetListAsync(int InTenant, PrmFiltrosCG021Repo InPrm)
        {
            IQueryable<Osusr8dwCsicpCg021> query = _appDbContext.Osusr8dwCsicpCg021s
                .AsNoTracking();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenant, InPrm));

            var queryCount = query;
            var count = queryCount.Count();
            
            query = query.OrderBy(e => e.Cg021Nrolancamento)
                         .ThenBy(e => e.Cg021Seq);
            query.PaginacaoNoBanco(InPrm.PageNumber, InPrm.PageSize);
            
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<Osusr8dwCsicpCg021>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosCG021Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return
            [
                new FiltroLoteIdCG021(filtros.LoteId),
                new FiltroFilialIdCG021(filtros.FilialId),
                new FiltroDataCG021(filtros.DataInicio, filtros.DataFinal),
            ];
        }
    }
}