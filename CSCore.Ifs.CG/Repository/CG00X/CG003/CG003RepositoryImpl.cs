using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG003;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG003.Filtros;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CSCore.Ifs.CG.Repository.CG00X.CG003
{
    public class CG003RepositoryImpl : RepositorioBaseImpl<CSICP_CG003>, ICG003Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG003RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg003Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG003?> GetByIdAsync(int InTenantID, string InCG003ID)
        {
            var query = _appDbContext.Osusr8dwCsicpCg003s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG003)
                .Include(e => e.NavCG999Natureza_CG003)
                .Where(e => e.Cg003Id == InCG003ID && e.TenantId == InTenantID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG003>, int)> GetListAsync(int InTenantID, PrmFiltrosCG003Repo prm)
        {
            IQueryable<CSICP_CG003> query = _appDbContext.Osusr8dwCsicpCg003s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG003)
                .Include(e => e.NavCG999Natureza_CG003);

            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));

            var count = query.Count();
            query = query.OrderBy(e => e.Cg003Id);
            query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);

            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG003>[] GetOutrosFiltros<TFiltros>(int InTenantID, TFiltros filtros)
        {
            var prm = filtros as PrmFiltrosCG003Repo ?? throw new ArgumentNullException(nameof(filtros));
            return
            [
                new FiltroEstabIDCG003(prm.EstabID),
                new FiltroDescricaoCG003(prm.Descricao)
            ];
            
        }
    }
}