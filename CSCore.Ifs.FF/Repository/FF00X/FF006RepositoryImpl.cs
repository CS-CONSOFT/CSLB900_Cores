using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._00X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.FF00X
{
    public class FF006RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF006>(appDbContext, "Ff006Id"), IFF006Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF006?> GetByIdAsync(int tenant, string id)
        {
            IQueryable<CSICP_FF006> query = GetQueryBase(tenant);
            CSICP_FF006? cSICP_FF006 = await query.FirstOrDefaultAsync(e => e.Ff006Id == long.Parse(id));
            return cSICP_FF006;
        }

        public async Task<(List<CSICP_FF006>, int)> GetListAsync(int tenant, string? ff102Id, int page, int pageSize)
        {
            IQueryable<CSICP_FF006> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(ff102Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF006> FiltraQuandoExisteFiltro(string? ff102Id, IQueryable<CSICP_FF006> query)
        {
            if (ff102Id != null)
                query = query.Where(e => e.Ff102Id!.Equals(ff102Id));
            return query;
        }

        private IQueryable<CSICP_FF006> GetQueryBase(int tenant)
        {
            return from ff006 in _appDbContext.OsusrE9aCsicpFf006s
                   where ff006.TenantId == tenant

                   select new CSICP_FF006
                   {
                       TenantId = ff006.TenantId,
                       Ff006Id = ff006.Ff006Id,
                       Ff102Id = ff006.Ff102Id,
                       Ff006Vdescjuros = ff006.Ff006Vdescjuros,
                       Ff006Pdescjuros = ff006.Ff006Pdescjuros,
                       Ff006Dsolicitacao = ff006.Ff006Dsolicitacao,
                       Ff006Usuariosolicid = ff006.Ff006Usuariosolicid,
                       Ff006Dresgate = ff006.Ff006Dresgate,
                       Ff006Usuarioresgid = ff006.Ff006Usuarioresgid,
                       Ff006Chaveautoriz = ff006.Ff006Chaveautoriz,
                       Ff006Vabertotit = ff006.Ff006Vabertotit,
                       Ff006Vjurostit = ff006.Ff006Vjurostit,
                       Ff006Datrasotit = ff006.Ff006Datrasotit,
                       Ff006Statusid = ff006.Ff006Statusid,
                       Ff006Chave = ff006.Ff006Chave,
                       Ff006Tabela = ff006.Ff006Tabela,
                   };
        }

        
    }
}




