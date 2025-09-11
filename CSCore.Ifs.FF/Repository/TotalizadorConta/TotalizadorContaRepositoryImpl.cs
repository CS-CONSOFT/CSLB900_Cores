using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CSCore.Ifs.FF.Repository.TotalizadorConta
{
    public class TotalizadorContaRepositoryImpl : ITotalizadorContaRepository
    {
        private readonly AppDbContext _appDbContext;
        public TotalizadorContaRepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<DtoTotalizadorConta> GetTotalizadorContaAsync(int in_tenantID, string in_contaID, 
            int in_StIDTpCobranca, int in_StIDFF102SitAberto, int in_StIDFF102SitBxParcial)
        {
            IQueryable<DtoTotalizadorConta> query = GetQueryBase(in_tenantID, in_contaID,
                in_StIDTpCobranca, in_StIDFF102SitAberto, in_StIDFF102SitBxParcial);

            return await query.FirstOrDefaultAsync();
        }

        private IQueryable<DtoTotalizadorConta> GetQueryBase(int in_tenantID, string in_contaID, 
            int in_StIDTpCobranca, int in_StIDFF102SitAberto, int in_StIDFF102SitBxParcial)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                        .AsNoTracking()

                        join bb012Conta in _appDbContext.OsusrE9aCsicpBb012s
                        on ff102.Ff102Contaid equals bb012Conta.Id

                        join ff102cob in _appDbContext.OsusrE9aCsicpFf102Cobs
                        on ff102.Ff102Tpcobranca equals ff102cob.Id

                        where ff102.TenantId == in_tenantID 
                        && ff102.Ff102Contaid == in_contaID 
                        && ff102.Ff102Tpcobranca == in_StIDTpCobranca
                        && (ff102.Ff102Situacaoid == in_StIDFF102SitAberto || ff102.Ff102Situacaoid == in_StIDFF102SitBxParcial)

                        group ff102 by new 
                        { 
                            ff102.TenantId,
                            ff102.Ff102Contaid,
                            ff102.Ff102Tpcobranca,
                            ff102.Ff102Situacaoid
                        } into grouped

                        select new DtoTotalizadorConta
                        {
                            Vl_Liq_TituloSum = grouped.Sum(e => e.Ff102VlLiqTitulo),
                            MaiorAtrasoMax = grouped.Max(e => EF.Functions.DateDiffDay(e.Ff102DataVencimento, DateTime.Now)),
                            Qtde_Atraso = grouped.Count()
                        };
             return query;


        }


    }
}
