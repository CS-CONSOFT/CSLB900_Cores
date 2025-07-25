using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG
{
    public class GG005RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseComMudaAtivoImpl<CSICP_GG005>(appDbContext),
        IGG005Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG005> CreateAsync(CSICP_GG005 gg005)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG005>
            (_appDbContext, gg005.Gg005Codigoartigo, null, "Gg005Codigoartigo", "Id");
            gg005.Gg005Codigoartigo = novoCodigo;
            _appDbContext.Add(gg005);
            await _appDbContext.SaveChangesAsync();
            return gg005;
        }

        public async Task<CSICP_GG005?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg005s
                    .Where(e => e.TenantId == tenant).AsNoTracking()
                    .Where(e => e.Id == id).FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG005>, int)> GetListAsync(
            int tenant, int pageSize, int page, string? search, int? codigo, bool isActive)
        {
            IQueryable<CSICP_GG005> query = _appDbContext.OsusrE9aCsicpGg005s
                    .Where(e => e.TenantId == tenant)
                    .Where(e => e.Gg005Isactive == isActive)
                    .OrderBy(e => e.Gg005Descartigo)
                    .AsNoTracking()
                    .AsQueryable()
                    .OrderBy(e => e.Gg005Descartigo);

            query = FiltraQuandoExisteFiltros(search, codigo, query);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        public async Task<CSICP_GG005> UpdateAsync(CSICP_GG005 gg005)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG005>
            (_appDbContext, gg005.Gg005Codigoartigo, gg005.Id, "Gg005Codigoartigo", "Id");
            gg005.Gg005Codigoartigo = novoCodigo;
            _appDbContext.Update(gg005);
            await _appDbContext.SaveChangesAsync();
            return gg005;
        }

        private static IQueryable<CSICP_GG005> FiltraQuandoExisteFiltros
            (string? search, int? codigo, IQueryable<CSICP_GG005> query)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Gg005Descartigo ?? "").Contains(search ?? ""));
            }
            if (codigo != null) query = query.Where(e => e.Gg005Codigoartigo == codigo);
            return query;
        }

    }
}