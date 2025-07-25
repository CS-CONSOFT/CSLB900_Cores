using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB01208Repository(AppDbContext context) : IBB01208Repository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB01208> CreateAsync(CSICP_BB01208 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB01208?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB01208? entity = await _appDbContext.OsusrE9aCsicpBb01208s.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }


        public async Task<CSICP_BB01208> UpdateAsync(CSICP_BB01208 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_BB01208> RemoveAsync(CSICP_BB01208 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

    }
}
