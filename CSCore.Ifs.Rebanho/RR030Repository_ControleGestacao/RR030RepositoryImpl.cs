using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR030;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR030Repository_ControleGestacao.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR030Repository_ControleGestacao
{
    public class RR030RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr030>, IRR030Repository
    {
        private readonly AppDbContext _appDbContext;
        
        public RR030RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr030?> GetByIdAsync(int In_TenantID, string In_IDRR030)
        {
            IQueryable<OsusrTo3CsicpRr030> query = _appDbContext.OsusrTo3CsicpRr030s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr030? CSICP_RR030 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR030);
            return CSICP_RR030;
        }

        public async Task<(List<OsusrTo3CsicpRr030>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR030 prm)
        {
            IQueryable<OsusrTo3CsicpRr030> query = _appDbContext.OsusrTo3CsicpRr030s
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

        protected override ICSFilter<OsusrTo3CsicpRr030>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR030;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroDescricaoRR030(filtros.In_Descricao),
            ];
        }
    }
}