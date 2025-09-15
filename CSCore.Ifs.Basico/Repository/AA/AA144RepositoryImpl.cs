using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Basico.Repository.AA
{
    public class AA144RepositoryImpl(AppDbContext appDbContext) : IAA144Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        //AA144 não tem TenantId
        public async Task<(List<OsusrE9aCsicpAa144>, int)> GetListAsync(int in_pageSize, int in_pageNumber)
        {
            var queryCount = _appDbContext.OsusrE9aCsicpAa144s
            .AsNoTracking();

            var count = await queryCount.CountAsync();
            var query = queryCount.PaginacaoNoBanco(in_pageSize, in_pageNumber);

            return (await query.ToListAsync(), count);
        }
    }
}