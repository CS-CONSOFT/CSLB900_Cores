using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.PR139_137_FechamentoAnual
{
    public record PR139137_PrmCS_GetListaContasInput(
        int InAnoFechamento,
        int InMesFechamento,
        string InTipoSaldoID,
        string InFilialID)
    {
    };

    public record PR139137_PrmCS_GeraSaldoConta(
        int InAnoFechamento,
        int InMesFechamento,
        string InTipoSaldoID,
        string InFilialID,
        ICS_GenerateId CS_GenerateId
    ) : PR139137_PrmCS_GetListaContasInput(InAnoFechamento, InMesFechamento, InTipoSaldoID, InFilialID);

    public record PR139137_PrmCS_TransSaldoCnt(string InFilialID, int InAno, int InMes,string InCG008_ID_TipoSaldo);

    public interface IPR139_137_FechamentoAnualRepository
    {

    }
    public class PR139_137_FechamentoAnualRepository : IPR139_137_FechamentoAnualRepository
    {
        private readonly AppDbContext appDbContext;

        public PR139_137_FechamentoAnualRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<string>> CS_GetListaContas(int Tenant, PR139137_PrmCS_GetListaContasInput InPrmGeraSaldoProx)
        {
            var WorkListaCG009 = await this.appDbContext.Osusr8dwCsicpCg009s
                .Where(e => e.Cg009FilialId == InPrmGeraSaldoProx.InFilialID)
                .Where(e => e.Cg009TipoSaldoId == InPrmGeraSaldoProx.InTipoSaldoID)
                .Where(e => e.Cg009Ano == InPrmGeraSaldoProx.InAnoFechamento)
                .Where(e => e.Cg009Mes == InPrmGeraSaldoProx.InMesFechamento)
                .Where(e => this.appDbContext.Osusr8dwCsicpCg006s
                    .Where(cg => cg.TenantId == Tenant)
                    .Where(cg => cg.Cg006FilialId == InPrmGeraSaldoProx.InFilialID)
                    .Select(cg => cg.Cg006Id)
                    .Contains(e.Cg009ContaId))
                .Select(e => e.Cg009ContaId)
                .Distinct()
                .ToListAsync();
            return WorkListaCG009;
        }

        public async Task<List<string>> GetContasID(int InTenant, string InFilial)
        {
            return await this.appDbContext.Osusr8dwCsicpCg006s.Where(e => e.TenantId == InTenant)
                .Where(e => e.Cg006FilialId == InFilial).Select(e => e.Cg006Id).ToListAsync();
        }


        /// <summary>
        /// Gera saldo (cg009) zerados para os meses 1 ao 12 quando uma conta é criada.
        /// </summary>
        /// <param name="Tenant"></param>
        /// <param name="InPrmGeraSaldoProx"></param>
        /// <returns></returns>
        private async Task CS_GeraSaldoConta(int Tenant, PR139137_PrmCS_GeraSaldoConta PrmInput, List<string> WorkListaContasID)
        {
          
            var MesAux = PrmInput.InMesFechamento;
            var WorkListaGG009ToCreate = new List<CSICP_CG009>();
            foreach (var current in WorkListaContasID)
            {
                if (current == null)
                {
                    MesAux += 1;
                    continue;
                }

                if (MesAux > 12) break;

                var WorkGG009ToCreate
                    = CSICP_CG009.CreateInstanceComValoresDebitoCreditoESaldoZerados(
                        tenant: Tenant,
                        ICS_GenerateId: PrmInput.CS_GenerateId,
                        cg009FilialId: PrmInput.InFilialID,
                        cg009TipoSaldoId: PrmInput.InTipoSaldoID,
                        cg009ContaId: current,
                        cg009Ano: PrmInput.InAnoFechamento,
                        cg009Mes: MesAux);

                WorkListaGG009ToCreate.Add(WorkGG009ToCreate);
                MesAux += 1;
            }
            this.appDbContext.Osusr8dwCsicpCg009s.AddRange(WorkListaGG009ToCreate);
        }

        //parei aqui CS_SaldoAtual_Conta, que vem daqui CS_TransSaldoCnt

        public async Task CS_SaldoAnt_Conta(int Tenant, PR139137_PrmCS_TransSaldoCnt prm)
        {
            var contasID = await GetContasID(Tenant, prm.InFilialID);
            var query = from csicp_cg009 in this.appDbContext.Osusr8dwCsicpCg009s.AsNoTracking()
                        where csicp_cg009.TenantId == Tenant
                        && csicp_cg009.Cg009FilialId == prm.InFilialID
                        && csicp_cg009.Cg009TipoSaldoId == prm.InCG008_ID_TipoSaldo
                        && csicp_cg009.Cg009Ano == prm.InAno
                        && csicp_cg009.Cg009Mes < prm.InMes
                        && contasID.Contains(csicp_cg009.Cg009ContaId)
                        select csicp_cg009;

            var resultado = await query
                .Take(13)
                .Select(cg009 => new
                {
                    Saldo = cg009.Cg009Mes == 0 ? (cg009.Cg009Saldo ?? 0) : 0,
                    Credito = cg009.Cg009Mes != 0 ? (cg009.Cg009Totalcredito ?? 0) : 0,
                    Debito = cg009.Cg009Mes != 0 ? (cg009.Cg009Totaldebito ?? 0) : 0
                })
                .ToListAsync();

            var v_Saldo = resultado.Sum(x => x.Saldo);
            var v_Soma_Credito = resultado.Sum(x => x.Credito);
            var v_Soma_Debito = resultado.Sum(x => x.Debito);

        }
    }
}
