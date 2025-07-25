using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB007dRepository(AppDbContext context) : IBB007dRepository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB007d> CreateAsync(CSICP_BB007d entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<CSICP_BB007d>> GetAllByParentId(string resId, int tenant)
        {
            return await _appDbContext
                 .OsusrE9aCsicpBb007ds
                 .AsNoTracking()
                 .Include(e => e.CSICP_GG001)
                    .ThenInclude(e => e.BB001FilialNav)
                .Include(e => e.CSICP_GG001)
                    .ThenInclude(e => e.Gg001TipoalmoxarifadoNavigation)
                          .Where(c => c.TenantId == tenant && c.Bb007Responid == resId)
                          .AsQueryable().ToListAsync();
        }

        public async Task<IEnumerable<CSICP_BB007d>> GetAllToUseOnBB007(string bb007Id, int tenant)
        {
            List<CSICP_BB007d> csicpBb007dList = await _appDbContext
                 .OsusrE9aCsicpBb007ds
                 .AsNoTracking()
                 .Include(e => e.CSICP_GG001)
                    .ThenInclude(e => e.BB001FilialNav)
                .Include(e => e.CSICP_GG001)
                    .ThenInclude(e => e.Gg001TipoalmoxarifadoNavigation)
                 .Where(c => c.TenantId == tenant)
                 .Where(c => c.Bb007Responid == bb007Id).ToListAsync();



            return csicpBb007dList;
        }

        public async Task<CSICP_BB007d?> GetEntityAsync(string pkId, int tenant)
        {
            return await CreateBaseQuery(tenant, long.Parse(pkId)).FirstOrDefaultAsync();
        }

        public async Task<CSICP_BB007d> RemoveAsync(CSICP_BB007d entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        private IQueryable<CSICP_BB007d> CreateBaseQuery(int tenant, long id)
        {
            return _appDbContext
                .OsusrE9aCsicpBb007ds
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.CSICP_GG001)
                    .ThenInclude(e => e.BB001FilialNav)
                .Where(c => c.TenantId == tenant)
                .Where(c => c.Bb007dId == id)

                ;
        }
    }
}
