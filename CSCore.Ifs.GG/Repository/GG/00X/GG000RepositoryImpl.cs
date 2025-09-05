using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG000RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseImpl<CSICP_GG000>(appDbContext, "Gg000Id"), IGG000Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_GG000?> GetByIdAsync(long id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg000s
                    .AsSplitQuery()
                   .Where(e => e.TenantId == tenant).AsNoTracking()
                   .Where(e => e.Gg000Id == id)
                   .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_GG000>, int)> GetListAsync(int tenant, int pageSize, int page)
        {

            IQueryable<CSICP_GG000> q1 = _appDbContext.OsusrE9aCsicpGg000s
                .AsSplitQuery()
                .Where(e => e.TenantId == tenant).AsNoTracking();

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }

        public async Task<CSICP_GG000?> RecuperaUltimoCodigo(int tenant)
        {
            var ultCodigo = await _appDbContext.OsusrE9aCsicpGg000s
                .Where(e => e.TenantId == tenant)
                .FirstOrDefaultAsync();
            return ultCodigo;

        }
    }
}
