using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR031;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR031Repository_RegistroControleGestacao.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR031Repository_RegistroControleGestacao
{
    public class RR031RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr031>, IRR031Repository
    {
        private readonly AppDbContext _appDbContext;
        
        public RR031RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr031?> GetByIdAsync(int In_TenantID, string In_IDRR031)
        {
            IQueryable<OsusrTo3CsicpRr031> query = GetQueryBase(In_TenantID);

            OsusrTo3CsicpRr031? CSICP_RR031 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR031);
            return CSICP_RR031;
        }

        public async Task<(List<OsusrTo3CsicpRr031>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR031 prm)
        {
            IQueryable<OsusrTo3CsicpRr031> query = GetQueryBase(In_TenantID);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        private IQueryable<OsusrTo3CsicpRr031> GetQueryBase(int In_TenantID)
        {
            return _appDbContext.OsusrTo3CsicpRr031s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Animal_RR031)
                .Include(e => e.NavRR030Iatf_RR031)
                .Include(e => e.NavRR001MontaAnimal_RR031)
                .Include(e => e.NavRR035Semen_RR031);
        }

        protected override ICSFilter<OsusrTo3CsicpRr031>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR031;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroIATFRR030IdRR031(filtros.In_IATFRR030ID),
            ];
        }
    }
}