using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.DD.Repository.DD
{
    public class DD008RepositoryImpl : RepositoryBaseV2ComGets<CSICP_DD008>, IDD008Repository
    {
        private readonly AppDbContext _appDbContext;
        
        public DD008RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Dd008Id", "TenantId")
        {
            _appDbContext = appDbContext;
        }

        public override async Task<(IEnumerable<CSICP_DD008> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize)
        {
            // Query inicial com includes
            var query = _appDbContext.OsusrTeiCsicpDd008s
                .AsNoTracking()
                .Include(e => e.NavBB001EmpresaID_DD008)
                .Include(e => e.NavBB007ResponsavelID_DD008)
                .Include(e => e.NavBB032CargoID_DD008)
                .Include(e => e.NavBB026FormaPagtoID_DD008)
                .Include(e => e.NavBB008CondPagtoID_DD008)
                .AsQueryable();

            // Aplica filtros dinâmicos usando o método da classe base
            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();
            var data = await query.PaginacaoNoBanco(pageNumber, pageSize).ToListAsync();

            return (data, totalCount);
        }

        public override async Task<CSICP_DD008?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrTeiCsicpDd008s
                .AsNoTracking()
                .Include(e => e.NavBB001EmpresaID_DD008)
                .Include(e => e.NavBB007ResponsavelID_DD008)
                .Include(e => e.NavBB032CargoID_DD008)
                .Include(e => e.NavBB026FormaPagtoID_DD008)
                .Include(e => e.NavBB008CondPagtoID_DD008)
                .Where(e => e.TenantId == tenant && e.Dd008Id == id)
                .FirstOrDefaultAsync();
        }
    }
}