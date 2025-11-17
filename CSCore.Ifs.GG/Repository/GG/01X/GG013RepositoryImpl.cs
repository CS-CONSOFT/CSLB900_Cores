using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG013RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG013>(appDbContext),
        IGG013Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG013?> GetByIdAsync(string gg013_gg08_id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg013s
                 .Where(e => e.TenantId == tenant)
                 .AsNoTracking()
                 .Where(e => e.Id == gg013_gg08_id)
                 .FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG013>, int)> GetListAsync
            (int tenant, string Produto_ID, int pageSize, int page, string? search)
        {
            IQueryable<CSICP_GG013> query = _appDbContext.OsusrE9aCsicpGg013s
                 .Where(e => e.TenantId == tenant)
                 .Where(e => e.Id == Produto_ID)
                 .AsNoTracking()
                 .AsQueryable();

            query = FiltraQuandoExisteFiltros(search, query);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG013> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_GG013> query)
        {
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg013Aplicacao ?? "").Contains(search ?? ""));
            }
            return query;
        }

        public async Task<IEnumerable<CSICP_GG013>> GetListAsync(int tenant, string Produto_ID, string? search)
        {
            IQueryable<CSICP_GG013> query = _appDbContext.OsusrE9aCsicpGg013s
                 .Where(e => e.TenantId == tenant)
                 .Where(e => e.Id == Produto_ID)
                 .AsNoTracking()
                 .AsQueryable();

            query = FiltraQuandoExisteFiltros(search, query);

            return await query.ToListAsync();
        }
    }
}