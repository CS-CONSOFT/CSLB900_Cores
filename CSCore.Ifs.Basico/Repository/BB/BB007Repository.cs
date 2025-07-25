using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB007Repository(AppDbContext context) : IBB007Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_BB007> CreateAsync(CSICP_BB007 bb007)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_BB007>
            (_appDbContext, bb007.Bb007Codigo, null, "Bb007Codigo", "Id");
            bb007.Bb007Codigo = novoCodigo;
            _appDbContext.Add(bb007);
            await _appDbContext.SaveChangesAsync();
            return bb007;
        }

        public async Task<CSICP_BB007?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_BB007>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_BB007> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            List<CSICP_BB007> cSICP_BB007s = await q1.ToListAsync();
            return cSICP_BB007s;
        }

        public async Task<CSICP_BB007> RemoveAsync(CSICP_BB007 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_BB007> UpdateAsync(CSICP_BB007 bb007)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_BB007>
            (_appDbContext, bb007.Bb007Codigo, bb007.Id, "Bb007Codigo", "Id");
            bb007.Bb007Codigo = novoCodigo;
            _appDbContext.Update(bb007);
            await _appDbContext.SaveChangesAsync();
            return bb007;
        }


        public async Task<CSICP_BB007> ChangeActive(CSICP_BB007 entity)
        {
            entity.Bb007Isactive = !entity.Bb007Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_BB007> FiltraQuandoExisteFiltros
            (string? search,
            int? searchCode,
            bool? isActive,
            IQueryable<CSICP_BB007> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb007Responsavel ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                    .Where(entity => entity.Bb007Codigo.ToString().Contains(searchCode.ToString()));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb007Isactive == isActive);
            }

            return query;
        }


        private IQueryable<CSICP_BB007> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb007s.AsNoTracking()
            .AsSplitQuery()
            .AsNoTracking()
            .Where(e => e.TenantId == tenant)


            .Include(e => e.Bb007Ccusto)
            .Include(e => e.Bb007CodggerenteNavigation)
            .Include(e => e.Bb007CodgsupervisorNavigation)
            .Include(e => e.Bb031Funcao)
            .Include(e => e.Bb001Empresa)
            .Include(e => e.CSICP_GG001)
            .Include(e => e.CSICP_GG001)
                .ThenInclude(e => e.Gg001TipoalmoxarifadoNavigation)
            .Include(e => e.Bb032Cargo)
            .OrderBy(e => e.Bb007Responsavel);
        }

        private async Task<CSICP_BB007?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
