using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.RequisicaoDespesa.PR50_EncerrarRequisicaoDespesa
{
    public interface IPR50_EncerrarRequisicaoDespesa
    {
        Task<bool> EncerrarRD(int InTenantID, long In140_ID, int InNovoStatudID, int InSTIdFF140_Aprovado);
    }
}
