using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Ifs.CG.Repository.CG00X.PR139_137_FechamentoAnual.PR139_137_FechamentoAnualRepository;

namespace CSCore.Ifs.CG.Repository.CG00X.PR139_137_FechamentoAnual
{
    public interface IPR139_137_FechamentoAnualRepository
    {
        Task CS_GeraSaldoContaComTransferenciaDeSaldo(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            PR139137_PrmCS_GeraSaldoConta PrmInput,
            List<string> WorkListaContas_CG006_ID);
        Task<List<CSICP_CG009>> GetSaldoContaCG009AnoNovoMes0(
              int Tenant,
              List<string> WorkListaContasID,
              int InAnoNovo,
              int InMes,
              string TipoSaldo,
              string Filial
              );

        Task<List<string>> GetPlanoContas(int InTenant, string InFilial);
        


        Task<List<SaldoContaPorMesResult>> CS_SaldoAtual_Conta_Otimizado(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID);
    }

    
}
