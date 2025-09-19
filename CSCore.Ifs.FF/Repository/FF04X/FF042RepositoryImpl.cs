using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._04X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF04X
{
    public class FF042RepositoryImpl : RepositorioBaseImpl<CSICP_FF042>, IFF042Repository
    {
        private readonly AppDbContext _appDbContext;

        public FF042RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext, "Ff040Id", "TenantId")
        {
            _appDbContext = appDbContext;
        }

        public async Task<(List<CSICP_FF042>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize)
        {
            IQueryable<CSICP_FF042> query = _appDbContext.OsusrE9aCsicpFf042s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID);
                //.Include(e => e.NavListFF043); 

            //Filtros

            query = query.OrderBy(e => e.Ff040Id);

            var count = await query.CountAsync();

            var lista = await query
                .Skip((InPageNumber - 1) * InPageSize)
                .Take(InPageSize)
                .ToListAsync();

            return (lista, count);
        }
    }
}
