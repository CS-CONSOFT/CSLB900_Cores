using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG009;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG009.Filtros;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using CSLB900.MSTools.InterfaceBase;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG009
{
    public class CG009RepositoryImpl : RepositorioBaseImpl<CSICP_CG009>, ICG009Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG009RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg009Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG009?> GetByIdAsync(int InTenantID, string InCG009ID)
        {
            var query = _appDbContext.Osusr8dwCsicpCg009s
                .AsNoTracking()
                .Where(e => e.Cg009Id == InCG009ID && e.TenantId == InTenantID);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG009>, int)> GetListAsync(int InTenantID, PrmFiltrosCG009Repo prm)
        {
            IQueryable<CSICP_CG009> query = _appDbContext.Osusr8dwCsicpCg009s
                .AsNoTracking()
                .Include(e => e.NavBB001Estab_CG009)
                .Include(e => e.NavCG006Conta_CG009)
                .Include(e => e.NavCG008TipoSaldo_CG009);

            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenantID, prm));

            var count = query.Count();
            query = query.OrderByDescending(e => e.Cg009Ano)
                         .ThenByDescending(e => e.Cg009Mes);
            query.PaginacaoNoBanco(prm.PageNumber, prm.PageSize);

            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG009>[] GetOutrosFiltros<TFiltros>(int InTenantID, TFiltros filtros)
        {
            var prm = filtros as PrmFiltrosCG009Repo ?? throw new ArgumentNullException(nameof(filtros));
            return
            [
                new FiltroEstabIDCG009(prm.EstabID),
                new FiltroContaIdCG009(prm.ContaId),
                new FiltroAnoCG009(prm.Ano),
                new FiltroMesCG009(prm.Mes)
            ];
        }
    }
}