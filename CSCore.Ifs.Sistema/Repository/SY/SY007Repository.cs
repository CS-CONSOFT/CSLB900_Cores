using CSCore.Domain;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY007Repository : ISY007Repository
    {
        private AppDbContext _appDbContext;

        public SY007Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy007> CreateAsync(Csicp_Sy007 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<Csicp_Sy007> RemoveAsync(Csicp_Sy007 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy007?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }


        public async Task<IEnumerable<Csicp_Sy007>> GetBySy002IdAsync(string sy002ID, int tenant)
        {
            return await CreateBaseQuery(tenant)
               .Where(e => e.Sy007Grupoid == sy002ID)
               .Include(e => e.Sy007Regraestatica)
               .ToListAsync();
        }


        private IQueryable<Csicp_Sy007> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy007s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant);
        }

        private async Task<Csicp_Sy007?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}