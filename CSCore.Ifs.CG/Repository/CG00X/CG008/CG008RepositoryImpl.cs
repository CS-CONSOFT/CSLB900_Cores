using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG008;
using CSCore.Domain.Interfaces.CG.CG00X.CG009;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.CG.Repository.CG00X.CG008.Filtros;
using CSCore.Ifs.CG.Repository.CG00X.CG009.Filtros;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.CG.Repository.CG00X.CG008
{
    public class CG008RepositoryImpl : RepositorioBaseImplV2<CSICP_CG008>, ICG008Repository
    {
        private readonly AppDbContext _appDbContext;

        public CG008RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Cg008Id")
        {
            _appDbContext = appDbContext;
        }

        public async Task<CSICP_CG008?> GetByIdAsync(int InTenant, string InIDCG008)
        {
            var query = _appDbContext.Osusr8dwCsicpCg008s
                .AsNoTracking()
                .Where(e => e.Cg008Id == InIDCG008 && e.TenantId == InTenant);
            
            return await query.FirstOrDefaultAsync();
        }

        public async Task<(List<CSICP_CG008>, int)> GetListAsync(int InTenant, PrmFiltrosCG008Repo InPrm)
        {
            IQueryable<CSICP_CG008> query = _appDbContext.Osusr8dwCsicpCg008s
                .AsNoTracking();

            // Aplica filtros
            query = AplicaFiltro(query, GetFiltrosParaAplicar(InTenant, InPrm));

            var queryCount = query;
            var count = await queryCount.CountAsync();
            
            query = query.OrderBy(e => e.Cg008Cod);
            query = query.PaginacaoNoBanco(InPrm.PageNumber, InPrm.PageSize);
            
            return (await query.ToListAsync(), count);
        }

        protected override ICSFilter<CSICP_CG008>[] GetOutrosFiltros<TFiltros>(int TenantId, TFiltros filtros)
        {
            var InPrm = filtros as PrmFiltrosCG008Repo ?? throw new ArgumentNullException(nameof(filtros));
            return
            [
                new FiltroDescricaoCG008(InPrm.Descricao),
            ];
        }
    }
}