using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._01X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._01X
{
    public class GG017RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG017>(appDbContext),
        IGG017Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG017> CreateAsync(CSICP_GG017 entity)
        {
            await DefineValorDoNivelDaEntidade(entity);
            CSICP_GG017 cSICP_GG017 = base.Create(entity);
            return cSICP_GG017;
        }


        public override async Task<CSICP_GG017?> UpdateAsync(long id, int tenant, CSICP_GG017 entity)
        {
            await DefineValorDoNivelDaEntidade(entity);
            return await base.UpdateAsync(id, tenant, entity);
        }


        public async Task<CSICP_GG017?> GetByIdAsync(long id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg017s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Gg017Id == id)
                 .Include(e => e.NavGg017Categoriapai)
                 .AsSplitQuery()
                 .FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG017>, int)> GetListAsync(int tenant, string? search, int pageSize, int page)
        {
            IQueryable<CSICP_GG017> query = _appDbContext.OsusrE9aCsicpGg017s
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Include(e => e.NavGg017Categoriapai)
                 .AsSplitQuery()
                 .AsQueryable()
                 .OrderBy(e => e.Gg017Desccategoria);

            var queryCount = query;
            var count = queryCount.Count();

            query = FiltraQuandoExisteFiltros(search, query);

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_GG017> FiltraQuandoExisteFiltros(string? search, IQueryable<CSICP_GG017> query)
        {
            if (search != null)
            {
                query = query.Where(entity => (entity.Gg017Desccategoria ?? "").Contains(search ?? ""));
            }

            return query;
        }


        private async Task DefineValorDoNivelDaEntidade(CSICP_GG017 entity)
        {
            if (entity.Gg017CategoriapaiId is not null)
            {
                await Recupera_Nivel_Da_Entidade_Pai_E_Incrementa_Em_Um_O_NivelAtual(entity);
            }
            else
                entity.Gg017Nivel = 0;
        }
        private async Task Recupera_Nivel_Da_Entidade_Pai_E_Incrementa_Em_Um_O_NivelAtual(CSICP_GG017 entity)
        {
            int? nivelSalvo = await _appDbContext.OsusrE9aCsicpGg017s
                .Where(e => e.Gg017CategoriapaiId == entity.Gg017CategoriapaiId)
                .Select(e => e.Gg017Nivel)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            entity.Gg017Nivel = nivelSalvo + 1;
        }

    }
}
