using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF018;

namespace CSCore.Ifs.FF.Repository
{
    public class FF999RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF999>(appDbContext, "Id"), IFF999Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<CSICP_FF999>, int)> GetListAsync(int in_tenant, string in_ff017Id, int in_page, int in_pageSize)
        {
            IQueryable<CSICP_FF999> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff017Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF999> FiltraQuandoExisteFiltro(string in_ff017Id, IQueryable<CSICP_FF999> query)
        {
            if (in_ff017Id != null)
                query = query.Where(e => e.Ff999IdControle!.Equals(in_ff017Id));
            return query;
        }

        private IQueryable<CSICP_FF999> GetQueryBase(int in_tenant)
        {
            return from ff999 in _appDbContext.OsusrE9aCsicpFf999s
                   .AsNoTracking()

                   where ff999.TenantId == in_tenant
                   select new CSICP_FF999
                   {
                       TenantId = ff999.TenantId,
                       Id = ff999.Id,
                       Ff999IdControle = ff999.Ff999IdControle,
                       Ff999Parcela = ff999.Ff999Parcela,
                       Ff999Datavencto = ff999.Ff999Datavencto,
                       Ff999Valorparcela = ff999.Ff999Valorparcela
                   };
        }
    }
}