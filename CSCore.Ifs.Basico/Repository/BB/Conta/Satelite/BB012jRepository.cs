using CSCore.Domain;
using CSCore.Domain.Interfaces.BB.Conta.Satelite;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB.Conta.Satelite
{
    public class BB012jRepository(AppDbContext context) : IBB012jRepository
    {
        private readonly AppDbContext _appDbContext = context;
        public async Task<CSICP_BB012j> CreateAsync(CSICP_BB012j entity)
        {
            _appDbContext.Add(entity.NavBB1206_Endereco!);

            entity.NavBB1206_Endereco = null;
            _appDbContext.Add(entity);

            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB012j?> GetEntityAsync(string id, int tenant)
        {
            CSICP_BB012j? entity = await _appDbContext.OsusrE9aCsicpBb012js.Where(e => e.Id == id && e.TenantId == tenant)
              .FirstOrDefaultAsync();
            return entity;
        }

        public async Task<CSICP_BB012j> UpdateAsync(CSICP_BB012j entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_BB012j> RemoveAsync(CSICP_BB012j entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
