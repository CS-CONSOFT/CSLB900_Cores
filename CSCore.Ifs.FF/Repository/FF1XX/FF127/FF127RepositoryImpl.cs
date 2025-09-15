using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_QueryFilters;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Domain.Interfaces.FF._1XX.FF127;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF127.Filtros;
using CSCore.Ifs.FF.Repository.FF1XX.FF127.Includes;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF127
{
    public class FF127RepositoryImpl : RepositorioBaseImpl<CSICP_FF127>, IFF127Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF127RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<CSICP_FF127>, int)> GetListAsync(int InTenantID, PrmFiltrosFF127Repo parametros)
        {
            IQueryable<CSICP_FF127> query = _appDbContext.OsusrE9aCsicpFf127s.AsNoTracking().AsSplitQuery();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, parametros));
            query = AplicaIncludes(query, GetIncludesParaAplicar());

            var queryCount = query;
            var count = queryCount.Count();
            
            query = query.PaginacaoNoBanco(parametros.PageNumber, parametros.PageSize);
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_FF127>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosFF127Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");
            return [
                new FiltroBB012ContaIdFF127(filtros.InBB012_ContaID),
                new FiltroBB006AgCobradorFF127(filtros.InCobradorID_BB006)
               ];
        }

        
        protected override ICSInclude<CSICP_FF127>[] GetIncludesParaAplicar()
        {
            return [
                new IncludesNavSY001CobradorFF127(), 
                new IncludesNavBB006AgCobradorFF127(), 
                new IncludesNavFF002MotivoFF127(), 
                new IncludesNavBB012ContaFF127()
            ];
        }
    }
}
