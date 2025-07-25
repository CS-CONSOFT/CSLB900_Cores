using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB012qRepository(AppDbContext context) : IBB012qRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB012q> CreateAsync(CSICP_BB012q entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012q?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB012q? entity = await _appDbContext.OsusrE9aCsicpBb012qs.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }


        public async Task<CSICP_BB012q> RemoveAsync(CSICP_BB012q entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012q> UpdateAsync(CSICP_BB012q entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
