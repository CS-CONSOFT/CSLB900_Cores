using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG006;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG006.Filtros;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG006
{
    public class CG006RepositoryImpl : RepositorioBaseImpl<CSICP_CG006>, ICG006Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG006RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg006Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG006?> GetByIdAsync(int InTenantID, string InCG006ID)
        {
            var query = _appDbContext.Osusr8dwCsicpCg006s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG006)
                .Include(e => e.NavCG003GpContabil_CG006)
                .Include(e => e.NavCG004AmarracaoNivel2_CG006)
                .Include(e => e.NavCG004AmarracaoNivel3_CG006)
                .Include(e => e.NavCG004AmarracaoNivel4_CG006)
                .Include(e => e.NavCG005HistPadrao_CG006)
                .Include(e => e.NavCG006PlanoContas_ContaSuperior)
                .Include(e => e.NavCG996TpConta_CG006)
                .Include(e => e.NavCG997ClassConta_CG006)
                .Include(e => e.NavCG999TpAmarracao_CG006)
                .Include(e => e.NavStatica_CG006_LancNivel2)
                .Include(e => e.NavStatica_CG006_LancNivel3)
                .Include(e => e.NavStatica_CG006_LancNivel4)
                .Include(e => e.NavStatica_CG006_ConsolidaLanc)
                .Where(e => e.Cg006Id == InCG006ID && e.TenantId == InTenantID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG006>, int)> GetListAsync(int InTenantID, PrmFiltrosCG006Repo prm)
        {
            IQueryable<CSICP_CG006> query = _appDbContext.Osusr8dwCsicpCg006s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG006)
                .Include(e => e.NavCG003GpContabil_CG006)
                .Include(e => e.NavCG004AmarracaoNivel2_CG006)
                .Include(e => e.NavCG004AmarracaoNivel3_CG006)
                .Include(e => e.NavCG004AmarracaoNivel4_CG006)
                .Include(e => e.NavCG005HistPadrao_CG006)
                .Include(e => e.NavCG006PlanoContas_ContaSuperior)
                .Include(e => e.NavCG996TpConta_CG006)
                .Include(e => e.NavCG997ClassConta_CG006)
                .Include(e => e.NavCG999TpAmarracao_CG006)
                .Include(e => e.NavStatica_CG006_LancNivel2)
                .Include(e => e.NavStatica_CG006_LancNivel3)
                .Include(e => e.NavStatica_CG006_LancNivel4)
                .Include(e => e.NavStatica_CG006_ConsolidaLanc);

            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));

            var count = await query.CountAsync();
            query = query.OrderBy(e => e.Cg006Codigoplano);
            query = query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);

            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG006>[] GetOutrosFiltros<TFiltros>(int InTenantID, TFiltros filtros)
        {
            var prm = filtros as PrmFiltrosCG006Repo ?? throw new ArgumentNullException(nameof(filtros));
            return
            [
                new FiltroEstabIDCG006(prm.EstabID),
                new FiltroDescricaoCG006(prm.Descricao),
                
            ];
        }
    }
}