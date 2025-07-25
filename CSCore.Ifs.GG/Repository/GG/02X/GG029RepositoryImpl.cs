using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._02X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._02X
{
    public class GG029RepositoryImpl(AppDbContext appDbContext) : RepositorioBaseImpl<CSICP_GG029>(appDbContext, "Gg029Id"), IGG029Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG029?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg029s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Gg029Id == id)
                 .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_GG029>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, string? codigo)
        {
            IQueryable<CSICP_GG029> query = _appDbContext.OsusrE9aCsicpGg029s
              .Where(e => e.TenantId == tenant).AsNoTracking()
              .AsQueryable()
              .OrderBy(e => e.Gg029Descricao);

            query = FiltraQuandoExisteFiltros(search, codigo, query);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG029> FiltraQuandoExisteFiltros(string? search, string? codigo, IQueryable<CSICP_GG029> query)
        {
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg029Descricao ?? "").Contains(search ?? ""));
            }

            if (codigo != null)
            {
                query = query.Where(entity => (entity.Gg029Codganp ?? "").Contains(codigo ?? ""));
            }

            return query;
        }
    }
}
