using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB029Repository(AppDbContext context) : IBB029Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb029> CreateAsync(CSICP_Bb029 entity)
        {
            int novoCodigo = IncrementarCodigo
                   .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb005>
                   (_appDbContext, entity.Bb029Codgcategoria, null, "Bb029Codgcategoria", "Id");

            entity.Bb029Codgcategoria = novoCodigo;
            _appDbContext.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb029?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb029>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb029> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb029> RemoveAsync(CSICP_Bb029 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb029> UpdateAsync(CSICP_Bb029 entity)
        {
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb029> ChangeActive(CSICP_Bb029 entity)
        {
            entity.Bb029IsActive = !entity.Bb029IsActive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb029> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb029> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb029Categoria ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb029IsActive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb029> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb029s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb029Categoria);
        }


        private async Task<CSICP_Bb029?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

