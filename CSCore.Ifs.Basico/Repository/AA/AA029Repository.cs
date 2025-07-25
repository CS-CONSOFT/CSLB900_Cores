using CSCore.Domain;
using CSCore.Domain.Interfaces.AA;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.AA
{
    public class AA029Repository(AppDbContext context) : IAA029Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_AA029> CreateAsync(CSICP_AA029 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_AA029?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_AA029>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_AA029> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1
            .ToListAsync();
        }

        public async Task<CSICP_AA029> RemoveAsync(CSICP_AA029 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_AA029> UpdateAsync(CSICP_AA029 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_AA029> ChangeActive(CSICP_AA029 entity)
        {
            entity.Aa029Isactive = !entity.Aa029Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_AA029> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_AA029> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Aa029Cnae ?? "").Contains(search ?? "") ||
                           (entity.Aa029Descricao ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                  .Where(entity => entity.Aa029Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_AA029> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpAa029s.AsNoTracking()
           .Where(e => e.TenantId == tenant)
           .OrderBy(e => e.Aa029Descricao);
        }

        private async Task<CSICP_AA029?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Aa029Id == id);
        }

        public Task<IEnumerable<CSICP_AA029>> GetListAsync(int tenant, string? search)
        {
            throw new NotImplementedException();
        }

    }
}

