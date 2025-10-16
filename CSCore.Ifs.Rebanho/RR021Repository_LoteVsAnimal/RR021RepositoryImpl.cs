using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR021;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal
{
    public class RR021RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr021>, IRR021Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR021RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<OsusrTo3CsicpRr021>, int)> GetListRR021LoteIdAsync(int In_TenantID, string In_LoteID, PrmFiltrosRR021 prm)
        {
            IQueryable<OsusrTo3CsicpRr021> query = GetQueryBase(In_TenantID, In_LoteID);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        private IQueryable<OsusrTo3CsicpRr021> GetQueryBase(int In_TenantID, string In_LoteID)
        {
            return _appDbContext.OsusrTo3CsicpRr021s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID && e.Rr021Loteid == In_LoteID)
                .Include(e => e.NavRR001Animal_RR021);
        }

        protected override ICSFilter<OsusrTo3CsicpRr021>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR021;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroAnimalIdRR021(filtros.In_AnimalId),
                new FiltroDtRegistroRR021(filtros.In_DtRegistroInicio, filtros.In_DtRegistroFim)
            ];
        }
    }
}