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
    public class FF115RepositoryImpl(AppDbContext appDbContext)
        : RepositorioBaseImpl<CSICP_FF115>(appDbContext, "Id"), IFF115Repository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<(List<CSICP_FF115>, int)> GetListAsync(int in_tenant, string in_ff113Id, int in_pageNumber, int in_pageSize)
        {
            IQueryable<CSICP_FF115> query = GetQueryBase(in_tenant);
            query = FiltraQuandoExisteFiltro(in_ff113Id, query);
            var queryCount = query;
            var count = queryCount.Count();
            query = query.PaginacaoNoBanco(in_pageNumber, in_pageSize);
            return (await query.ToListAsync(), count);
        }
        private IQueryable<CSICP_FF115> FiltraQuandoExisteFiltro(string in_ff113Id, IQueryable<CSICP_FF115> query)
        {
            if (in_ff113Id != null)
                query = query.Where(e => e.Ff113Controleid!.Equals(in_ff113Id));
            return query;
        }
        private IQueryable<CSICP_FF115> GetQueryBase(int in_tenant)
        {
            return from ff115 in _appDbContext.OsusrE9aCsicpFf115s
                   .AsNoTracking()
                   where ff115.TenantId == in_tenant
                   select new CSICP_FF115
                   {
                       TenantId = ff115.TenantId,
                       Id = ff115.Id,
                       Ff115Filialid = ff115.Ff115Filialid,
                       Ff113Controleid = ff115.Ff113Controleid,
                       Ff115Codgfilial = ff115.Ff115Codgfilial,
                       Ff115Pfx = ff115.Ff115Pfx,
                       Ff115Titulo = ff115.Ff115Titulo,
                       Ff115Sfx = ff115.Ff115Sfx,
                       Ff115Conta = ff115.Ff115Conta,
                       Ff115Nossonumero = ff115.Ff115Nossonumero,
                       Ff115Codgmovtoretorno = ff115.Ff115Codgmovtoretorno,
                       Ff115Datavencimento = ff115.Ff115Datavencimento,
                       Ff115Valornominaltitulo = ff115.Ff115Valornominaltitulo,
                       Ff115Jurosmultaencargos = ff115.Ff115Jurosmultaencargos,
                       Ff115Vlrdescontoconcedido = ff115.Ff115Vlrdescontoconcedido,
                       Ff115Abatimentocancelamento = ff115.Ff115Abatimentocancelamento,
                       Ff115Valorpago = ff115.Ff115Valorpago,
                       Ff115Valorliquido = ff115.Ff115Valorliquido,
                       Ff115Datacredito = ff115.Ff115Datacredito,
                       Ff102TituloId = ff115.Ff102TituloId,
                       Ff115IsincluirBaixa = ff115.Ff115IsincluirBaixa,
                       Ff115Codgmovc044 = ff115.Ff115Codgmovc044,
                       Ff115Desccodgmovimento = ff115.Ff115Desccodgmovimento,
                       Ff115Codgocorrcc047 = ff115.Ff115Codgocorrcc047,
                       Ff115Desccodgocorrcc047 = ff115.Ff115Desccodgocorrcc047

                   };
        }
    }
}
