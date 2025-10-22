using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public interface IFF143Repository : IRepositorioBase<CSICP_FF143>
    {
        Task<(List<CSICP_FF143>, int)> GetByFF140IdAsync(long? ff140Id, int tenantId, int pageNumber, int pageSize);
    }
    public class FF143RepositoryImpl : RepositorioBaseImpl<CSICP_FF143>, IFF143Repository
    {
        private AppDbContext AppDbContext;

        public FF143RepositoryImpl(AppDbContext context, AppDbContext appDbContext) : base(context)
        {
            AppDbContext = appDbContext;
        }

        public async Task<(List<CSICP_FF143>, int)> GetByFF140IdAsync(long? ff140Id, int tenantId, int pageNumber, int pageSize)
        {
            var query = AppDbContext.OsusrE9aCsicpFf143s.Where(e => e.TenantId == tenantId);
            if(ff140Id != null)
                    query = query.Where(e => e.Ff140RdId == ff140Id);

            var querycount = query;
            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var count = await querycount.CountAsync();
            return (await query.ToListAsync(), count);
        }
    }
}
