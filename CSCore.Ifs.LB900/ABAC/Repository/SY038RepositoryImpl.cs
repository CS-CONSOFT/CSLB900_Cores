using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Repository
{
    public sealed class SY038RepositoryImpl : RepositoryBaseV2ComGets<CSSPH_POLICYS>
    {
        public SY038RepositoryImpl(AppDbContext appDbContext, string IdIdentifierName = "Id", string TenantIdentifierName = "TenantId") : base(appDbContext, IdIdentifierName, TenantIdentifierName)
        {
        }

        public override async Task<IEnumerable<CSSPH_POLICYS>> GetAllAsync(IEnumerable<FiltrosDinamicos> filtros)
        {
            var query = this._appDbContext.cssph_policies
                .AsNoTracking()
                .Include(e => e.NavAbacRules)
                .AsQueryable();

            query = AplicaFiltrosDinamicos(query, filtros);

            return await query.ToListAsync();
        }
    }
}
