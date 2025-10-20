using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR035;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR035Repository_CadastroSemen.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR035Repository_CadastroSemen
{
    public class RR035RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr035>, IRR035Repository
    {
        private readonly AppDbContext _appDbContext;
        
        public RR035RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr035?> GetByIdAsync(int In_TenantID, string In_IDRR035)
        {
            IQueryable<OsusrTo3CsicpRr035> query = _appDbContext.OsusrTo3CsicpRr035s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr035? CSICP_RR035 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR035);
            return CSICP_RR035;
        }

        public async Task<(List<OsusrTo3CsicpRr035>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR035 prm)
        {
            IQueryable<OsusrTo3CsicpRr035> query = _appDbContext.OsusrTo3CsicpRr035s
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

        protected override ICSFilter<OsusrTo3CsicpRr035>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR035;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroDescricaoRR035(filtros.In_Descricao),
                new FiltroNroSemenRR035(filtros.In_NroSemen)
            ];
        }
    }
}