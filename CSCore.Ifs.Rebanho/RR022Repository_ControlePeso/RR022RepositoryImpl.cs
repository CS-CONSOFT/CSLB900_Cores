using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR022;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Rebanho.RR022Repository_ControlePeso.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR022Repository_ControlePeso
{
    public class RR022RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr022>, IRR022Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR022RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr022?> GetByIdAsync(int In_TenantID, string In_IDRR022)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID)
                .Include(e => e.NavRR001Animal_RR022)
                .Include(e => e.NavRR021LoteXAnimal_RR022);

            OsusrTo3CsicpRr022? CSICP_RR022 = await query
                .FirstOrDefaultAsync(e => e.Id == In_IDRR022);
            return CSICP_RR022;
        }

        public async Task<(List<OsusrTo3CsicpRr022>, int)> GetListPesoAnimalRR022Async(int In_TenantID, PrmFiltrosRR022 prm)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Include(e => e.NavRR001Animal_RR022)
                .Include(e => e.NavRR021LoteXAnimal_RR022);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }

        protected override ICSFilter<OsusrTo3CsicpRr022>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosRR022;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroLoteIdRR022(filtros.In_LoteId),
                new FiltroDataPesoRR022(filtros.In_DataPeso),
            ];
        }

        public async Task<List<DtoGetCountPesoAnimalRR022>> GetListCountPesoAnimalAsync(int In_TenantID, string In_LoteId)
        {
            var result = await _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .Where(e => e.TenantId == In_TenantID
                    && e.Rr022Loteid == In_LoteId)
                .GroupBy(e => new { e.Rr022Dtpeso, e.Rr022Loteid })
                .Select(g => new DtoGetCountPesoAnimalRR022
                {
                    Data = g.Key.Rr022Dtpeso,
                    Lote = g.Key.Rr022Loteid,
                    QtdReg = g.Count()
                })
                .OrderBy(x => x.Data)
                .ToListAsync();

            return result;
        }

        public async Task<bool> ExisteRegistroPesoAsync(int In_TenantID, string In_LoteId, string In_AnimalId, DateTime In_DataPeso)
        {
            return await _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AnyAsync(e =>
                    e.TenantId == In_TenantID &&
                    e.Rr022Loteid == In_LoteId &&
                    e.Rr022Animalid == In_AnimalId &&
                    e.Rr022Dtpeso.HasValue &&
                    e.Rr022Dtpeso.Value.Date == In_DataPeso.Date);
        }

        public async Task<OsusrTo3CsicpRr022> GetByIdRR022SimplesAsync(int In_TenantID, string In_IDRR022)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsNoTracking()
                .AsSplitQuery()
                .Where(e => e.TenantId == In_TenantID);

            OsusrTo3CsicpRr022? CSICP_RR022 = await query.FirstOrDefaultAsync(e => e.Id == In_IDRR022);
            return CSICP_RR022;
        }

        public async Task GetExecutaProcessaPesoAnimalAsync(int InTenantID, PrmFiltrosRR022 prm)
        {
            // Busca RR022 com RR001 e RR021
            prm.DeveExcederOMaxPageSize = true;
            prm.PageSize = 999;

            var listRR022 = await GetListPesoAnimalRR022ParaProcessoAsync(InTenantID, prm);

            foreach (var rr022 in listRR022.Item1)
            {
                if (rr022 == null)
                    continue;

                rr022.Rr001Dtultpeso = rr022.NavRR001Animal_RR022.Rr001Dtultpeso;
                rr022.Rr001Ultpeso = rr022.NavRR001Animal_RR022.Rr001Ultpeso;

                rr022.CalcularIdadeDiasAtual();
                rr022.CalcularIdadeDiasUlt();
                rr022.CalcularGmd();
                rr022.CalcularGpd();
                rr022.Rr022IsProcessado = true;

                rr022.NavRR001Animal_RR022.Rr001Dtultpeso = rr022.Rr022Dtpeso;
                rr022.NavRR001Animal_RR022.Rr001Ultpeso = rr022.Rr022Peso;
                rr022.NavRR001Animal_RR022.Rr001Ultidadediaspeso = rr022.Rr022Idadediasult;
            }

            await _appDbContext.SaveChangesAsync();
        }

        public async Task<(List<OsusrTo3CsicpRr022>, int)> GetListPesoAnimalRR022ParaProcessoAsync(int In_TenantID, PrmFiltrosRR022 prm)
        {
            IQueryable<OsusrTo3CsicpRr022> query = _appDbContext.OsusrTo3CsicpRr022s
                .AsSplitQuery()
                .Where(e => e.Rr022IsProcessado == false)
                .Include(e => e.NavRR001Animal_RR022);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(In_TenantID, prm));

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            var listItems = await query.ToListAsync();

            return (listItems, count);
        }
    }
}