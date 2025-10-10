using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.PR_32_SoliticacaoRequisicaoDespesa
{
    public interface IPR_32_SoliticacaoRequisicaoDespesaRepository
    {
        Task SolicitarRD(int InTenantID);
    }
}
