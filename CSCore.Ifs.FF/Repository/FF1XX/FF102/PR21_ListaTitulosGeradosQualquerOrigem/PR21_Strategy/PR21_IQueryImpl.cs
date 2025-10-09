using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem.Strategy
{
    public abstract class PR21_IQueryImpl
    {
        public AppDbContext AppDbContext;

        protected PR21_IQueryImpl(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        // Template Method - define o algoritmo geral
        public async Task<(List<CSICP_FF102>, int)> Execute(int InTenant, int InPageNumber, int InPageSize)
        {
            var baseQuery = GetBaseQuery();
            var filteredQuery = ApplySpecificFilters(baseQuery, InTenant);
            var queryCount = filteredQuery;
            var count = await queryCount.CountAsync();
            var paginatedQuery = ApplyPagination(filteredQuery, InPageNumber, InPageSize);
            var list = await ExecuteQuery(paginatedQuery);
            return (list, count);
        }


        protected virtual IQueryable<CSICP_FF102> GetBaseQuery()
        {
            return AppDbContext.OsusrE9aCsicpFf102s
                .Include(e => e.NavFF102Sit)
                .Include(e => e.NavFF104)
                .Include(e => e.NavBB012);
        }

        protected abstract IQueryable<CSICP_FF102> ApplySpecificFilters(IQueryable<CSICP_FF102> query, int InTenant);

        private IQueryable<CSICP_FF102> ApplyPagination(IQueryable<CSICP_FF102> query, int pageNumber, int pageSize)
        {
            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }


        private async Task<List<CSICP_FF102>> ExecuteQuery(IQueryable<CSICP_FF102> query)
        {
            return await query.ToListAsync();
        }
    }
}