using CSCore.Domain.Interfaces.FF.RequisicaoDespesa.PR50_EncerrarRequisicaoDespesa;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.Util;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.FF.Repository.RequisicaoDespesa.PR50_EncerrarRequisicaoDespesa
{
    public class PR50_EncerrarRequisicaoDespesaImpl : IPR50_EncerrarRequisicaoDespesa
    {
        private readonly AppDbContext appDbContext;

        public PR50_EncerrarRequisicaoDespesaImpl(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<bool> EncerrarRD(int InTenantID, long In140_ID, int InNovoStatudID, int InSTIdFF140_Aprovado)
        {
            var WorkFF140 = await this.appDbContext.OsusrE9aCsicpFf140s.Where(e => e.TenantId == InTenantID)
                .Where(e => e.Ff140Id == In140_ID)
                .FirstOrDefaultAsync() ?? throw new KeyNotFoundException(HandlerReturnMessages.ENTITY_NOT_FOUND);

            WorkFF140.ValidaStatusDoMovimentoLancandoErroSeForDiferenteDoParametro(InSTIdFF140_Aprovado, "O Movimento não está APROVADO!");
            WorkFF140.ValidaRequisicaoMenorOuIgualAZeroLancandoErroSeFor("Não é possível solicitar movimento sem valor!");
            WorkFF140.AlterarStatusDoMovimento(InNovoStatudID);
            return true;
        }
    }
}
