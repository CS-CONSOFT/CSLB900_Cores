using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB010Repository(AppDbContext context) : IBB010Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb010> CreateAsync(CSICP_Bb010 bb010)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb010>
                (_appDbContext, bb010.Bb010Codigo, null, "Bb010Codigo", "Id");

            bb010.Bb010Codigo = novoCodigo;
            _appDbContext.Add(bb010);
            await _appDbContext.SaveChangesAsync();
            return bb010;
        }

        public async Task<CSICP_Bb010?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb010>> GetListAsync(int tenant, string? search, bool? isActive)
        {
            IQueryable<CSICP_Bb010> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb010> RemoveAsync(CSICP_Bb010 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb010> UpdateAsync(CSICP_Bb010 bb010)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb010>
            (_appDbContext, bb010.Bb010Codigo, bb010.Id, "Bb010Codigo", "Id");
            bb010.Bb010Codigo = novoCodigo;
            _appDbContext.Update(bb010);
            await _appDbContext.SaveChangesAsync();
            return bb010;
        }


        public async Task<CSICP_Bb010> ChangeActive(CSICP_Bb010 entity)
        {
            entity.Bb010Isactive = !entity.Bb010Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb010> FiltraQuandoExisteFiltros(string? search, bool? isActive, IQueryable<CSICP_Bb010> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb010Zona.ToString() ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb010Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb010> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb010s
             .AsSplitQuery()
             .AsNoTracking()
             .Where(e => e.TenantId == tenant)
             .Include(e => e.Bb010Banco01)
             .Include(e => e.Bb010Banco02)
             .Include(e => e.Bb010Banco03)
             .Include(e => e.Bb010Ccusto)
             .Include(e => e.Bb010Vendedor)
             .OrderBy(e => e.Bb010Zona);
        }

        private async Task<CSICP_Bb010?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
