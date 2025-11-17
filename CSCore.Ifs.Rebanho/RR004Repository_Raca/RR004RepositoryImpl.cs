using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR004;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR004Repository_Raca.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR004Repository_Raca
{
    public class RR004RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr004>, IRR004Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR004RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr004?> GetByIdAsync(int In_TenantID, long In_IDRR004)
        {
            IQueryable<OsusrTo3CsicpRr004> query = _appDbContext.OsusrTo3CsicpRr004s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr004? CSICP_RR004 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR004);
            return CSICP_RR004;
        }

        public async Task<(List<OsusrTo3CsicpRr004>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR004 prm)
        {
            IQueryable<OsusrTo3CsicpRr004> query = _appDbContext.OsusrTo3CsicpRr004s
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

        protected override ICSFilter<OsusrTo3CsicpRr004>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR004;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroRacaRR004(filtros.In_Raca)
            ];
        }
    }
}