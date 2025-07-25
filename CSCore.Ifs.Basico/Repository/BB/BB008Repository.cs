using CSCore.Domain;
using CSCore.Domain.Interfaces.BB;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.BB
{
    public class BB008Repository(AppDbContext context) : IBB008Repository
    {
        private readonly AppDbContext _appDbContext = context;

        public async Task<CSICP_Bb008> CreateAsync(CSICP_Bb008 bb008)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb008>
            (_appDbContext, bb008.Bb008Codigo, null, "Bb008Codigo", "Id");
            bb008.Bb008Codigo = novoCodigo;
            _appDbContext.Add(bb008);
            await _appDbContext.SaveChangesAsync();
            return bb008;
        }

        public async Task<CSICP_Bb008?> GetByIdAsync(string id, int tenant)
        {
            return await GetEntityById(id, tenant);
        }

        public async Task<IEnumerable<CSICP_Bb008>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive)
        {
            IQueryable<CSICP_Bb008> q1 = CreateBaseQuery(tenant).AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, searchCode, isActive, q1);
            return await q1.ToListAsync();
        }

        public async Task<CSICP_Bb008> RemoveAsync(CSICP_Bb008 entity)
        {
            _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<CSICP_Bb008> UpdateAsync(CSICP_Bb008 bb008)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_Bb008>
            (_appDbContext, bb008.Bb008Codigo, bb008.Id, "Bb008Codigo", "Id");
            bb008.Bb008Codigo = novoCodigo;
            _appDbContext.Update(bb008);
            await _appDbContext.SaveChangesAsync();
            return bb008;
        }


        public async Task<CSICP_Bb008> ChangeActive(CSICP_Bb008 entity)
        {
            entity.Bb008Isactive = !entity.Bb008Isactive;
            _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }



        private static IQueryable<CSICP_Bb008> FiltraQuandoExisteFiltros(string? search, int? searchCode, bool? isActive, IQueryable<CSICP_Bb008> query)
        {

            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Bb008CondicaoPagto ?? "").Contains(search ?? ""));
            }

            if (searchCode != null)
            {
                query = query
                    .Where(entity => (entity.Bb008Codigo.ToString() ?? "").Contains(searchCode.ToString() ?? ""));
            }

            if (isActive != null)
            {
                query = query
                   .Where(entity => entity.Bb008Isactive == isActive);
            }

            return query;
        }


        private IQueryable<CSICP_Bb008> CreateBaseQuery(int tenant)
        {
            return _appDbContext.OsusrE9aCsicpBb008s
                .AsSplitQuery()
                .Include(e => e.NavBB008_Aprova_Venda)
                .Include(e => e.NavBB008_EntLiquidada)
                .Include(e => e.NavBB008_ParcLiquidadas)
                .Include(e => e.CSICP_BB001)
                .Include(e => e.CSICP_Bb008Tipo)
                .AsNoTracking()
            .Where(e => e.TenantId == tenant)
            .OrderBy(e => e.Bb008CondicaoPagto);
        }


        private async Task<CSICP_Bb008?> GetEntityById(string id, int tenant)
        {
            return await CreateBaseQuery(tenant)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
