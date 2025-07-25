using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._00X;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.Repository.GG._00X
{
    public class GG007RepositoryImpl(AppDbContext appDbContext) :
        RepositorioBaseComMudaAtivoImpl<CSICP_GG007>(appDbContext), IGG007Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_GG007> CreateAsync(CSICP_GG007 gg007)
        {
            //int novoCodigo = IncrementarCodigo
            //.IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG007>
            //(_appDbContext, gg007.Gg007Unidade, null, "Gg007Unidade", "Id");
            //gg007.Gg007Unidade = novoCodigo;
            _appDbContext.Add(gg007);
            await _appDbContext.SaveChangesAsync();
            return gg007;
        }
        public async Task<CSICP_GG007?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrE9aCsicpGg007s
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Include(e => e.NavGg007Filial)
                 .Include(e => e.NavGG007FraFormaVenda)
                 .Where(e => e.Id == id).FirstOrDefaultAsync();
        }
        public async Task<(IEnumerable<CSICP_GG007>, int)> GetListAsync
            (int tenant, int pageSize, int page, string? search, string? unidade, bool? isActive = true)
        {
            IQueryable<CSICP_GG007> query = _appDbContext.OsusrE9aCsicpGg007s
                .AsSplitQuery()
                 .Where(e => e.TenantId == tenant).AsNoTracking()
                 .Where(e => e.Gg007IsActive == isActive)
                 .Include(e => e.NavGg007Filial)
                 .Include(e => e.NavGG007FraFormaVenda)
                 .AsQueryable()
                 .OrderBy(e => e.Gg007Unidade);

            query = FiltraQuandoExisteFiltros(search, unidade, query);


            var queryCount = query;
            var count = queryCount.Count();

            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }
        public async Task<CSICP_GG007> UpdateAsync(CSICP_GG007 gg007)
        {
            //int novoCodigo = IncrementarCodigo
            //.IncrementaCodigoSeVazio_SeIgualAoExistente_OuRetornaOMesmo<CSICP_GG007>
            //(_appDbContext, gg007.Gg007Unidade, null, "Gg007Unidade", "Id");
            //gg007.Gg007Unidade = novoCodigo;
            _appDbContext.Add(gg007);
            await _appDbContext.SaveChangesAsync();
            return gg007;
        }

        private static IQueryable<CSICP_GG007> FiltraQuandoExisteFiltros
            (string? search, string? unidade, IQueryable<CSICP_GG007> query)
        {
            if (search != null)
            {
                query = query.Where(e => e.Gg007Descricao!.Contains(search));
            }
            if (unidade != null)
            {
                query = query.Where(e => e.Gg007Unidade!.Contains(unidade));
            }

            return query;
        }

    }
}
