using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.RequisicaoDespesa.PR_32_SoliticacaoRequisicaoDespesa
{
    public interface IPR_32_SoliticacaoRequisicaoDespesaRepository
    {
        Task<bool> SolicitarRD(int InTenantID, long In140_ID, int InNovoStatudID, int InSTIdFF140_Solicitado);
    }
}
