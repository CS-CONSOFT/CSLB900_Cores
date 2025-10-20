using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR003;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR003Repository_Cat.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR003Repository_Cat
{
    public class RR003RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr003>, IRR003Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR003RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr003?> GetByIdAsync(int In_TenantID, long In_IDRR003)
        {
            IQueryable<OsusrTo3CsicpRr003> query = _appDbContext.OsusrTo3CsicpRr003s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr003? CSICP_RR003 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR003);
            return CSICP_RR003;
        }

        public async Task<(List<OsusrTo3CsicpRr003>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR003 prm)
        {
            IQueryable<OsusrTo3CsicpRr003> query = _appDbContext.OsusrTo3CsicpRr003s
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

        protected override ICSFilter<OsusrTo3CsicpRr003>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR003;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroDescricaoRR003(filtros.In_Descricao)
            ];
        }
    }
}