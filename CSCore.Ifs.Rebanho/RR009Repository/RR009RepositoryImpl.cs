using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR009;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR009Repository.Filtros;
using CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR009Repository
{
    public class RR009RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr009>, IRR009Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR009RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr009?> GetByIdAsync(int In_TenantID, string In_IDRR009)
        {
            return await _appDbContext.OsusrTo3CsicpRr009s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID && e.Id == In_IDRR009)
                .Include(e => e.NavRR001Animal_RR009)
                .Include(e => e.NavRR001AnimalVirtual_RR009)
                .FirstOrDefaultAsync();
        }

        public async Task<(List<OsusrTo3CsicpRr009>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR009 prm)
        {
            IQueryable<OsusrTo3CsicpRr009> query = _appDbContext.OsusrTo3CsicpRr009s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.NavRR001Animal_RR009)
                .Include(e => e.NavRR001AnimalVirtual_RR009);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        public async Task<bool> ExisteAnimalNoRelacionamentoAsync(int In_TenantID, string In_Rr001Id, string In_Rr001Virtualid)
        {
            return await _appDbContext.OsusrTo3CsicpRr009s
                .AnyAsync(x => x.TenantId == In_TenantID 
                    && x.Rr001Id == In_Rr001Id 
                    && x.Rr001Virtualid == In_Rr001Virtualid);
        }


        protected override ICSFilter<OsusrTo3CsicpRr009>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR009;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroAnimalIdRR009(filtros.Rr001Id),
                new FiltroAnimalVirtualIdRR009(filtros.Rr001Virtualid)
            ];
        }
    }
}