using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY025Repository : ISY025Repository
    {
        private AppDbContext _appDbContext;

        public SY025Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy025?> GetSY025ByUserId(string userId)
        {
            try
            {
                Csicp_Sy025? csicp_Sy025 = await _appDbContext.OsusrE9aCsicpSy025s
                 .AsNoTracking()
                 .Where(e => e.Sy025Usuarioid == userId).FirstOrDefaultAsync();
                return csicp_Sy025;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException is not null ? ex.InnerException.Message : ex.Message);
            }
        }

        public async Task<Csicp_Sy025> UpdateAsync(Csicp_Sy025 csicp_Sy025)
        {
            _appDbContext.Update(csicp_Sy025);
            await _appDbContext.SaveChangesAsync();
            return csicp_Sy025;
        }

        public async Task<Csicp_Sy025> CreateAsync(Csicp_Sy025 csicp_Sy025)
        {
            _appDbContext.Add(csicp_Sy025);
            await _appDbContext.SaveChangesAsync();
            return csicp_Sy025;
        }
    }
}
