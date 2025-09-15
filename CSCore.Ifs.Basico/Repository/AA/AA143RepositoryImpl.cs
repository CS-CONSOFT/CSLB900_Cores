using CSCore.Domain.CS_Models.CSICP_AA;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Basico.Repository.AA
{
    public class AA143RepositoryImpl(AppDbContext appDbContext) : IAA143Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        //AA143 não tem TenantId
        public async Task<(List<CSICP_AA143>, int)> GetListAsync(int in_pageSize, int in_pageNumber)
        {
            var queryCount = _appDbContext.CSICP_AA143
            .AsNoTracking();

            var count = await queryCount.CountAsync();
            var query = queryCount.PaginacaoNoBanco(in_pageSize, in_pageNumber);

            return (await query.ToListAsync(), count);
        }
    }
}
