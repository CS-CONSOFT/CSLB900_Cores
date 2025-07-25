using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG
{
    public class GG002RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG002>(appDbContext), IGG002Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG002?> GetByIDAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg002s
                 .Include(e => e.NavSpedTipoItem)
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Id == id).FirstOrDefaultAsync();

        }

        public async Task<(IEnumerable<CSICP_GG002>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, bool? isActive = true)
        {
            IQueryable<CSICP_GG002> q1 = _appDbContext.OsusrE9aCsicpGg002s
                .Include(e => e.NavSpedTipoItem)
                .Where(e => e.TenantId == tenant).AsNoTracking()
                .Where(e => e.Gg002Isactive == isActive).AsQueryable()
                .OrderBy(e => e.NavSpedTipoItem.Label);


            q1 = FiltraQuandoExisteFiltros(search, q1);

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG002> FiltraQuandoExisteFiltros
            (string? search, IQueryable<CSICP_GG002> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Gg002Desctipoproduto ?? "").Contains(search ?? ""));
            }

            return query;
        }

    }
}
