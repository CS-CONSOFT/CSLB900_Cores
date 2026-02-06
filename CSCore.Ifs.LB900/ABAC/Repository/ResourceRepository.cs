using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools;
using CSLB900.MSTools.Extensao;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.Ifs.LB900.ABAC.Repository
{
    public sealed class ResourceRepository : RepositoryBaseV2ComGets<ABAC_CSSPH_RESOURCE>
    {
        public ResourceRepository(AppDbContext appDbContext, string IdIdentifierName = "Id", string TenantIdentifierName = "TenantId") : base(appDbContext, IdIdentifierName, TenantIdentifierName)
        {
        }
        public override async Task<(IEnumerable<ABAC_CSSPH_RESOURCE> Data, int TotalCount)> GetAllAsyncComPaginacao(
           IEnumerable<FiltrosDinamicos> filtros,
           int pageNumber,
           int pageSize)
        {
            var query = this._appDbContext.ABAC_CSSPH_RESOURCE
                .AsNoTracking()
                .Include(e => e.NavResourceActions)
                .AsQueryable();

            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();

            var data = await query
                .PaginacaoNoBanco(pageNumber, pageSize)
                .ToListAsync();

            return (data, totalCount);
        }

        public override async Task<ABAC_CSSPH_RESOURCE?> GetByIdAsync(string id, int tenant)
        {
            var query = this._appDbContext.ABAC_CSSPH_RESOURCE
                .Where(e => e.Id == id)
              .AsNoTracking()
              .Include(e => e.NavResourceActions)
              .AsQueryable();

            return await query.FirstOrDefaultAsync();

        }

    }
}
