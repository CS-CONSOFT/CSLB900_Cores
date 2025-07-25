using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB007cRepository(AppDbContext context) : IBB007cRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB007c> CreateAsync(CSICP_BB007c entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_BB007c>> GetAllByParentId(string resId, int tenant)
        {
            var query = CreateBaseQuery(tenant);
            query = query.Where(e => e.Bb007Responid == resId);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<CSICP_BB007c>> GetAllToUseOnBB007(string bb007Id, int tenant)
        {
            return await _appDbContext
                 .OsusrE9aCsicpBb007cs
                 .AsSplitQuery()
                 .AsNoTracking()
                 .Include(e => e.Bb012Conta)
                 .Where(e => e.Bb007Responid == bb007Id)
                 .Where(c => c.TenantId == tenant).ToListAsync();

        }

        public async Task<CSICP_BB007c?> GetEntityAsync(string pkId, int tenant)
        {
            var query = CreateBaseQuery(tenant);
            query = query.Where(e => e.Bb007cId == long.Parse(pkId));
            return await query.FirstOrDefaultAsync();
        }

        public async Task<CSICP_BB007c> RemoveAsync(CSICP_BB007c entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_BB007c> CreateBaseQuery(int tenant)
        {
            return from bb007 in _appDbContext.OsusrE9aCsicpBb007cs
                   where bb007.TenantId == tenant

                   join bb012 in _appDbContext.OsusrE9aCsicpBb012s
                     on bb007.Bb012Contaid equals bb012.Id into bb012Join
                   from bb012 in bb012Join.DefaultIfEmpty()


                   select new CSICP_BB007c
                   {
                       TenantId = bb007.TenantId,
                       Bb007cId = bb007.Bb007cId,
                       Bb007Responid = bb007.Bb007Responid,
                       Bb012Contaid = bb007.Bb012Contaid,
                       Bb007cPcomissao = bb007.Bb007cPcomissao,
                       Bb012Conta = new CSICP_BB012
                       {
                           TenantId = bb012.TenantId,
                           Id = bb012.Id,
                           Bb012Codigo = bb012.Bb012Codigo,
                           Bb012NomeCliente = bb012.Bb012NomeCliente,
                           Bb012NomeFantasia = bb012.Bb012NomeFantasia,

                       }
                   };


        }
    }
}
