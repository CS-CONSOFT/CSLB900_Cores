using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._02X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._02X
{
    public class GG021RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG021>(appDbContext),
        IGG021Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG021?> GetByIdAsync(string id, int tenant)
        {
            CSICP_GG021? result = await _appDbContext.OsusrE9aCsicpGg021s
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant)
                 .AsNoTracking()
                 .Where(e => e.Id == id)
                 .Include(e => e.NavGg007Un)
                 .Include(e => e.NavGg021Cest)
                 .Include(e => e.NavSpedGenero)
                 .FirstOrDefaultAsync();
            return result;
        }
        public async Task<(IEnumerable<CSICP_GG021>, int)> GetListAsync(
            int tenant, int pageSize,
            int page, string? search, string? code, bool isActive)
        {
            IQueryable<CSICP_GG021> query = _appDbContext.OsusrE9aCsicpGg021s
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                   .Include(e => e.NavGg007Un)
                 .Include(e => e.NavGg021Cest)
                 .Include(e => e.NavSpedGenero)
                 .AsQueryable()
                 .OrderBy(e => e.Gg021Ncm);

            query = FiltraQuandoExisteFiltros(search, code, query, isActive);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG021> FiltraQuandoExisteFiltros(string? search, string? code, IQueryable<CSICP_GG021> query, bool isAtivo)
        {
            query = query.Where(e => e.Gg021IsActive == isAtivo);
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg021Descricao ?? "").Contains(search ?? ""));
            }

            if (code != null)
            {
                query = query.Where(entity => (entity.Gg021Ncm.ToString() ?? "").Contains(code ?? ""));
            }

            return query;
        }
    }
}
