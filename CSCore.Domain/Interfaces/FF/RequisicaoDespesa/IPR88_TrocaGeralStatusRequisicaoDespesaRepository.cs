using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF.RequisicaoDespesa
{
    public interface IPR88_TrocaGeralStatusRequisicaoDespesaRepository
    {
        Task<CSICP_FF140> TrocaGeralStatusRD(int InTenantID, long In140_ID, int InNovoStatudID);
        bool AssinaExecucaoTrocaStatus(int InNovoStatudExecucaoID, CSICP_FF140 InFF140);
    }
}
