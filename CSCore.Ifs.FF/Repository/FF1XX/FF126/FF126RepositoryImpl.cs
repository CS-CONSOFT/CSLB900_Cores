using CSCore.Domain.Interfaces.FF._1XX.FF126;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
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


        public async Task<string> GetFF126IdPeloTituloFF102(int InTenantID, string InFF102_ID)
        {
            return await appDbContext.OsusrE9aCsicpFf126s
                .AsNoTracking()
                .Where(e => e.TenantId == InTenantID && e.Ff126TituloId == InFF102_ID)


                .Select(e => e.Ff126Id)
                .FirstOrDefaultAsync() ?? "";
        }
    }
}
