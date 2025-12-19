using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB006Repository(AppDbContext context) : IBB006Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb006> CreateAsync(CSICP_Bb006 bb006)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb006>
            (_appDbContext, bb006.Bb006Codgbanco, null, "Bb006Codgbanco", "Id");

            bb006.Bb006Codgbanco = novoCodigo;
            _appDbContext.Add(bb006);
            await _appDbContext.SaveChangesAsync();
            return bb006;
        }

        public async Task<CSICP_Bb006?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb006>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb006> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb006> RemoveAsync(CSICP_Bb006 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb006> UpdateAsync(CSICP_Bb006 bb006)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb006>
            (_appDbContext, bb006.Bb006Codgbanco, bb006.Id, "Bb006Codgbanco", "Id");

            bb006.Bb006Codgbanco = novoCodigo;
            _appDbContext.Update(bb006);
            await _appDbContext.SaveChangesAsync();
            return bb006;
        }


        public async Task<CSICP_Bb006> ChangeActive(CSICP_Bb006 entity)
        {
            entity.Bb006Isactive = !entity.Bb006Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb006> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb006> query)
        {

            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb006Banco ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb006Codgbanco.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb006Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb006> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb006s.AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb006Banco);
        }

        private async Task<CSICP_Bb006?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
