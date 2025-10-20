using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR020;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR020Repository_Lote.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR020Repository_Lote
{
    public class RR020RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr020>, IRR020Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR020RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr020?> GetByIdAsync(int In_TenantID, string In_IDRR020)
        {
            IQueryable<OsusrTo3CsicpRr020> query = _appDbContext.OsusrTo3CsicpRr020s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR008RegAlimentar_RR020);

            OsusrTo3CsicpRr020? CSICP_RR020 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR020);
            return CSICP_RR020;
        }

        public async Task<(List<OsusrTo3CsicpRr020>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR020 prm)
        {
            IQueryable<OsusrTo3CsicpRr020> query = _appDbContext.OsusrTo3CsicpRr020s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.NavRR008RegAlimentar_RR020);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr020>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR020;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroIdentificadorRR020(filtros.In_Identificador),
                new FiltroDescricaoRR020(filtros.In_Descricao)
            ];
        }
    }
}