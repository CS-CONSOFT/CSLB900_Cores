using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.DD;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.DD.Repository.DD
{
    public class DD811RepositoryImpl : RepositoryBaseV2ComGets<CSICP_DD811>, IDD811Repository
    {
        private readonly AppDbContext _appDbContext;
        public DD811RepositoryImpl(AppDbContext appDbContext) : base (appDbContext, "Dd811Id", "TenantId")
        {
            _appDbContext = appDbContext;
        }

        public override async Task<(IEnumerable<CSICP_DD811> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize)
        {
            // Query inicial com includes
            var query = _appDbContext.OsusrTeiCsicpDd811s
                .AsNoTracking()
                .Include(e => e.NavSpedInCFOP_DD811)
                .Include(e => e.NavAA032Csticm_DD811)
                .Include(e => e.NavAA033Cstpis_DD811)
                .Include(e => e.NavAA034Cstcofins_DD811)
                .Include(e => e.NavAA035Cstipi_DD811)
                .AsQueryable();

            // Aplica filtros dinâmicos usando o método da classe base
            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();
            var data = await query.PaginacaoNoBanco(pageNumber, pageSize).ToListAsync();

            return (data, totalCount);
        }

        public override async Task<CSICP_DD811?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrTeiCsicpDd811s
                .AsNoTracking()
                .Include(e => e.NavSpedInCFOP_DD811)
                .Include(e => e.NavAA032Csticm_DD811)
                .Include(e => e.NavAA033Cstpis_DD811)
                .Include(e => e.NavAA034Cstcofins_DD811)
                .Include(e => e.NavAA035Cstipi_DD811)
                .Where(e => e.TenantId == tenant && e.Dd811Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
