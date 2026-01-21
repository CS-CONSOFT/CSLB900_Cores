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
    public class DD009RepositoryImpl : RepositoryBaseV2ComGets<CSICP_DD009>, IDD009Repository
    {
        private readonly AppDbContext _appDbContext;
        
        public DD009RepositoryImpl(AppDbContext appDbContext) : base(appDbContext, "Dd009Id", "TenantId")
        {
            _appDbContext = appDbContext;
        }

        public override async Task<(IEnumerable<CSICP_DD009> Data, int TotalCount)> GetAllAsyncComPaginacao(
            IEnumerable<FiltrosDinamicos> filtros,
            int pageNumber,
            int pageSize)
        {
            // Query inicial com includes
            var query = _appDbContext.OsusrTeiCsicpDd009s
                .AsNoTracking()
                .Include(e => e.NavBB001EmpresaID_DD009)
                .Include(e => e.NavBB029CategoriaID_DD009)
                .Include(e => e.NavBB026FormaPagtoID_DD009)
                .AsQueryable();

            // Aplica filtros dinâmicos usando o método da classe base
            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();
            var data = await query.PaginacaoNoBanco(pageNumber, pageSize).ToListAsync();

            return (data, totalCount);
        }

        public override async Task<CSICP_DD009?> GetByIdAsync(string id, int tenant)
        {
            return await _appDbContext.OsusrTeiCsicpDd009s
                .AsNoTracking()
                .Include(e => e.NavBB001EmpresaID_DD009)
                .Include(e => e.NavBB029CategoriaID_DD009)
                .Include(e => e.NavBB026FormaPagtoID_DD009)
                .Where(e => e.TenantId == tenant && e.Dd009Id == id)
                .FirstOrDefaultAsync();
        }
    }
}