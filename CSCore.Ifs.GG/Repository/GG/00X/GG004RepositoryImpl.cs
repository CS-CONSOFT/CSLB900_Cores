using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG004RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG004>(appDbContext), IGG004Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG004> CreateAsync(CSICP_GG004 gg004)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG004>
            (_appDbContext, gg004.Gg004Codigoclasse, null, "Gg004Codigoclasse", "Id");

            gg004.Gg004Codigoclasse = novoCodigo;
            _appDbContext.Add(gg004);
            await _appDbContext.SaveChangesAsync();
            return gg004;
        }
        public async Task<CSICP_GG004?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg004s
                      .Where(e => e.TenantId == tenant).AsNoTracking()
                      .Where(e => e.Id == id)
                      .Include(e => e.NavBB001Filial)
                      .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_GG004>, int)> GetListAsync
            (int tenant, int pageSize, int page, string? search, int? codigo, bool isActive)
        {

            IQueryable<CSICP_GG004> query = _appDbContext.OsusrE9aCsicpGg004s
                    .Where(e => e.TenantId == tenant).AsNoTracking()
                    .Where(e => e.Gg004Isactive == isActive)
                    .OrderBy(e => e.Gg004Descclasse);

            query = FiltraQuandoExisteFiltros(search, codigo, query, isActive);

            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }
        public async Task<CSICP_GG004> UpdateAsync(CSICP_GG004 gg004)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG004>
            (_appDbContext, gg004.Gg004Codigoclasse, gg004.Id, "Gg004Codigoclasse", "Id");

            gg004.Gg004Codigoclasse = novoCodigo;
            _appDbContext.Update(gg004);
            await _appDbContext.SaveChangesAsync();
            return gg004;
        }
        private static IQueryable<CSICP_GG004> FiltraQuandoExisteFiltros
            (string? search, int? codigo, IQueryable<CSICP_GG004> query, bool isAtivo)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Gg004Descclasse ?? "").Contains(search ?? ""));
            }

            if (codigo != null)
            {
                query = query
                  .Where(entity => (entity.Gg004Codigoclasse.ToString() ?? "").Contains(codigo.ToString() ?? ""));
            }

            query = query.Where(e => e.Gg004Isactive == isAtivo);

            return query;
        }
    }
}
