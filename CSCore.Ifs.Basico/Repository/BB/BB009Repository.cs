using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB009Repository(AppDbContext context) : IBB009Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb009> CreateAsync(CSICP_Bb009 bb009)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb009>
            (_appDbContext, bb009.Bb009Codigo, null, "Bb009Codigo", "Id");
            bb009.Bb009Codigo = novoCodigo;
            _appDbContext.Add(bb009);
            await _appDbContext.SaveChangesAsync();
            return bb009;
        }

        public async Task<CSICP_Bb009?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb009>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb009> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb009> RemoveAsync(CSICP_Bb009 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb009> UpdateAsync(CSICP_Bb009 bb009)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb009>
            (_appDbContext, bb009.Bb009Codigo, bb009.Id, "Bb009Codigo", "Id");
            bb009.Bb009Codigo = novoCodigo;
            _appDbContext.Update(bb009);
            await _appDbContext.SaveChangesAsync();
            return bb009;
        }


        public async Task<CSICP_Bb009> ChangeActive(CSICP_Bb009 entity)
        {
            entity.Bb009Isactive = !entity.Bb009Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb009> FiltraQuandoExisteFiltros
            (string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb009> query)
        {
            if (searchCode != null)
            {
                query = query
                    .Where(entity => (entity.Bb009Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb009Tipocobranca!.ToString() ?? "").Contains(search.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb009Isactive == isActive);
            }

            return query;
        }


        private IQueryable<CSICP_Bb009> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb009s
                .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb009Tipocobranca);
        }


        private async Task<CSICP_Bb009?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
