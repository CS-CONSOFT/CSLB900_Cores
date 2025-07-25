using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB032Repository(AppDbContext context) : IBB032Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb032> CreateAsync(CSICP_Bb032 bb032)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb032>
            (_appDbContext, bb032.Bb032Codgcargoid, null, "Bb032Codgcargoid", "Id");
            bb032.Bb032Codgcargoid = novoCodigo;
            _appDbContext.Add(bb032);
            await _appDbContext.SaveChangesAsync();
            return bb032;
        }

        public async Task<CSICP_Bb032?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb032>> GetListAsync(int tenant, string? search,int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb032> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            if (searchCode != null)
            {
                q1 = q1.Where(e => e.Bb032Codgcargoid == searchCode);
            }
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb032> RemoveAsync(CSICP_Bb032 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb032> UpdateAsync(CSICP_Bb032 bb032)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb032>
            (_appDbContext, bb032.Bb032Codgcargoid, bb032.Id, "Bb032Codgcargoid", "Id");
            bb032.Bb032Codgcargoid = novoCodigo;
            _appDbContext.Update(bb032);
            await _appDbContext.SaveChangesAsync();
            return bb032;
        }


        public async Task<CSICP_Bb032> ChangeActive(CSICP_Bb032 entity)
        {
            entity.Bb032Isactive = !entity.Bb032Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb032> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb032> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb032Cargo ?? "").Contains(search ?? ""));
            }
            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb032Isactive == isActive);
            }

            return query;
        }


        private IQueryable<CSICP_Bb032> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb032s.AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb032Cargo);
        }


        private async Task<CSICP_Bb032?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
