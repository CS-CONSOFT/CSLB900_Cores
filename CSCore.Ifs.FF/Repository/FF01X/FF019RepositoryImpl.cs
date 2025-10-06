using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._01X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF01X
{
    public class FF019RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF019>(appDbContext, "Ff019Id"), IFF019Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_FF019?> GetByIdAsync(int in_tenant, string in_ff019Id)
        {
            IQueryable<CSICP_FF019> query = GetQueryBase(in_tenant);
            CSICP_FF019? cSICP_FF019 = await query.FirstOrDefaultAsync(e => e.Ff019Id == long.Parse(in_ff019Id));
            return cSICP_FF019;
        }

        public async Task<(List<CSICP_FF019>, int)> GetListAsync(int in_tenant, string? in_estabId, int in_pageNumber, int in_pageSize)
        {
            IQueryable<CSICP_FF019> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_estabId, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_FF019> FiltraQuandoExisteFiltro(string? in_estabId, IQueryable<CSICP_FF019> query)
        {
            if (in_estabId != null)
                query = query.Where(e => e.Ff000Id!.Equals(in_estabId));
            return query;
        }

        private IQueryable<CSICP_FF019> GetQueryBase(int in_tenant)
        {
            return _appDbContext.OsusrE9aCsicpFf019s
                .Include(e => e.NavFormaPgto)
                .Include(e => e.NavCondicaoPgto)
                .AsNoTracking()
                .Where(e => e.TenantId == in_tenant);
        }
    }
}
