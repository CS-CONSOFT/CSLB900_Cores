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
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF112;

namespace CSCore.Ifs.FF.Repository.FF1XX
{
    public class FF112FaixaRepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF112Faixa>(appDbContext, "Ff112FaixaId"), IFF112FaixaRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<CSICP_FF112Faixa?> GetByIdAsync(int in_tenant, string id)
        {
            IQueryable<CSICP_FF112Faixa> query = GetQueryBase(in_tenant);
            CSICP_FF112Faixa? cSICP_FF112 = await query.FirstOrDefaultAsync(e => e.Ff112FaixaId == id);
            return cSICP_FF112;
        }
        private IQueryable<CSICP_FF112Faixa> GetQueryBase(int in_tenant)
        {
            return from ff112Faixa in _appDbContext.OsusrE9aCsicpFf112Faixas
                   .AsNoTracking()
                   where ff112Faixa.TenantId == in_tenant

                   select new CSICP_FF112Faixa
                   {
                       TenantId = ff112Faixa.TenantId,
                       Ff112FaixaId = ff112Faixa.Ff112FaixaId,
                       Ff112Id = ff112Faixa.Ff112Id,
                       Ff112NossonroInicial = ff112Faixa.Ff112NossonroInicial,
                       Ff112NossonroFinal = ff112Faixa.Ff112NossonroFinal,
                       Ff112NossonroAtual = ff112Faixa.Ff112NossonroAtual,
                       Ff112Avisonossonro = ff112Faixa.Ff112Avisonossonro,
                       Ff112Isactive = ff112Faixa.Ff112Isactive
                   };
        }

        public async Task<(List<CSICP_FF112Faixa>, int)> GetListAsync(
            int in_tenant, int in_page, int in_pageSize, string in_ff112Id)
        {
            IQueryable<CSICP_FF112Faixa> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff112Id, query);

            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_page, in_pageSize);

            return (await query.ToListAsync(), count);
        }

        private IQueryable<CSICP_FF112Faixa> FiltraQuandoExisteFiltro(string in_ff112Id, IQueryable<CSICP_FF112Faixa> query)
        {
            if (in_ff112Id != null)
            {
                query = query.Where(e => e.Ff112Id == in_ff112Id);
            }

            return query;
        }
    }
}
