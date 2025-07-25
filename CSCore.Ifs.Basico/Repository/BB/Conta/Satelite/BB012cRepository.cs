using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB012cRepository(AppDbContext context) : IBB012CRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB012c> CreateAsync(CSICP_BB012c entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012c?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB012c? entity = await _appDbContext.OsusrE9aCsicpBb012cs.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }


        public async Task<CSICP_BB012c> RemoveAsync(CSICP_BB012c entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012c> UpdateAsync(CSICP_BB012c entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
