using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR006;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR006Repository_Ocorrencia.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR006Repository_Ocorrencia
{
    public class RR006RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr006>, IRR006Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR006RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr006?> GetByIdAsync(int In_TenantID, long In_IDRR006)
        {
            IQueryable<OsusrTo3CsicpRr006> query = _appDbContext.OsusrTo3CsicpRr006s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr006? CSICP_RR006 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR006);
            return CSICP_RR006;
        }

        public async Task<(List<OsusrTo3CsicpRr006>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR006 prm)
        {
            IQueryable<OsusrTo3CsicpRr006> query = _appDbContext.OsusrTo3CsicpRr006s
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

        protected override ICSFilter<OsusrTo3CsicpRr006>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR006;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroOcorrenciaRR006(filtros.In_Ocorrencia)
            ];
        }
    }
}