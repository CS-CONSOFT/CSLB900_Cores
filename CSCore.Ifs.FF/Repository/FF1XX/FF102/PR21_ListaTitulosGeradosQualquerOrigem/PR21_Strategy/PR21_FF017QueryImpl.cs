using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102.PR21_ListaTitulosGeradosQualquerOrigem.PR21_Strategy
{
    internal class PR21_FF017QueryImpl : PR21_IQueryImpl
    {
        private string IDControle;
        public PR21_FF017QueryImpl(AppDbContext appDbContext, string InIDControle) : base(appDbContext)
        {
            this.IDControle = InIDControle;
        }


        protected override IQueryable<CSICP_FF102> ApplySpecificFilters(IQueryable<CSICP_FF102> query, int InTenant)
        {
            query = query.Where(e => e.NavFF104 != null && e.NavFF104.Ff104Renegociacaoid == this.IDControle);
            return query;
        }

    }
}
