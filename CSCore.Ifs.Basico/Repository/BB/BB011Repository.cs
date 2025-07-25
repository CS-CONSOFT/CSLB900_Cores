using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB011Repository(AppDbContext context) : IBB011Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb011> CreateAsync(CSICP_Bb011 bb011)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb011>
            (_appDbContext, bb011.Bb011Codigo, null, "Bb011Codigo", "Id");
            bb011.Bb011Codigo = novoCodigo;
            _appDbContext.Add(bb011);
            await _appDbContext.SaveChangesAsync();
            return bb011;
        }

        public async Task<CSICP_Bb011?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb011>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb011> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb011> RemoveAsync(CSICP_Bb011 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb011> UpdateAsync(CSICP_Bb011 bb011)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb011>
            (_appDbContext, bb011.Bb011Codigo, bb011.Id, "Bb011Codigo", "Id");
            bb011.Bb011Codigo = novoCodigo;
            _appDbContext.Update(bb011);
            await _appDbContext.SaveChangesAsync();
            return bb011;
        }


        public async Task<CSICP_Bb011> ChangeActive(CSICP_Bb011 entity)
        {
            entity.Bb011IsActive = !entity.Bb011IsActive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb011> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb011> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb011Atividade ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                    .Where(entity => (entity.Bb011Codigo.ToString() ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb011IsActive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb011> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb011s
             .AsNoTracking()
             .Where(e => e.TenantId == tenant)
             .OrderBy(e => e.Bb011Atividade);
        }

        private async Task<CSICP_Bb011?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
