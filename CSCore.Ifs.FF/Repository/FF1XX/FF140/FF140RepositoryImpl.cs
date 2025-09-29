using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX.FF140;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF140.Filtros;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF140
{
    public class FF140RepositoryImpl : RepositorioBaseImpl<CSICP_FF140>, IFF140Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF140RepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_FF140?> GetByIdAsync(int InTenantID, long InFF140ID)
        {
            IQueryable<CSICP_FF140> query = GetQueryBase(InTenantID);
            query = query.Include(e => e.NavListFF141)
                         .Include(e => e.NavListFF143)
                         .Include(e => e.NavListFF144);

            CSICP_FF140? CSICP_FF140 = await query.FirstOrDefaultAsync(e => e.Ff140Id == InFF140ID);
            return CSICP_FF140;
        }

        private IQueryable<CSICP_FF140> GetQueryBase(int InTenantID)
        {
            return _appDbContext.OsusrE9aCsicpFf140s
                   .AsNoTracking()
                   .Where(e => e.TenantId == InTenantID);
        }

        public async Task<(List<CSICP_FF140>, int)> GetListAsync(int InTenantID, PrmFiltrosFF140Repo prm)
        {
            IQueryable<CSICP_FF140> query = GetQueryBase(InTenantID).AsNoTracking().AsSplitQuery()
            .Include(e => e.NavBB001EstabID)
            .Include(e => e.NavBB005CCustoID)
            .Include(e => e.NavBB006AgCobradorID)
            .Include(e => e.NavBB008CondicaoID)
            .Include(e => e.NavBB009TpCobrancaID)
            .Include(e => e.NavBB012ContaID)
            .Include(e => e.NavBB026FPagto)
            .Include(e => e.NavFF003EspecieID)
            .Include(e => e.NavSY001UsuarioPropID)
            .Include(e => e.NavFF140Status)
            .Include(e => e.NavFF140Exe)
            .Include(e => e.NavFF140Vinculo);

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_FF140>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosFF140Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return [
                new FiltroEstabIDFF140(filtros.InEstabID),
                new FiltroContaIDFF140(filtros.InContaID),
                new FiltroProtocoloNumberFF140(filtros.InProtocoloNumber),
                new FiltroDataFF140(filtros.InDataInicio, filtros.InDataFinal),
                new FiltroStatusIDFF140(filtros.InStatusID),
            ];
        }
    }
}
