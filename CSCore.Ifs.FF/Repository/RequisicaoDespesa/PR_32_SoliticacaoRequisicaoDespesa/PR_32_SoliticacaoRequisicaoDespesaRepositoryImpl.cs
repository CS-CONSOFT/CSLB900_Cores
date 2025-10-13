using CSCore.Domain.Interfaces.FF.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
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

        public async Task<bool> SolicitarRD(int InTenantID, long In140_ID, int InSTIdFF140_Solicitado)
        {
            var WorkFF140 = await this.appDbContext.OsusrE9aCsicpFf140s.Where(e => e.TenantId == InTenantID)
                .Where(e => e.Ff140Id == In140_ID)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            WorkFF140.ValidaStatusDoMovimentoLancandoErroSeForIgualDoParametro(InSTIdFF140_Solicitado, "O Movimento já está SOLICITADO!");
            WorkFF140.ValidaRequisicaoMenorOuIgualAZeroLancandoErroSeFor("Não é possível solicitar movimento sem valor!");
            WorkFF140.AlterarStatusDoMovimento(InSTIdFF140_Solicitado);
            return true;
        }
    }
}
