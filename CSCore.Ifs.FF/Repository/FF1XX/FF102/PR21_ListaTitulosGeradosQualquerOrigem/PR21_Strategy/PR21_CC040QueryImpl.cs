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

        public override async Task<List<CSICP_FF102>> Execute(int InTenant)
        {
            var query = GetQuery<CSICP_FF102>();
            if (query == null)
                return [];
            query = query.Where(e => e.TenantId == InTenant);
            return await query.ToListAsync();
        }

        protected override IQueryable<T>? GetQuery<T>()
        {
            var query = base.GetQuery<CSICP_FF102>();
            query = query?.Where(e => e.NavFF104 != null && e.NavFF104.Cc040Id == this.IDControle)
                         .Where(e => e.Ff102Tiporegistro == 3);
            return query as IQueryable<T>;
        }
    }
}
