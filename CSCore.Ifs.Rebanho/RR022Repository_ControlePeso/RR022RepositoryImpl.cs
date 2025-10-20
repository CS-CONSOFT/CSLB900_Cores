using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR022;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso
{
    public class RR022RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr022>, IRR022Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR022RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr022?> GetByIdAsync(int In_TenantID, string In_IDRR022)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Animal_RR022)
                .Include(e => e.NavRR021LoteXAnimal_RR022);

            OsusrTo3CsicpRr022? CSICP_RR022 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR022);
            return CSICP_RR022;
        }

        public async Task<(List<OsusrTo3CsicpRr022>, int)> GetListRR022ByRR021IdAsync(int In_TenantID, string In_RR021ID, PrmFiltrosRR022 prm)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Animal_RR022)
                .Include(e => e.NavRR021LoteXAnimal_RR022)
                .Where(e => e.NavRR021LoteXAnimal_RR022 != null &&
                           e.NavRR021LoteXAnimal_RR022.Id == In_RR021ID);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr022>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR022;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroAnimalIdRR022(filtros.In_AnimalId),
                new FiltroPesoRR022(filtros.In_PesoMinimo, filtros.In_PesoMaximo)
            ];
        }
    }
}