using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._04X;
using CSCore.Domain.Interfaces.FF._04X.FF042;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF04X.FF040;
using CSCore.Ifs.FF.Repository.FF04X.FF042.Filtros;
using CSCore.Ifs.FF.Repository.FF04X.FF042.Include;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF04X.FF042
{
    public class FF042RepositoryImpl : RepositorioBaseImpl<CSICP_FF042>, IFF042Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF042RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<CSICP_FF042>, int)> GetListAsync(int InTenantID, PrmFiltrosFF042Repo prm)
        {
            IQueryable<CSICP_FF042> query = _appDbContext.OsusrE9aCsicpFf042s
                .AsNoTracking()
                .AsSplitQuery();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));
            query = AplicaIncludes(query, GetIncludesParaAplicar());

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Ff040Id);
            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);

            return (await query.ToListAsync(), count);
        }
        protected override ICSFilter<CSICP_FF042>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosFF042Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");
            return [
                new FiltroFF040IDParaFF042(filtros.InFF040Id)]; //verificar com o Valter o filtro do IDFF040
        }

        protected override ICSInclude<CSICP_FF042>[] GetIncludesParaAplicar()
        {
            return [
                new IncludeNavListFF043ParaFF042()
                ];
        }

        
    }
}
