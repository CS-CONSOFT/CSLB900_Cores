using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG009RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG009>(appDbContext), IGG009Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG009> CreateAsync(CSICP_GG009 CSICP_GG009)
        {
            string codigoAtual = string.IsNullOrWhiteSpace(CSICP_GG009.Gg009Codigopadrao) ? "0" : CSICP_GG009.Gg009Codigopadrao;

            string novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG009>
            (_appDbContext, codigoAtual, null, "Gg009Codigopadrao", "Id");

            CSICP_GG009.Gg009Codigopadrao = novoCodigo.ToString();
            _appDbContext.Add(CSICP_GG009);
            await _appDbContext.SaveChangesAsync();
            return CSICP_GG009;
        }
        public async Task<CSICP_GG009?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg009s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Id == id)
                 .Include(e => e.NavFilialBB001)
                 .FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG009>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, string? code, bool? isActive = true)
        {
            IQueryable<CSICP_GG009> query = _appDbContext.OsusrE9aCsicpGg009s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Gg009IsActive == isActive).AsQueryable()
                 .OrderBy(e => e.Gg009Descpadrao);

            query = FiltraQuandoExisteFiltros(search, code, query);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG009> FiltraQuandoExisteFiltros(
            string? search, string? code, IQueryable<CSICP_GG009> query, bool? isAtivo = true)
        {

            if (search != null)
            {
                query = query.Where(entity => (entity.Gg009Descpadrao ?? "").Contains(search ?? ""));
            }

            if (code != null)
            {
                query = query.Where(entity => (entity.Gg009Codigopadrao ?? "").Contains(code ?? ""));
            }
            return query;
        }

    }
}
