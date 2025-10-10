using CSCore.Domain.Interfaces.FF.PR_32_SoliticacaoRequisicaoDespesa;
using CSCore.Ifs.CS_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa
{
    public class PR_32_SoliticacaoRequisicaoDespesaRepositoryImpl : IPR_32_SoliticacaoRequisicaoDespesaRepository
    {
        private readonly AppDbContext appDbContext;

        public PR_32_SoliticacaoRequisicaoDespesaRepositoryImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task SolicitarRD(int InTenantID)
        {
            var a = await this.appDbContext.OsusrE9aCsicpFf140s.Where(e => e.TenantId == 135)
                .Where(e => e.Ff140Statusid == 1).FirstOrDefaultAsync();
        }
    }
}
