using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.RR._00X.IRR010;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Rebanho.RR010Repository
{
    public class RR010RepositoryImpl : RepositorioBaseImplV2<OsusrTo3CsicpRr010>, IRR010Repository
    {
        private readonly AppDbContext _appDbContext;

        public RR010RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<OsusrTo3CsicpRr010?> GetByIdAsync(int tenantId, long id)
        {
            return await _appDbContext.OsusrTo3CsicpRr010s
                .AsNoTracking()
                .Where(e => e.TenantId == tenantId && e.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}