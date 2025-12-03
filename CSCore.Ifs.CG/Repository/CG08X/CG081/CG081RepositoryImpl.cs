using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG08X.CG081;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG08X.CG081
{
    public class CG081RepositoryImpl : RepositorioBaseImplV2<Osusr8dwCsicpCg081>, ICG081Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG081RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg081Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<Osusr8dwCsicpCg081?> GetByIdAsync(int InTenantID, long InCG081ID)
        {
            var query = _appDbContext.Osusr8dwCsicpCg081s
                .AsNoTracking()
                .Where(e => e.Cg081Id == InCG081ID && e.TenantId == InTenantID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<Osusr8dwCsicpCg081>, int)> GetListAsync(
            int InTenantID, long InCG080ID, int InPageNumber, int InPageSize)
        {
            IQueryable<Osusr8dwCsicpCg081> query = _appDbContext.Osusr8dwCsicpCg081s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID
                    && e.Cg081Contrelconfid == InCG080ID)
                .Include(e => e.NavCG081ContRelConf)
                .Include(e => e.NavCG081ASID)
                .Include(e => e.NavCG081ContRelRegistroSup)
                .Include(e => e.NavCG993NaturezaSaldo); 
            //verificar se a propriedade Contrelconfid é a correta

            var queryCount = query;
            var count = await queryCount.CountAsync();

            query = query.OrderBy(e => e.Cg081Id);
            query = query.PaginacaoNoBanco(InPageNumber, InPageSize);

            return (await query.ToListAsync(), count);
        }
    }
}