using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.TotalizadorCobranca
{
    public class TotalizadorCobrancaRepositoryImpl : ITotalizadorCobrancaRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DtoTotalizadorCobranca _totalizadorCobranca;
        public TotalizadorCobrancaRepositoryImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _totalizadorCobranca = new DtoTotalizadorCobranca();
        }

        public async Task<DtoTotalizadorCobranca> GetTotalizadorCobrancaAsync(int in_tenantID, string in_contaID)
        {
            IQueryable<DtoTotalizadorCobranca> query = GetQueryBase(in_tenantID, in_contaID);

            return await query.FirstOrDefaultAsync();
        }

        private IQueryable<DtoTotalizadorCobranca> GetQueryBase(int in_tenantID, string in_contaID)
        {
            var query = from ff102 in _appDbContext.OsusrE9aCsicpFf102s
                   .AsNoTracking()
                        join bb012Conta in _appDbContext.OsusrE9aCsicpBb012s
                        on ff102.Ff102Contaid equals bb012Conta.Id
                        where ff102.TenantId == in_tenantID && ff102.Ff102Contaid == in_contaID
                        select new DtoTotalizadorCobranca
                        {
                            Vl_Liq_TituloSum = ff102.Ff102VlLiqTitulo,
                        };


                   return query;


        }


    }
}
