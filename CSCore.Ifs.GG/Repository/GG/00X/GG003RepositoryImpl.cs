using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG;
using CSCore.Ifs.Compartilhado.Utilidade;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG
{
    public class GG003RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseComMudaAtivoImpl<CSICP_GG003>(appDbContext),
        IGG003Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG003> CreateAsync(CSICP_GG003 gg003)
        {
            int novoCodigo = IncrementarCodigo.IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG003>
            (_appDbContext, gg003.Gg003Codigogrupo, null, "Gg003Codigogrupo", "Id");
            gg003.Gg003Codigogrupo = novoCodigo;
            _appDbContext.Add(gg003);
            await _appDbContext.SaveChangesAsync();
            return gg003;
        }
        public async Task<CSICP_GG003?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg003s
                    .Where(e => e.TenantId == tenant).AsNoTracking()
                    .Where(e => e.Id == id)
                    .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CSICP_BB001>> GetListaEstabelecimentoParaGrupo(int tenant)
        {
            return await _appDbContext.E9ACSICP_BB001s
                .Where(e => e.TenantId == tenant)
                .Where(e => e.Bb001Isactive == true)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> CreateAsyncParaGrupo(IEnumerable<CSICP_BB001> listaTodosEstabelecimentos,
           int tenant, string grupoID)
        {
            using (var transiction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    int entidadesSalvar = 0;
                    CSICP_GG060 entidadeTrabalhoGG060 = new()
                    {
                        Gg060Id = 0,
                        TenantId = tenant,
                        Gg060EstabId = null,
                        Gg060Grupoid = grupoID,
                        Gg060Subgrupoid = null,
                        Gg060Plucro = 0,
                        Gg060Isactive = true,
                        Gg060Dregistro = DateTime.UtcNow.ToLocalTime(),
                        Gg060Pmaxdesconto = 0,
                        Gg060Ispadrao = true,
                    };

                    _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;

                    int saveChangesCount = await _appDbContext.SaveChangesAsync();

                    _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;

                    foreach (var currentBB001 in listaTodosEstabelecimentos)
                    {
                        entidadeTrabalhoGG060.Gg060Id = 0;
                        entidadeTrabalhoGG060.Gg060EstabId = currentBB001.Id;
                        entidadeTrabalhoGG060.Gg060Dregistro = DateTime.UtcNow.ToLocalTime();

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;

                        int saveChangesResult = await _appDbContext.SaveChangesAsync();
                        entidadesSalvar = entidadesSalvar + saveChangesResult;

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;
                    }
                    await transiction.CommitAsync();
                    return entidadesSalvar + saveChangesCount;
                }
                catch (Exception ex)
                {
                    await transiction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }

        public async Task<(IEnumerable<CSICP_GG003>, int)> GetListAsync
            (int tenant, int pageSize, int page, string? search, bool isActive)
        {
            var q1 = _appDbContext.OsusrE9aCsicpGg003s
                    .Where(e => e.TenantId == tenant).AsNoTracking()
                    .Where(e => e.Gg003Isactive == isActive)
                    .AsQueryable();

            q1 = FiltraQuandoExisteFiltros(search, q1, isActive);

            var queryCount = q1;
            var count = queryCount.Count();

            q1 = q1.PaginacaoNoBanco(page, pageSize);
            return (await q1.ToListAsync(), count);
        }
        public async Task<CSICP_GG003> UpdateAsync(CSICP_GG003 gg003)
        {
            int novoCodigo = IncrementarCodigo
            .IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG003>
            (_appDbContext, gg003.Gg003Codigogrupo, gg003.Id, "Gg003Codigogrupo", "Id");

            gg003.Gg003Codigogrupo = novoCodigo;
            _appDbContext.Update(gg003);
            await _appDbContext.SaveChangesAsync();
            return gg003;
        }

        private static IQueryable<CSICP_GG003> FiltraQuandoExisteFiltros(
            string? search, IQueryable<CSICP_GG003> query, bool isAtivo)
        {
            if (search != null)
            {
                query = query
                    .Where(entity => (entity.Gg003Descgrupo ?? "").Contains(search ?? ""));
            }

            query = query.Where(e => e.Gg003Isactive == isAtivo);

            return query;
        }


    }
}
