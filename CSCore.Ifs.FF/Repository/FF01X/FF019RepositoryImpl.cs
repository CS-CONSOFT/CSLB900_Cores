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
        public async Task<CSICP_FF019?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_FF019> query = GetQueryBase(tenant);
            CSICP_FF019? cSICP_FF019 = await query.FirstOrDefaultAsync(e => e.Ff019Id == long.Parse(id));
            return cSICP_FF019;
        }

        public async Task<(List<CSICP_FF019>, int)> GetListAsync(int tenant, string? estabelecimentoId, int page, int pageSize)
        {
            IQueryable<CSICP_FF019> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(estabelecimentoId, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private static IQueryable<CSICP_FF019> FiltraQuandoExisteFiltro(string? estabelecimentoId, IQueryable<CSICP_FF019> query)
        {
            if (estabelecimentoId != null)
                query = query.Where(e => e.Ff000Id!.Equals(estabelecimentoId));
            return query;
        }

        private IQueryable<CSICP_FF019> GetQueryBase(int tenant)
        {
            return from ff019 in _appDbContext.OsusrE9aCsicpFf019s
                   where ff019.TenantId == tenant

                   select new CSICP_FF019
                   {
                       TenantId = ff019.TenantId,
                       Ff019Id = ff019.Ff019Id,
                       Ff000Id = ff019.Ff000Id,
                       Ff019FpagtoId = ff019.Ff019FpagtoId,
                       Ff019Condicaoid = ff019.Ff019Condicaoid,
                   };
        }
    }
}
