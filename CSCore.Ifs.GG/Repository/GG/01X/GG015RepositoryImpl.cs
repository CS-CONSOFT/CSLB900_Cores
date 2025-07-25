using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._01X
{
    public class GG015RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG015>(appDbContext, "Id", "TenantId"),
        IGG015Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<int> CreateAsync(CSICP_GG015 gg015Entity, string grupoID,
            string subGrupoID, IEnumerable<CSICP_BB001> listaTodosEstabelecimentos)
        {
            using (var transaction = await _appDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    _appDbContext.Entry(gg015Entity).State = EntityState.Added;
                    await _appDbContext.SaveChangesAsync();
                    _appDbContext.Entry(gg015Entity).State = EntityState.Detached;

                    await SalvaGG060ComEstabNulo(gg015Entity, grupoID, subGrupoID);

                    //await SalvaGG060ComEstabPreenchido(gg015Entity, grupoID, subGrupoID);

                    CSICP_GG060 entidadeTrabalhoGG060 = new()
                    {
                        Gg060Id = 0,
                        TenantId = gg015Entity.TenantId,
                        Gg060EstabId = null,
                        Gg060Grupoid = grupoID,
                        Gg060Subgrupoid = subGrupoID,
                        Gg060Plucro = 0,
                        Gg060Isactive = true,
                        Gg060Dregistro = DateTime.UtcNow.ToLocalTime(),
                        Gg060Pmaxdesconto = 0,
                        Gg060Ispadrao = false,
                    };
                    //_appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;
                    //await _appDbContext.SaveChangesAsync();
                    //_appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;

                    foreach (var currentEstab in listaTodosEstabelecimentos)
                    {
                        entidadeTrabalhoGG060.Gg060Id = 0;
                        entidadeTrabalhoGG060.Gg060EstabId = currentEstab.Id;
                        entidadeTrabalhoGG060.Gg060Dregistro = DateTime.UtcNow.ToLocalTime();

                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Added;
                        await _appDbContext.SaveChangesAsync();
                        _appDbContext.Entry(entidadeTrabalhoGG060).State = EntityState.Detached;
                    }
                    await transaction.CommitAsync();
                    return 0;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
                }
            }
        }



        private async Task SalvaGG060ComEstabNulo(CSICP_GG015 gg015Entity, string grupoID, string subGrupoID)
        {
            CSICP_GG060 csicp_gg060_sem_estab = new()
            {
                TenantId = gg015Entity.TenantId,
                Gg060EstabId = null,
                Gg060Grupoid = grupoID,
                Gg060Subgrupoid = subGrupoID,
                Gg060Plucro = 0,
                Gg060Isactive = true,
                Gg060Dregistro = DateTime.UtcNow.ToLocalTime(),
                Gg060Pmaxdesconto = 0,
                Gg060Ispadrao = false,
            };
            _appDbContext.Entry(csicp_gg060_sem_estab).State = EntityState.Added;
            await _appDbContext.SaveChangesAsync();
            _appDbContext.Entry(csicp_gg060_sem_estab).State = EntityState.Detached;
        }

        public async Task<CSICP_GG015?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg015s
                  .Where(e => e.TenantId == tenant).AsNoTracking()
                  .Where(e => e.Id == id)
                  .FirstOrDefaultAsync();
        }


        public async Task<(IEnumerable<CSICP_GG015>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, bool isActive)
        {
            IQueryable<CSICP_GG015> query = _appDbContext.OsusrE9aCsicpGg015s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .AsQueryable()
                 .OrderBy(e => e.Gg015Subgrupo); //verificar se está correto esse orderby por subgrupo.

            query = FiltraQuandoExisteFiltros(search, query, isActive);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG015> FiltraQuandoExisteFiltros
            (string? search, IQueryable<CSICP_GG015> query, bool isAtivo)
        {
            query = query.Where(e => e.Gg015IsActive == isAtivo);

            return query;
        }


    }
}

