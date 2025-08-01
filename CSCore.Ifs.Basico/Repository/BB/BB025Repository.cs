using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB025Repository(AppDbContext context) : IBB025Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb025> CreateAsync(CSICP_Bb025 bb025)
        {
            int codigoAtual = string.IsNullOrWhiteSpace(bb025.Bb025Codigo)
                ? 0 : int.Parse(bb025.Bb025Codigo);

            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb025>
            (_appDbContext, codigoAtual, null, "Bb025Codigo", "Id");

            bb025.Bb025Codigo = novoCodigo.ToString();
            _appDbContext.Add(bb025);
            await _appDbContext.SaveChangesAsync();
            return bb025;
        }

        public async Task<CSICP_Bb025?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb025>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb025> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb025> RemoveAsync(CSICP_Bb025 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb025> UpdateAsync(CSICP_Bb025 bb025)
        {
            var entity = await _appDbContext.OsusrE9aCsicpBb025s.FindAsync(bb025.Id);
            if (entity == null)
                throw new InvalidOperationException("Entidade não encontrada.");

            int codigoAtual = string.IsNullOrWhiteSpace(bb025.Bb025Codigo)
                ? 0 : int.Parse(bb025.Bb025Codigo);

            int novoCodigo = IncrementarCodigo
                .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb025>
                (_appDbContext, codigoAtual, bb025.Id, "Bb025Codigo", "Id");

            bb025.Bb025Codigo = novoCodigo.ToString();

            // Copia todos os valores da entidade recebida para a rastreada
            _appDbContext.Entry(entity).CurrentValues.SetValues(bb025);

            await _appDbContext.SaveChangesAsync();
            return entity;
        }


        public async Task<CSICP_Bb025> ChangeActive(CSICP_Bb025 entity)
        {
            entity.Bb025Isactive = !entity.Bb025Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb025> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb025> query)
        {

            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb025Descricao ?? "").Contains(search ?? "") ||
                           (entity.Bb025Codigo ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb025Isactive == isActive);
            }

            if (searchCode != null)
            {
                query = query
                   .Where(entity => (entity.Bb025Codigo ?? "").Contains(searchCode.ToString() ?? ""));
            }
            return query;
        }


        private IQueryable<CSICP_Bb025> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb025s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.Bb025Transacao)
                .Include(e => e.osusr66CSpedInAjIcm)
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb025Descricao);
        }

        private async Task<CSICP_Bb025?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
