using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB012oRepository(AppDbContext context) : IBB012oRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB012o> CreateAsync(CSICP_BB012o entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012o?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB012o? entity = await _appDbContext.OsusrE9aCsicpBb012os.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }


        public async Task<CSICP_BB012o> RemoveAsync(CSICP_BB012o entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012o> UpdateAsync(CSICP_BB012o entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
