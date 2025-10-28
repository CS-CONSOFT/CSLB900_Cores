using CSCore.Ifs.CS_Context;
using CSCore.Ifs.NN.CSICP_NN015.Interface;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.NN.CSICP_NN015
{
    public class NN015RepositoryImpl : RepositorioBaseImpl<Domain.CS_Models.CSICP_NN.CSICP_NN015>, INN015Repository
    {
        private readonly AppDbContext _appDbContext;

        public NN015RepositoryImpl(AppDbContext appDbContext)
            : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<Domain.CS_Models.CSICP_NN.CSICP_NN015?> GetByIdAsync(int tenant, string id)
        {
            var query = _appDbContext.OsusrE9aCsicpNn015s
                .AsNoTracking();
            query = query.Where(e => e.TenantId == tenant && e.Nn015CrcpId == id);
            return query.FirstOrDefaultAsync();

        }

        public async Task<(IEnumerable<Domain.CS_Models.CSICP_NN.CSICP_NN015>, int)> GetListAsync(int tenant, int page, int pageSize)
        {
            var query = _appDbContext.OsusrE9aCsicpNn015s.Where(e => e.TenantId == tenant)
                   .AsNoTracking();

            var queryCount = query;
            var count = queryCount.Count();
            query = query.OrderBy(e => e.Nn015CrcpId);
            query = query.PaginacaoNoBanco(page, pageSize);
            return (await query.ToListAsync(), count);
        }
    }
}
