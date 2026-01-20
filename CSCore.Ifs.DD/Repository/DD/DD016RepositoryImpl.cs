using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.DD.Repository.DD
{
    public class DD016RepositoryImpl : RepositoryBaseV2ComGets<CSICP_DD016>, IDD016Repository
    {
        private readonly AppDbContext _appDbContext;
        
        public DD016RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Dd016Id", "TenantId")
        {
            _appDbContext = appDbContext;
        }

        public override async Task<(IEnumerable<CSICP_DD016> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize)
        {
            // Query inicial com includes
            var query = _appDbContext.OsusrTeiCsicpDd016s
                .AsNoTracking()
                .Include(e => e.NavBB001FilialID_DD016)
                .Include(e => e.NavBB008CondicaoID_DD016)
                .Include(e => e.NavGG003GrupoID_DD016)
                .Include(e => e.NavGG004ClasseID_DD016)
                .Include(e => e.NavGG005ArtigoID_DD016)
                .Include(e => e.NavGG006MarcaID_DD016)
                .Include(e => e.NavDD016Aplicacao_DD016)
                .Include(e => e.NavDD001RComercializ_DD016)
                .AsQueryable();

            // Aplica filtros dinâmicos usando o método da classe base
            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();
            var data = await query.PaginacaoNoBanco(pageNumber, pageSize).ToListAsync();

            return (data, totalCount);
        }

        public override async Task<CSICP_DD016?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrTeiCsicpDd016s
                .AsNoTracking()
                .Include(e => e.NavBB001FilialID_DD016)
                .Include(e => e.NavBB008CondicaoID_DD016)
                .Include(e => e.NavGG003GrupoID_DD016)
                .Include(e => e.NavGG004ClasseID_DD016)
                .Include(e => e.NavGG005ArtigoID_DD016)
                .Include(e => e.NavGG006MarcaID_DD016)
                .Include(e => e.NavDD016Aplicacao_DD016)
                .Include(e => e.NavDD001RComercializ_DD016)
                .Where(e => e.TenantId == tenant && e.Dd016Id == id)
                .FirstOrDefaultAsync();
        }
    }
}