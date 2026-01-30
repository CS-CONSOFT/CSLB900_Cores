using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.Compartilhado;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Extensao;
using MathNet.Numerics.Statistics.Mcmc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.LB900.ABAC.Repository
{
    public sealed class SY031RepositoryImpl : RepositoryBaseV2ComGets<OsusrE9aCsicpSy031>
    {
        public SY031RepositoryImpl(AppDbContext appDbContext, string IdIdentifierName = "Id", string TenantIdentifierName = "TenantId") : base(appDbContext, IdIdentifierName, TenantIdentifierName)
        {
        }

        public override async Task<(IEnumerable<OsusrE9aCsicpSy031> Data, int TotalCount)> GetAllAsyncComPaginacao(
           IEnumerable<FiltrosDinamicos> filtros,
           int pageNumber,
           int pageSize)
        {
            var query = this._appDbContext.OsusrE9aCsicpSy031s
                .Include(e => e.NavGrupo_SY030)
                .Include(e => e.NavUsuario_SY001)
                .AsNoTracking().AsQueryable();
            query = AplicaFiltrosDinamicos(query, filtros);

            var totalCount = await query.CountAsync();

            var data = await query
                .PaginacaoNoBanco(pageNumber, pageSize)
                .ToListAsync();

            return (data, totalCount);
        }
    }
}
