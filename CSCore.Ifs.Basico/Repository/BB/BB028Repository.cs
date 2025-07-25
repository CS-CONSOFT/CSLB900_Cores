using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB028Repository(AppDbContext context) : IBB028Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb028> CreateAsync(CSICP_Bb028 bb028)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb028>
            (_appDbContext, bb028.Bb028Codigo, null, "Bb028Codigo", "Id");
            bb028.Bb028Codigo = novoCodigo;
            _appDbContext.Add(bb028);
            await _appDbContext.SaveChangesAsync();
            return bb028;
        }

        public async Task<CSICP_Bb028?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityByIdWithInclude(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb028>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb028> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb028> RemoveAsync(CSICP_Bb028 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb028> UpdateAsync(CSICP_Bb028 bb028)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb028>
            (_appDbContext, bb028.Bb028Codigo, bb028.Id, "Bb028Codigo", "Id");
            bb028.Bb028Codigo = novoCodigo;
            _appDbContext.Update(bb028);
            await _appDbContext.SaveChangesAsync();
            return bb028;
        }


        public async Task<CSICP_Bb028> ChangeActive(CSICP_Bb028 entity)
        {
            entity.Bb028Isactive = !entity.Bb028Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb028> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb028> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb028Nomeresponsavel ?? "").Contains(search ?? "") ||
                            (entity.Bb028Nomeresponsavel ?? "")!.Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb028Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb028Isactive == isActive);
            }

            return query;
        }


        private IQueryable<CSICP_Bb028> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb028s
                .AsNoTracking()
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb028Nomeresponsavel);
        }

        private async Task<CSICP_Bb028?> GetEntityByIdWithInclude(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .Include(e => e.NavBB012)
                .Include(e => e.NavBB028Tp)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
