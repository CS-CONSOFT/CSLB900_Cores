using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB012mRepository(AppDbContext context) : IBB012mRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB012m> CreateAsync(CSICP_BB012m entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012m?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB012m? entity = await _appDbContext.OsusrE9aCsicpBb012ms.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }


        public async Task<CSICP_BB012m> RemoveAsync(CSICP_BB012m entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
