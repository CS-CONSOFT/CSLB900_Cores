using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX.FF126;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF126
{
    public class FF126RepositoryImpl : IFF126Repository
    {
        private readonly AppDbContext appDbContext;

        public FF126RepositoryImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<CSICP_FF126?> GetFF126PeloTituloFF102(int InTenantID, string InFF102_ID)
        {
            return await appDbContext.OsusrE9aCsicpFf126s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Ff126TituloId == InFF102_ID)
                .FirstOrDefaultAsync();
        }
    }
}
