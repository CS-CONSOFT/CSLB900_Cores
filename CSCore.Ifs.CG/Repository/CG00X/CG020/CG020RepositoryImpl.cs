using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG020;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG020.Filtros;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG020
{
    public class CG020RepositoryImpl : RepositorioBaseImpl<CSICP_CG020>, ICG020Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG020RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg020Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG020?> GetByIdAsync(int InTenant, string InIDCG020)
        {
            var query = _appDbContext.Osusr8dwCsicpCg020s
                .AsNoTracking()
                .Where(e => e.Cg020Id == InIDCG020 && e.TenantId == InTenant);
            
            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG020>, int)> GetListAsync(int InTenant, PrmFiltrosCG020Repo InPrm)
        {
            IQueryable<CSICP_CG020> query = _appDbContext.Osusr8dwCsicpCg020s
                .AsNoTracking();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenant, InPrm));

            var queryCount = query;
            var count = queryCount.Count();
            
            query = query.OrderByDescending(e => e.Cg020Ano)
                         .ThenByDescending(e => e.Cg020Mes)
                         .ThenByDescending(e => e.Cg020Lote);
            query.PaginacaoNoBanco(InPrm.PageNumber, InPrm.PageSize);
            
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG020>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros Filtros)
        {
            var filtros = Filtros as PrmFiltrosCG020Repo;
            if (filtros == null)
                throw new ArgumentNullException(nameof(Filtros), "Parâmetros de filtro inválidos.");

            return
            [
                new FiltroFilialIdCG020(filtros.FilialId),
                new FiltroLoteCG020(filtros.Lote),
                new FiltroAnoCG020(filtros.Ano),
                new FiltroMesCG020(filtros.Mes)
            ];
        }
    }
}