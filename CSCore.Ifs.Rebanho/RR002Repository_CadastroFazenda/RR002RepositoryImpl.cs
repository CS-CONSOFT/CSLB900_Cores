using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR002;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR002Repository_CadastroFazenda.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR002Repository_CadastroFazenda
{
    public class RR002RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr002>, IRR002Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR002RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr002?> GetByIdAsync(int In_TenantID, string In_IDRR002)
        {
            IQueryable<OsusrTo3CsicpRr002> query = _appDbContext.OsusrTo3CsicpRr002s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavAA028Cidade)
                .Include(e => e.NavAA027UF)
                .Include(e => e.NavAA025Pais);

            OsusrTo3CsicpRr002? CSICP_RR002 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR002);
            return CSICP_RR002;
        }

        public async Task<(List<OsusrTo3CsicpRr002>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR002 prm)
        {
            IQueryable<OsusrTo3CsicpRr002> query = _appDbContext.OsusrTo3CsicpRr002s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.NavAA028Cidade)
                .Include(e => e.NavAA027UF)
                .Include(e => e.NavAA025Pais);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr002>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR002;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroNomeFazendaRR002(filtros.In_NomeFazenda)
            ];
        }
    }
}
