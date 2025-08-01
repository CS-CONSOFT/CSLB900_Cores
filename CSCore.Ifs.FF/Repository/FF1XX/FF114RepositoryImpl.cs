using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._1XX;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF114RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF114>(appDbContext, "Id"), IFF114Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<(List<CSICP_FF114>, int)> GetListAsync(int in_tenant, string in_ff113Id, int in_page, int in_pageSize)
        {
            IQueryable<CSICP_FF114> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff113Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        
        }

        private IQueryable<CSICP_FF114> FiltraQuandoExisteFiltro(string in_ff113Id, IQueryable<CSICP_FF114> query)
        {
            if (in_ff113Id != null)
                query = query.Where(e => e.Ff114Idcontrole!.Equals(in_ff113Id));
            return query;
        }

        private IQueryable<CSICP_FF114> GetQueryBase(int in_tenant)
        {
            return from ff114 in _appDbContext.OsusrE9aCsicpFf114s
                   .AsNoTracking()

                   where ff114.TenantId == in_tenant
                   select new CSICP_FF114
                   {
                       TenantId = ff114.TenantId,
                       Id = ff114.Id,
                       Ff114Refconfigbanco = ff114.Ff114Refconfigbanco,
                       Ff114Lote = ff114.Ff114Lote,
                       Ff114Ordem = ff114.Ff114Ordem,
                       Ff114Linha240 = ff114.Ff114Linha240,
                       Ff114Linha400 = ff114.Ff114Linha400,
                       Ff114Idcontrole = ff114.Ff114Idcontrole
                   };
        }
    }
}