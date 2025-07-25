using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB031Repository(AppDbContext context) : IBB031Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb031> CreateAsync(CSICP_Bb031 bb031)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb031>
            (_appDbContext, bb031.Bb031Codgfuncaoid, null, "Bb031Codgfuncaoid", "Id");
            bb031.Bb031Codgfuncaoid = novoCodigo;
            _appDbContext.Add(bb031);
            await _appDbContext.SaveChangesAsync();
            return bb031;
        }

        public async Task<CSICP_Bb031?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb031>> GetListAsync
            (int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb031> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            if(searchCode != null)
            {
                q1 = q1.Where(e => e.Bb031Codgfuncaoid == searchCode);
            }
            
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb031> RemoveAsync(CSICP_Bb031 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb031> UpdateAsync(CSICP_Bb031 bb031)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb031>
            (_appDbContext, bb031.Bb031Codgfuncaoid, bb031.Id, "Bb031Codgfuncaoid", "Id");
            bb031.Bb031Codgfuncaoid = novoCodigo;
            _appDbContext.Update(bb031);
            await _appDbContext.SaveChangesAsync();
            return bb031;
        }


        public async Task<CSICP_Bb031> ChangeActive(CSICP_Bb031 entity)
        {
            entity.Bb031Isactive = !entity.Bb031Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb031> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb031> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb031Descricao ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb031Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb031> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb031s.AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb031Descricao);
        }

        private async Task<CSICP_Bb031?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

