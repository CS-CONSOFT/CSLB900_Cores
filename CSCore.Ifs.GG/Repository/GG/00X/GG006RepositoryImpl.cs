using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG006RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG006>(appDbContext), IGG006Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG006> CreateAsync(CSICP_GG006 gg006)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG006>
            (_appDbContext, gg006.Gg006Codigomarca, null, "Gg006Codigomarca", "Id");
            gg006.Gg006Codigomarca = novoCodigo;
            _appDbContext.Add(gg006);
            await _appDbContext.SaveChangesAsync();
            return gg006;
        }
        public async Task<CSICP_GG006?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg006s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Id == id).FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG006>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, int? codigo, bool? isActive = true)
        {
            IQueryable<CSICP_GG006> query = _appDbContext.OsusrE9aCsicpGg006s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Gg006IsActive == isActive)
                 .OrderBy(e => e.Gg006Descmarca)
                 .AsQueryable();

            query = FiltraQuandoExisteFiltros(search, codigo, query);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }
        public async Task<CSICP_GG006> UpdateAsync(CSICP_GG006 gg006)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG006>
            (_appDbContext, gg006.Gg006Codigomarca, gg006.Id, "Gg006Codigomarca", "Id");

            gg006.Gg006Codigomarca = novoCodigo;
            _appDbContext.Update(gg006);
            await _appDbContext.SaveChangesAsync();
            return gg006;
        }

        private static IQueryable<CSICP_GG006> FiltraQuandoExisteFiltros(string? search, int? codigo, IQueryable<CSICP_GG006> query)
        {
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg006Descmarca ?? "").Contains(search ?? ""));
            }

            if (codigo != null)
            {
                query = query
                    .Where(entity => (entity.Gg006Codigomarca.ToString() ?? "")
                    .Contains(codigo.ToString() ?? ""));
            }
            return query;
        }

    }
}
