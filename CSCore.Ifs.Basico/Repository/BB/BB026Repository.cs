using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB026Repository(AppDbContext context) : IBB026Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb026> CreateAsync(CSICP_Bb026 bb026)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb026>
            (_appDbContext, bb026.Bb026Codigo, null, "Bb026Codigo", "Id");

            bb026.Bb026Codigo = novoCodigo;
            _appDbContext.Add(bb026);
            await _appDbContext.SaveChangesAsync();
            return bb026;
        }

        public async Task<CSICP_Bb026?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb026>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb026> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb026> RemoveAsync(CSICP_Bb026 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb026> UpdateAsync(CSICP_Bb026 bb026)
        {
            int novoCodigo = IncrementarCodigo
                .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb026>
                (_appDbContext, bb026.Bb026Codigo, bb026.Id, "Bb026Codigo", "Id");

            bb026.Bb026Codigo = novoCodigo;

            // Garante que não há outra instância rastreada
            var local = _appDbContext.ChangeTracker.Entries<CSICP_Bb026>()
                .FirstOrDefault(e => e.Entity.Id == bb026.Id);

            if (local != null)
                local.State = EntityState.Detached;

            _appDbContext.Attach(bb026);
            _appDbContext.Entry(bb026).State = EntityState.Modified;

            await _appDbContext.SaveChangesAsync();
            return bb026;
        }


        public async Task<CSICP_Bb026> ChangeActive(CSICP_Bb026 entity)
        {
            entity.Bb026Isactive = !entity.Bb026Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb026> FiltraQuandoExisteFiltros
            (string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb026> query)
        {
            if (searchCode != null)
            {
                query = query
                    .Where(entity => (entity.Bb026Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb026Formapagamento!.ToString() ?? "").Contains(search ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb026Isactive == isActive);
            }
            return query;
        }


        private IQueryable<CSICP_Bb026> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb026s
                .AsSplitQuery()
                .AsNoTracking()
                .Include(e => e.Bb026Administradora)
                .Include(e => e.Bb026Condpagtofixo)
                .Include(e => e.NavBb026Classe)
                .Include(e => e.NavBb026Tipo)
                .Include(e => e.NavBb026Vin)
                .Include(e => e.NavBB026_DadosCartaoSN)
                //.Include(e => e.NavCSICP_FF003Tpesp)
                .Include(e => e.NavBB026_DadosChequeSN)
                .Include(e => e.NavBB026_VincCupomFiscal)
                .Where(e => e.TenantId == tenant)
                .OrderBy(e => e.Bb026Formapagamento);
        }

        private async Task<CSICP_Bb026?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
