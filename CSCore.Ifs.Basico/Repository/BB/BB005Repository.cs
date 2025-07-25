using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB005Repository(AppDbContext context) : IBB005Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb005> CreateAsync(CSICP_Bb005 bb005)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb005>
            (_appDbContext, bb005.Bb005Codigo, null, "Bb005Codigo", "Id");

            bb005.Bb005Codigo = novoCodigo;
            _appDbContext.Add(bb005);
            await _appDbContext.SaveChangesAsync();
            return bb005;
        }

        public async Task<CSICP_Bb005?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb005>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb005> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb005> RemoveAsync(CSICP_Bb005 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb005> UpdateAsync(CSICP_Bb005 bb005)
        {
       
            _appDbContext.Update(bb005);
            await _appDbContext.SaveChangesAsync();
            return bb005;
        }

        public async Task<CSICP_Bb005> ChangeActive(CSICP_Bb005 entity)
        {
            entity.Bb005Isactive = !entity.Bb005Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb005> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb005> query)
        {
            if (search != null)
            {
                query = query
                     .Where(entity => (entity.Bb005Nomeccusto ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb005Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }


            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb005Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb005> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb005s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb005Nomeccusto)
;
        }

        private async Task<CSICP_Bb005?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
