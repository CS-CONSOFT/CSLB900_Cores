using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX.FF102.ListaTitulosGeradosQualquerOrigem.Strategy
{
    public class PR21_CC040QueryImpl : PR21_IQueryImpl
    {
        private string IDControle;
        public PR21_CC040QueryImpl(AppDbContext appDbContext, string InIDControle) : base(appDbContext)
        {
            this.IDControle = InIDControle;
        }

        protected override IQueryable<CSICP_FF102> ApplySpecificFilters(IQueryable<CSICP_FF102> query, int InTenant)
        {
            query = query.Where(e => e.NavFF104 != null && e.NavFF104.Cc040Id == this.IDControle)
                         .Where(e => e.Ff102Tiporegistro == 3);
            return query;
        }

    }
}
