using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB01207Repository(AppDbContext context) : IBB01207Repository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB01207> CreateAsync(CSICP_BB01207 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB01207?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB01207? entity = await _appDbContext.OsusrE9aCsicpBb01207s.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }


        public async Task<CSICP_BB01207> RemoveAsync(CSICP_BB01207 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
