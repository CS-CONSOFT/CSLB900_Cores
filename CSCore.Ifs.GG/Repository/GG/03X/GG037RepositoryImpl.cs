using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._03X
{
    public class GG037RepositoryImpl(AppDbContext appDbContext) : IGG037Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(IEnumerable<CSICP_GG037>, int)> GetListAsync(int tenant, string IDInventario, int pageSize, int page)
        {
            IQueryable<CSICP_GG037> query = _appDbContext.OsusrE9aCsicpGg037s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Gg037InventarioId == IDInventario)
                .AsQueryable();

            var queryCount = query;
            int count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }
    }
}
