using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_QueryFilters;
using CSCore.Domain.Interfaces.GG._05X;
using CSCore.Domain.Interfaces.GG._05X.GG055;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._05X.GG055.Filtros;
using CSCore.Ifs.GG.Repository.GG._05X.GG055.Includes;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._05X.GG055
{
    public class GG055RepositoryImpl : RepositorioBaseImpl<CSICP_GG055>, IGG055Repository
    {
        private readonly AppDbContext _appDbContext;
        public GG055RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<CSICP_GG055>, int)> GetListAsync(int InTenantID, PrmFiltrosGG055Repo parametros)
        {
            IQueryable<CSICP_GG055> query = _appDbContext.OsusrE9aCsicpGg055s.AsNoTracking().AsSplitQuery();
            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, parametros));
            query = AplicaIncludes(query, GetIncludesParaAplicar());
            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(parametros.PageNumber, parametros.PageSize);
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_GG055>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosGG055Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(filtros), "Os filtros fornecidos não são do tipo esperado PrmFiltrosGG055Repo.");
            return [
                 new FiltroGG054IdGG055(filtros.InIDGG054)
                ];
        }

        protected override ICSInclude<CSICP_GG055>[] GetIncludesParaAplicar()
        {
            return [new IncludeNavGG520SaldoGG055()];
        }
    }
}
