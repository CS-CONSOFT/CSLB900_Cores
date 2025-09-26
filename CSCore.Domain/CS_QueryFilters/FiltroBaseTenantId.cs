using CSCore.Domain.Interfaces.V2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.CS_QueryFilters
{
    public class FiltroBaseTenantId<TEntity> : ICSFilter<TEntity>
    {
        private readonly int _tenantId;

        public FiltroBaseTenantId(int tenantId)
        {
            _tenantId = tenantId;
        }

        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
        {
            query = query.Where(e => EF.Property<int>(e, "TenantId") == _tenantId);
            return query;
        }
    }
}
