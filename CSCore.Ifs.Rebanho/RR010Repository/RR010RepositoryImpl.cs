using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR010;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR010Repository.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR010Repository
{
    public class RR010RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr010>, IRR010Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR010RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr010?> GetByIdAsync(int tenantId, long id)
        {
            return await _appDbContext.OsusrTo3CsicpRr010s
                .AsNoTracking()
                .Where(e => e.TenantId == tenantId && e.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<OsusrTo3CsicpRr010>, int)> GetListAsync(int tenantId, PrmFiltrosRR010 prm)
        {
            IQueryable<OsusrTo3CsicpRr010> query = _appDbContext.OsusrTo3CsicpRr010s
                .AsNoTracking();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(tenantId, prm));

            var count = await query.CountAsync();
            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        public async Task<List<OsusrTo3CsicpRr010>> GetListForComboAsync(int tenantId)
        {
            return await _appDbContext.OsusrTo3CsicpRr010s
                .AsNoTracking()
                .Where(e => e.TenantId == tenantId)
                .OrderBy(e => e.Rr010Condcriacao)
                .ToListAsync();
        }

        protected override ICSFilter<OsusrTo3CsicpRr010>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR010;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroCondCriacaoRR010(filtros.Rr010Condcriacao),
                new FiltroDescritivoRR010(filtros.Rr010Descritivo)
            ];
        }
    }
}