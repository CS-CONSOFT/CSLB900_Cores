using CSCore.Domain;
using CSCore.Domain.CS_Models;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.SY
{
    public class SY001RepositoryLogin : ISY001RepositoryLogin
    {
        private AppDbContext _appDbContext;

        public SY001RepositoryLogin(AppDbContext context) => _appDbContext = context;


        public async Task<int> GetTenantByDominio(string dominio)
        {
            OssysTenant? ossysTenant = await _appDbContext.OssysTenants
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Name == dominio && e.IsActive == true);
            if (ossysTenant is null) throw new KeyNotFoundException("Dominio não encontrado");
            return ossysTenant.Id;
        }

        public async Task<Csicp_Sy001?> GetByUsernameAsync(string username, int tenant)
        {
            Csicp_Sy001? csicp_Sy001 = await _appDbContext.OsusrE9aCsicpSy001s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Sy001Usuario == username.ToLower()).FirstOrDefaultAsync();
            if (csicp_Sy001 is null) throw new KeyNotFoundException("Usuário não encontrado");
            return csicp_Sy001;
        }


        public async Task<Csicp_Sy001?> GetByIdAsync(string usuarioId, int tenant)
        {
            Csicp_Sy001? csicp_Sy001 = await _appDbContext.OsusrE9aCsicpSy001s
              .AsNoTracking()
              .Where(e => e.TenantId == tenant)
              .Where(e => e.Id == usuarioId).FirstOrDefaultAsync();
            return csicp_Sy001;
        }

        public async Task<List<Csicp_Sy003Regra?>> GetRolesAsync(string usuarioId, int tenant)
        {
            List<Csicp_Sy003Regra?> sy003RegrasList = await _appDbContext.OsusrE9aCsicpSy006s
                .Where(e => e.Sy006Userid == usuarioId)
                .Where(e => e.TenantId == tenant)
                .Include(e => e.Sy006Regraestatica)
                .Select(e => e.Sy006Regraestatica)
                //.DistinctBy(e => e.Label)
                .ToListAsync();
            return sy003RegrasList;
        }

        public async Task<bool> CheckPasswordAsync(Csicp_Sy001 user, string password, int tenant)
        {
            Csicp_Sy001? csicp_Sy001 = await _appDbContext.OsusrE9aCsicpSy001s
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Userid == user.Userid)
                .FirstOrDefaultAsync();

            if (csicp_Sy001 is null) throw new Exception();

            return csicp_Sy001.Sy001Senhacs == password;
        }

    }
}
