using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.SY;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;


namespace CSCore.Ifs.Repository.SY
{
    public class SY002Repository : ISY002Repository
    {
        private AppDbContext _appDbContext;

        public SY002Repository(AppDbContext context) => _appDbContext = context;

        public async Task<Csicp_Sy002> CreateAsync(Csicp_Sy002 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Csicp_Sy002> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<Csicp_Sy002>> GetListAsync(int tenant, string? search)
        {
            IQueryable<Csicp_Sy002> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<Csicp_Sy002> RemoveAsync(Csicp_Sy002 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<IReadOnlyCollection<object>> GetComboSY002(int tenant)
        {
            var list = await _appDbContext.OsusrE9aCsicpSy002s
                .Where(e => e.TenantId == tenant)
                .AsQueryable()
                .OrderBy(c => c.Sy002Grupo)
                .Select(c => new { Title = c.Sy002Grupo + "-" + c.Sy002Descricao, Id = c.Id }).ToListAsync();

            return list;
        }

        public async Task<IReadOnlyCollection<object>> GetComboSY003()
        {
            var list = await _appDbContext.OsusrE9aCsicpSy003Regras
                .AsQueryable()
                .OrderBy(c => c.Descricao)
                .Select(c => new { Title = c.Descricao, Id = c.Id }).ToListAsync();

            return list;
        }

        public async Task<Csicp_Sy002> UpdateAsync(Csicp_Sy002 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<Csicp_Sy002> FiltraQuandoExisteFiltros(string? search, IQueryable<Csicp_Sy002> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Sy002Descricao ?? "").Contains(search ?? ""));
            }

            return query;
        }


        private IQueryable<Csicp_Sy002> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpSy002s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Sy002Grupo);
        }

        private async Task<Csicp_Sy002?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Csicp_Sy003Regra>> GetListSY003Async(string? search)
        {
            var query = _appDbContext.OsusrE9aCsicpSy003Regras
                .AsQueryable();
            if (search != null)
            {
                query = query.Where(e => e.Label!.Contains(search) || e.Descricao!.Contains(search));
            }
            return await query.ToListAsync();
        }
    }
}
