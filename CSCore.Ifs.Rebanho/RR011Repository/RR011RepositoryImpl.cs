using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR011;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR011Repository
{
    public class RR011RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr011>, IRR011Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR011RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr011?> GetByIdAsync(int tenantId, long id)
        {
            return await _appDbContext.OsusrTo3CsicpRr011s
                .AsNoTracking()
                .Where(e => e.TenantId == tenantId && e.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}