using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB060Repository(AppDbContext context) : IBB060Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb060> CreateAsync(CSICP_Bb060 entity)
        {
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb060?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb060?>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb060?> q1 = QueryWithIncludes(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb060> RemoveAsync(CSICP_Bb060 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb060> UpdateAsync(CSICP_Bb060 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb060> ChangeActive(CSICP_Bb060 entity)
        {
            entity.Bb060Isactive = !entity.Bb060Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb060> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb060> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb060Descricao ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb060Isactive == isActive);
            }

            return query;
        }


        private IQueryable<CSICP_Bb060> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb060s
                .AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }
        private IQueryable<CSICP_Bb060?> QueryWithIncludes(int tenant)
        {
            return CreateBaseQuery(tenant)
            .Include(e => e.Bb060Agcobrador)
            .Include(e => e.Bb060Ccusto)
            .Include(e => e.Bb060Condicao)
            .Include(e => e.Bb060Convmaster)
            .Include(e => e.Bb060Responsavel)
            .Include(e => e.Bb060Tipocobranca)
            .Include(e => e.FormaPagamento)
            .OrderBy(e => e.Bb060Descricao);
        }

        private async Task<CSICP_Bb060?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Bb060Convenioid == long.Parse(id));
        }
    }
}
