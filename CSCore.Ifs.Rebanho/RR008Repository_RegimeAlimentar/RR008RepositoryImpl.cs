using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR008;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR008Repository_RegimeAlimentar.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR008Repository_RegimeAlimentar
{
    public class RR008RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr008>, IRR008Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR008RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr008?> GetByIdAsync(int In_TenantID, long In_IDRR008)
        {
            IQueryable<OsusrTo3CsicpRr008> query = _appDbContext.OsusrTo3CsicpRr008s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr008? CSICP_RR008 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR008);
            return CSICP_RR008;
        }

        public async Task<(List<OsusrTo3CsicpRr008>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR008 prm)
        {
            IQueryable<OsusrTo3CsicpRr008> query = _appDbContext.OsusrTo3CsicpRr008s
                .AsNoTracking()
                .AsSplitQuery();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr008>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR008;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroRegAlimentarRR008(filtros.In_RegAlimentar)
            ];
        }
    }
}