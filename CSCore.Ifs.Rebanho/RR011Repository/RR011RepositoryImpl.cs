using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR011;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR011Repository.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR011Repository
{
    public class RR011RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr011>, IRR011Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR011RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr011?> GetByIdAsync(int tenantId, long id)
        {
            return await _appDbContext.OsusrTo3CsicpRr011s
                .AsNoTracking()
                .Where(e => e.TenantId == tenantId && e.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<OsusrTo3CsicpRr011>, int)> GetListAsync(int tenantId, PrmFiltrosRR011 prm)
        {
            IQueryable<OsusrTo3CsicpRr011> query = _appDbContext.OsusrTo3CsicpRr011s
                .AsNoTracking();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(tenantId, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr011>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR011;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroSerieRR011(filtros.Rr011Serie),
                new FiltroUltRgnRR011(filtros.Rr011Ultrgn)
            ];
        }
    }
}