using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.PR139_137_FechamentoAnual
{
    public interface IPR139_137_FechamentoAnualRepository
    {
        Task CS_GeraSaldoContaComTransferenciaDeSALDO(int Tenant, PR139137_PrmCS_TransSaldoCnt prm, PR139137_PrmCS_GeraSaldoConta PrmInput, List<string> WorkListaContasID);
        Task<IEnumerable<CSICP_CG009>> GetSaldoContaCG009AnoNovoMes0(
            int Tenant,
            IEnumerable<string> ContasID,
            int InAnoNovo,
            int InMes,
            string TipoSaldo,
            string Filial
            );

        Task<List<string>> GetPlanoContas(int InTenant, string InFilial);

        Task CS_TransSaldoCnt(int Tenant,
             PR139137_PrmCS_TransSaldoCnt prm,
             List<SaldoContaResultV2> CS_SaldoAtual_Conta);

        Task<List<SaldoContaResult>> CS_SaldoAtual_Conta(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID);

        Task<List<SaldoContaResultV2>> CS_SaldoAtual_Conta_Otimizado(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID);

        Task<List<SaldoContaResult>> CS_SaldoAnt_Conta(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID);
    }

    
}
