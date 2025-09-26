using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG
{
    public class GG001RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG001>(appDbContext), IGG001Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public override CSICP_GG001 Create(CSICP_GG001 gg001)
        {
            int novoCodigo 
                = IncrementarCodigo
                .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG001>
                (_appDbContext, gg001.Gg001Codigoalmox, null, "Gg001Codigoalmox", "Id");

            gg001.Gg001Codigoalmox = novoCodigo;
            _appDbContext.Add(gg001);

            return gg001;
        }

        public async Task<CSICP_GG001?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.CSICP_GG001s
                   .AsSplitQuery()
                  .Where(e => e.TenantId == tenant).AsNoTracking()
                  .Where(e => e.Id == id)
                  .Include(e => e.BB001FilialNav)
                  .Include(e => e.Gg001TipoalmoxarifadoNavigation)
                  .FirstOrDefaultAsync();
        }

        public async Task<(IEnumerable<CSICP_GG001>, int)> GetListAsync
            (int tenant, string? estabID, string? codAlmox, int pageSize, int page, string? search, bool isAtivo)
        {
            IQueryable<CSICP_GG001> q1 = _appDbContext.CSICP_GG001s
                .AsSplitQuery()
                .Where(e => e.TenantId == tenant).AsNoTracking()
                .Include(e => e.BB001FilialNav)
                .Include(e => e.Gg001TipoalmoxarifadoNavigation)
                .OrderBy(e => e.Gg001Descalmox);

            q1 = FiltraQuandoExisteFiltros(search, estabID, codAlmox, q1, isAtivo);

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);

            return (await q1.ToListAsync(), count);
        }
        public async Task<CSICP_GG001> UpdateAsync(CSICP_GG001 gg001)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG001>
            (_appDbContext, gg001.Gg001Codigoalmox, gg001.Id, "Gg003Codigogrupo", "Id");

            gg001.Gg001Codigoalmox = novoCodigo;
            _appDbContext.Update(gg001);
            await _appDbContext.SaveChangesAsync();
            return gg001;
        }

        private static IQueryable<CSICP_GG001> FiltraQuandoExisteFiltros
            (string? search, string? estabID, string? codAlmox, IQueryable<CSICP_GG001> query, bool isAtivo)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Gg001Descalmox ?? "").Contains(search ?? ""));
            }

            if (estabID != null)
                query = query.Where(e => e.Gg001Filialid == estabID);

            if (codAlmox != null)
                query = query.Where(e => e.Gg001Codigoalmox.ToString().Contains(codAlmox));

            query = query.Where(e => e.Gg001Isactive == isAtivo);

            return query;
        }
    }
}
