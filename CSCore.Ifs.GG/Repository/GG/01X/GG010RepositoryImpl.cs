using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG010RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG010>(appDbContext),
        IGG010Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG010> CreateAsync(CSICP_GG010 gg010)
        {
            int codigoAtual = string.IsNullOrWhiteSpace(gg010.Gg010CodigoTipopadrao) ? 0 : int.Parse(gg010.Gg010CodigoTipopadrao);

            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG010>
            (_appDbContext, codigoAtual, null, "Gg011CodigoQualidade", "Id");

            gg010.Gg010CodigoTipopadrao = novoCodigo.ToString();
            _appDbContext.Add(gg010);
            await _appDbContext.SaveChangesAsync();
            return gg010;
        }
        public async Task<CSICP_GG010?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg010s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Id == id)
                 .Include(e => e.NavFilial)
                 .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_GG010>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, string? codigo, bool isActive)
        {
            IQueryable<CSICP_GG010> query = _appDbContext.OsusrE9aCsicpGg010s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Include(e => e.NavFilial)
                 .AsQueryable()
                 .OrderBy(e => e.Gg010Descricaotipopadrao);

            query = FiltraQuandoExisteFiltros(search, codigo, query, isActive);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        public async Task<CSICP_GG010> UpdateAsync(CSICP_GG010 gg010)
        {
            int codigoAtual = string.IsNullOrWhiteSpace(gg010.Gg010CodigoTipopadrao)
                ? 0 : int.Parse(gg010.Gg010CodigoTipopadrao);

            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG011>
            (_appDbContext, codigoAtual, gg010.Id, "Gg011CodigoQualidade", "Id");

            gg010.Gg010CodigoTipopadrao = novoCodigo.ToString();
            _appDbContext.Update(gg010);
            await _appDbContext.SaveChangesAsync();
            return gg010;
        }

        private static IQueryable<CSICP_GG010> FiltraQuandoExisteFiltros(string? search, string? codigo, IQueryable<CSICP_GG010> query, bool? isAtivo = true)
        {
            query = query.Where(e => e.Gg010IsActive == isAtivo);
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg010Descricaotipopadrao ?? "").Contains(search ?? ""));
            }

            if (codigo != null)
            {
                query = query.Where(entity => (entity.Gg010CodigoTipopadrao ?? "").Contains(codigo ?? ""));
            };

            return query;
        }
    }
}
