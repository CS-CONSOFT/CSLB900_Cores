using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR007;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR007Repository_Proprietario.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR007Repository_Proprietario
{
    public class RR007RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr007>, IRR007Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR007RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr007?> GetByIdAsync(int In_TenantID, long In_IDRR007)
        {
            IQueryable<OsusrTo3CsicpRr007> query = _appDbContext.OsusrTo3CsicpRr007s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr007? CSICP_RR007 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR007);
            return CSICP_RR007;
        }

        public async Task<(List<OsusrTo3CsicpRr007>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR007 prm)
        {
            IQueryable<OsusrTo3CsicpRr007> query = _appDbContext.OsusrTo3CsicpRr007s
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

        protected override ICSFilter<OsusrTo3CsicpRr007>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR007;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroNomeProprietarioRR007(filtros.In_NomeProprietario)
            ];
        }
    }
}