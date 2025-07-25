using CSCore.Domain.CS_Models.CSICP_BB.BB01X;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB015Repository(AppDbContext context) : IBB015Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB015> CreateAsync(CSICP_BB015 entity)
        {
            bool valido = ValidaCnpj.CnpjValido(entity.Bb015Cnpj);
            if (!valido)
            {
                throw new Exception("CNPJ inválido.");
            }
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB015?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(long.Parse(id), tenant);
        }

        public async Task<IEnumerable<CSICP_BB015>> GetListAsync(int tenant, string? search)
        {
            IQueryable<CSICP_BB015> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_BB015> RemoveAsync(CSICP_BB015 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB015> UpdateAsync(CSICP_BB015 entity)
        {
            bool valido = ValidaCnpj.CnpjValido(entity.Bb015Cnpj);
            if (!valido)
            {
                throw new Exception("CNPJ inválido.");
            }
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        private static IQueryable<CSICP_BB015> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_BB015> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb015Marketplace ?? "").Contains(search ?? ""));
            }

            return query;
        }


        private IQueryable<CSICP_BB015> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicoBb015s.AsNoTracking()
            .Where(e => e.TenantId == tenant);
        }
        private async Task<CSICP_BB015?> GetEntityById(long id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
