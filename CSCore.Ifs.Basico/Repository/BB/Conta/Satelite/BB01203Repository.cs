using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB01203Repository(AppDbContext context) : IBB01203Repository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB01203> CreateAsync(CSICP_BB01203 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB01203?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB01203? entity = await _appDbContext.OsusrE9aCsicpBb01203s.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }

        public async Task<CSICP_BB01203> RemoveAsync(CSICP_BB01203 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB01203> UpdateAsync(CSICP_BB01203 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
