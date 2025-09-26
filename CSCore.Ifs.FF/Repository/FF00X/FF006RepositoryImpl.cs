using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.CS_Models.Staticas.FF;
using CSCore.Domain.Interfaces.FF._00X;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.Repository;
using CSLB900.MSTools.Extensao;
using Microsoft.EntityFrameworkCore;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF006;

namespace CSCore.Ifs.FF.Repository.FF00X
{
    public class FF006RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF006>(appDbContext, "Ff006Id"), IFF006Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<CSICP_FF006?> GetByIdAsync(int tenant, long id)
        {
            IQueryable<CSICP_FF006> query = GetQueryBase(tenant);
            CSICP_FF006? cSICP_FF006 = await query.FirstOrDefaultAsync(e => e.Ff006Id == id);
            return cSICP_FF006;
        }

        public async Task<(List<CSICP_FF006>, int)> GetListAsync(int tenant, string ff102Id, int page, int pageSize)
        {
            IQueryable<CSICP_FF006> query = GetQueryBase(tenant);
            query = FiltraQuandoExisteFiltro(ff102Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(page, pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF006> FiltraQuandoExisteFiltro(string ff102Id, IQueryable<CSICP_FF006> query)
        {
            if (!string.IsNullOrEmpty(ff102Id))
                query = query.Where(e => e.Ff102Id!.Equals(ff102Id));
            return query;
        }

        private IQueryable<CSICP_FF006> GetQueryBase(int tenant)
        {
            return from ff006 in _appDbContext.OsusrE9aCsicpFf006s

                   join ff006sta in _appDbContext.OsusrE9aCsicpFf006Sta
                   on ff006.Ff006Statusid equals ff006sta.Id into ff006sta_join
                   from ff006sta in ff006sta_join.DefaultIfEmpty()

                   join sy001Solicitante in _appDbContext.OsusrE9aCsicpSy001s
                   on ff006.Ff006Usuariosolicid equals sy001Solicitante.Id into sy001Solicitante_join
                   from sy001Solicitante in sy001Solicitante_join.DefaultIfEmpty()

                   join sy001Resgatante in _appDbContext.OsusrE9aCsicpSy001s
                   on ff006.Ff006Usuarioresgid equals sy001Resgatante.Id into sy001Resgatante_join
                   from sy001Resgatante in sy001Resgatante_join.DefaultIfEmpty()

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

                       NavSy001Solicitante = sy001Solicitante != null ? new Csicp_Sy001
                       {
                           TenantId = sy001Solicitante.TenantId,
                           Id = sy001Solicitante.Id,
                           Sy001Nome = sy001Solicitante.Sy001Nome,
                           Sy001Email = sy001Solicitante.Sy001Email,
                       } : null,

                       NavSy001Resgate = sy001Resgatante != null ? new Csicp_Sy001
                       {
                           TenantId = sy001Resgatante.TenantId,
                           Id = sy001Resgatante.Id,
                           Sy001Nome = sy001Resgatante.Sy001Nome,
                           Sy001Email = sy001Resgatante.Sy001Email,
                       } : null,

                       NavFF006Sta = ff006sta != null ? new OsusrE9aCsicpFf006Stum
                       {
                           Id = ff006sta.Id,
                           Label = ff006sta.Label,
                           Order = ff006sta.Order,
                           IsActive = ff006sta.IsActive,
                           Codgcs = ff006sta.Codgcs,
                       } : null
                   };
        }

        
    }
}




