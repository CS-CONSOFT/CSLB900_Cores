using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._02X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._02X
{
    public class GG022RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG022>(appDbContext),
        IGG022Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG022?> GetByIdAsync(int tenant, string id, string? Gg022Ncmid, string? Gg022Ufid, decimal? Gg022Pfcp)
        {
            IQueryable<CSICP_GG022> query = _appDbContext.OsusrE9aCsicpGg022s
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Gg022Id == id)
                 .Include(e => e.NavGg021Ncm);

            query = FiltrosNecessariosEntidade(Gg022Ncmid, Gg022Ufid, Gg022Pfcp, query);

            CSICP_GG022? result = await query.FirstOrDefaultAsync();
            return result;
        }


        public async Task<(IEnumerable<CSICP_GG022>, int)> GetListAsync
            (int tenant, int pageSize, int page, string? Gg022Ncmid, string? Gg022Ufid, decimal? Gg022Pfcp)
        {
            IQueryable<CSICP_GG022> query = _appDbContext.OsusrE9aCsicpGg022s
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Include(e => e.NavGg021Ncm)
                 .AsQueryable();

            query = FiltrosNecessariosEntidade(Gg022Ncmid, Gg022Ufid, Gg022Pfcp, query);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }


        private static IQueryable<CSICP_GG022> FiltrosNecessariosEntidade
            (string? Gg022Ncmid, string? Gg022Ufid, decimal? Gg022Pfcp, IQueryable<CSICP_GG022> query)
        {
            if (Gg022Ncmid is not null) query = query.Where(e => e.Gg022Ncmid == Gg022Ncmid);
            if (Gg022Ufid is not null) query = query.Where(e => e.Gg022Ufid == Gg022Ufid);
            if (Gg022Pfcp is not null) query = query.Where(e => e.Gg022Pfcp == Gg022Pfcp);
            return query;
        }
    }
}
