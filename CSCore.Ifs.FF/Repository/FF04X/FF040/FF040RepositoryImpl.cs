using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._04X;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF04X.FF040.Filtros;
using CSCore.Ifs.FF.Repository.FF04X.FF040.Includes;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF04X.FF040
{
    public class FF040RepositoryImpl : RepositorioBaseImpl<CSICP_FF040>, IFF040Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF040RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_FF040?> GetByIdAsync(int InTenantID, long InIDFF040)
        {
            return await _appDbContext.OsusrE9aCsicpFf040s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Ff040Id == InIDFF040)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_FF040>, int)> GetListAsync(int InTenantID, PrmFiltrosFF040Repo prm)
        {
            IQueryable<CSICP_FF040> query = _appDbContext.OsusrE9aCsicpFf040s
                .AsNoTracking()
                .Include(e => e.NavBB005CCustoID)
                .Include(e => e.NavBB012ContaID)
                .Include(e => e.NavBB006AgCobradorID)
                .Include(e => e.NavBB007ResponsavelID)
                //.Include(e => e.NavFF003EspecieID)
                .Include(e => e.NavBB009TipoCobrancaID)
                .Include(e => e.NavSY001UsuarioPropID)
                .Include(e => e.NavFF040SituacaoID)
                .AsSplitQuery();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));
            //query = AplicaIncludes(query, GetIncludesParaAplicar());

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Ff040Id);
            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);

            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_FF040>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosFF040Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroEstabIDFF040(filtros.InEstabID),
                new FiltroContaIDFF040(filtros.InContaID),
                new FiltroProtocoloNumberFF040(filtros.InProtocoloNumber),
                new FiltroDataMovtFF040(filtros.DataInicio, filtros.DataFim),
                new FiltroStatusIDFF040(filtros.InStatusID),
            ];
        }
    }
}