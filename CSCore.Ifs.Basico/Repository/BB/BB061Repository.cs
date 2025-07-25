using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB061Repository(AppDbContext context) : IBB061Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb061> CreateAsync(CSICP_Bb061 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb061?> GetByIdAsync(long id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb061>> GetListAsync(int tenant, bool? isActive, string contaID)
        {
            IQueryable<CSICP_Bb061> q1 = QueryWithIncludes(tenant).AsQueryable();
            q1 = q1.Where(e => e.Bb012Contaid == contaID);
            q1 = FiltraQuandoExisteFiltros(isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb061> RemoveAsync(CSICP_Bb061 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb061> UpdateAsync(CSICP_Bb061 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb061> ChangeActive(CSICP_Bb061 entity)
        {
            entity.Bb061Isactive = !entity.Bb061Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb061> FiltraQuandoExisteFiltros(bool? isActive, IQueryable<CSICP_Bb061> query)
        {
            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb061Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb061> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb061s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }

        private IQueryable<CSICP_Bb061> QueryWithIncludes(int tenant)
        {
            return CreateBaseQuery(tenant)
            .Include(e => e.NavBb060Convenio)
            .Include(e => e.CSICP_BB012)
            .Include(e => e.CSICP_BB01208)
                .ThenInclude(e => e.NavCSICP_BB035)
            .Include(e => e.CSICP_BB01208)
                .ThenInclude(e => e.NavCSICP_BB035Gpa)
            .Include(e => e.Bb061Tipoass);
        }
        private async Task<CSICP_Bb061?> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb061Id == id);
        }
    }
}
