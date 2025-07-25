using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG011RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG011>(appDbContext),
        IGG011Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG011> CreateAsync(CSICP_GG011 gg011)
        {
            int codigoAtual = string.IsNullOrWhiteSpace(gg011.Gg011CodigoQualidade) ? 0 : int.Parse(gg011.Gg011CodigoQualidade);

            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG011>
            (_appDbContext, codigoAtual, null, "Gg011CodigoQualidade", "Id");

            gg011.Gg011CodigoQualidade = novoCodigo.ToString();
            _appDbContext.Add(gg011);
            await _appDbContext.SaveChangesAsync();
            return gg011;
        }

        public async Task<CSICP_GG011?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg011s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Id == id)
                 .Include(e => e.NavFilial)
                 .FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG011>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, string? codigo, bool isActive = true)
        {
            IQueryable<CSICP_GG011> query = _appDbContext.OsusrE9aCsicpGg011s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .AsQueryable()
                 .OrderBy(e => e.Gg011Descricaoqualidade);

            query = FiltraQuandoExisteFiltros(search, codigo, query, isActive);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        public async Task<CSICP_GG011> UpdateAsync(CSICP_GG011 gg011)
        {
            int codigoAtual = string.IsNullOrWhiteSpace(gg011.Gg011CodigoQualidade)
                ? 0 : int.Parse(gg011.Gg011CodigoQualidade);

            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG011>
            (_appDbContext, codigoAtual, gg011.Id, "Gg011CodigoQualidade", "Id");

            gg011.Gg011CodigoQualidade = novoCodigo.ToString();
            _appDbContext.Update(gg011);
            await _appDbContext.SaveChangesAsync();
            return gg011;
        }

        private static IQueryable<CSICP_GG011> FiltraQuandoExisteFiltros
            (string? search, string? codigo, IQueryable<CSICP_GG011> query, bool isAtivo)
        {
            query = query.Where(e => e.Gg011IsActive == isAtivo);
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg011Descricaoqualidade ?? "").Contains(search ?? ""));
            }

            if (codigo != null)
            {
                query = query.Where(entity => (entity.Gg011CodigoQualidade ?? "").Contains(codigo ?? ""));
            };

            return query;
        }

    }
}
