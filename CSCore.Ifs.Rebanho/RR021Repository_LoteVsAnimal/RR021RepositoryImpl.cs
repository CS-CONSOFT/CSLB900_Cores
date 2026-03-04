using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR021;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CSCore.Ifs.Rebanho.RR021Repository_LoteVsAnimal
{
    public class RR021RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr021>, IRR021Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR021RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<OsusrTo3CsicpRr021>, int)> GetListRR021LoteIdAsync(int In_TenantID, PrmFiltrosRR021 prm)
        {
            IQueryable<OsusrTo3CsicpRr021> query = _appDbContext.OsusrTo3CsicpRr021s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID && e.Rr021Loteid == prm.In_LoteId)
                .Include(e => e.NavRR001Animal_RR021)
                .Include(e => e.NavRR020RegLote_RR021);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr021>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR021;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroAnimalIdRR021(filtros.In_AnimalId),
                new FiltroLoteIdRR021(filtros.In_LoteId),
                new FiltroDtRegistroRR021(filtros.In_DtRegistroInicio, filtros.In_DtRegistroFim)
            ];
        }

        public async Task<List<OsusrTo3CsicpRr021>> GetListRR021ParaPopular(int In_TenantID, string In_LoteID)
        {
            var query = from rr021 in _appDbContext.OsusrTo3CsicpRr021s
                        .AsNoTracking()

                        where rr021.TenantId == In_TenantID
                            && rr021.Rr021Loteid == In_LoteID
                        select rr021; 

            var listRR021Items = await query.ToListAsync();
            return listRR021Items;
        }

        public async Task<OsusrTo3CsicpRr021?> GetByIdParaAlterarLoteAsync(int In_TenantID, string In_IDRR021)
        {
            var registro = await _appDbContext.OsusrTo3CsicpRr021s
                .AsNoTracking()
                .Where(e => e.TenantId == In_TenantID && e.Id == In_IDRR021)
                .FirstOrDefaultAsync();

            return registro;
        }
    }
}