using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR005;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR005Repository_Situacao.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR005Repository_Situacao
{
    public class RR005RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr005>, IRR005Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR005RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr005?> GetByIdAsync(int In_TenantID, long In_IDRR005)
        {
            IQueryable<OsusrTo3CsicpRr005> query = _appDbContext.OsusrTo3CsicpRr005s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr005? CSICP_RR005 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR005);
            return CSICP_RR005;
        }

        public async Task<(List<OsusrTo3CsicpRr005>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR005 prm)
        {
            IQueryable<OsusrTo3CsicpRr005> query = _appDbContext.OsusrTo3CsicpRr005s
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

        protected override ICSFilter<OsusrTo3CsicpRr005>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR005;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroSituacaoRR005(filtros.In_Situacao)
            ];
        }
    }
}