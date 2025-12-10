using Azure.Messaging;
using CSCore.Domain;
using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSLB900.MSTools.GenerateId;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.PR139_137_FechamentoAnual
{
    public sealed class PR139_137_FechamentoAnualRepository : IPR139_137_FechamentoAnualRepository
    {
        private readonly AppDbContext appDbContext;

        private record DadosCG009(
                string Cg009ContaId,
                int? Cg009Mes,
                decimal? Cg009Saldo,
                decimal? Cg009Totaldebito,
                decimal? Cg009Totalcredito,
                string? CodigoConta,
                string? NomeConta
            );

        public record SaldoContaPorMesResult(
        string ContaId,
        int Mes,
        decimal SaldoAnterior,
        decimal TotalDebito,
        decimal TotalCredito,
        decimal SaldoAtual,
        string? CodigoConta,
        string? NomeConta
    );

        private record SaldoContaAgrupado(
            string ContaId,
            decimal? SaldoInicial,
            decimal? SaldoAnteriorPeriodo,
            IEnumerable<SaldoContaResultListMesValores> MesValores,
            string? CodigoConta,
            string? NomeConta
        )
        {
            public decimal? SaldoAtual = SaldoAnteriorPeriodo + MesValores.Select(e => e.TotalDebito - e.TotalCredito).Sum();
        };

        public PR139_137_FechamentoAnualRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<CSICP_CG009>> GetSaldoContaCG009AnoNovoMes0(
            int Tenant,
            List<string> WorkListaContasID,
            int InAnoNovo,
            int InMes,
            string TipoSaldo,
            string Filial
            )
        {
            var WorkListaCG009 = await this.appDbContext.Osusr8dwCsicpCg009s
                .Where(e => e.TenantId == Tenant)
                .Where(e => e.Cg009FilialId == Filial)
                .Where(e => e.Cg009TipoSaldoId == TipoSaldo)
                .Where(e => e.Cg009Ano == InAnoNovo)
                .Where(e => e.Cg009Mes == InMes)
                .Where(e => WorkListaContasID.Contains(e.Cg009ContaId))
                .ToListAsync();
            return WorkListaCG009;
        }

        public async Task<List<string>> GetPlanoContas(int InTenant, string InFilial)
        {
            return await this.appDbContext.Osusr8dwCsicpCg006s.AsNoTracking().Where(e => e.TenantId == InTenant)
                .Where(e => e.Cg006FilialId == InFilial).Select(e => e.Cg006Id).ToListAsync();
        }


        /// <summary>
        /// Calcula saldo atual consolidando saldos anteriores e mês atual em uma única query.
        /// Suporta grupos de meses (trimestres, semestres, etc.)
        /// Retorna saldo anterior, saldo atual, total crédito e total débito
        /// VERSÃO CORRIGIDA - Busca dados primeiro e faz agregação em memória
        /// </summary>
        public async Task<List<SaldoContaPorMesResult>> CS_SaldoAtual_Conta_Otimizado(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID)
        {
            if (WorkListaContasID == null || !WorkListaContasID.Any()) return new List<SaldoContaPorMesResult>();

            const int BATCH_SIZE = 1000;
            var resultadoFinal = new List<SaldoContaPorMesResult>();

            for (int i = 0; i < WorkListaContasID.Count; i += BATCH_SIZE)
            {
                var batch = WorkListaContasID.Skip(i).Take(BATCH_SIZE).ToList();
                List<DadosCG009> dadosFiltrados = await CS_FiltraDadosCG009(Tenant, prm, batch);
                var resultadoBatch = CS_CalculaSaldosPorMes(prm, dadosFiltrados);
                resultadoFinal.AddRange(resultadoBatch);
            }
            //CS_AdicionaContasSemMovimentacao(WorkListaContasID, resultadoFinal);
            return resultadoFinal.OrderBy(e => e.CodigoConta).ToList();
        }


        /// <summary>
        /// Essa rotina tem como objetivo inicializar os registros de saldos do proximo ano contabil. 
        /// Criando os registros dos meses 0 a 12, onde o registro do mes 0 tem o saldo como origem
        /// o saldo anterior do mes 12 do ano anterior. e os meses de 1 a 12 sao sempre zerados.
        /// </summary>
        /// <param name="WorkListaContas_CG006_ID">Lista de IDS dos planos da conta</param>
        public async Task<CSResult<string>> CS_GeraSaldoContaComTransferenciaDeSaldo(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            PR139137_PrmCS_GeraSaldoConta PrmInput,
            List<string> WorkListaContas_CG006_ID)
        {
            var WorkListaGG009ToCreate = new List<CSICP_CG009>();
            prm.InMeses = [12];
            var saldoAnteriorMes12AnoInicial = await CS_SaldoAtual_Conta_Otimizado(Tenant, prm, WorkListaContas_CG006_ID);

            var listaContasID_CG009 = await this.appDbContext.Osusr8dwCsicpCg009s
                .Where(e => e.TenantId == Tenant && e.Cg009Ano == prm.InAnoNovo)
                .Select(e => new { e.Cg009ContaId , e.Cg009Mes})
                .ToListAsync();

            var contasAnoMesSet = new HashSet<(string, int)>(
                    listaContasID_CG009.Select(e => (e.Cg009ContaId, e.Cg009Mes))
                );

            var saldoAnteriorPorConta = saldoAnteriorMes12AnoInicial
                .Where(e => e.Mes == 12)
                .ToDictionary(e => e.ContaId, e => e.SaldoAtual);


            foreach (var contaId in WorkListaContas_CG006_ID)
            {
                for (int mes = 0; mes <= 12; mes++)
                {
                    if (contasAnoMesSet.Contains((contaId, mes))) continue;

                    if (mes == 0)
                    {
                        saldoAnteriorPorConta.TryGetValue(contaId, out var saldoAtual);
                        var cSICP_CG009 = CS_CriaSaldoContaMesZero(Tenant, prm.InAnoNovo, PrmInput, saldoAtual, contaId);
                        WorkListaGG009ToCreate.Add(cSICP_CG009);
                    }
                    else
                    {
                        CS_CriaSaldoContaMes1Ao12(Tenant, PrmInput, WorkListaGG009ToCreate, contaId, mes);
                    }
                }
            }


            // OTIMIZAÇÃO CRÍTICA: Bulk Insert de todas as novas entidades criadas
            if (WorkListaGG009ToCreate.Count > 0)
            {
                const int BULK_BATCH_SIZE = 10000;
                const SqlBulkCopyOptions BULK_OPTIONS = SqlBulkCopyOptions.Default;

                // Obtém a transação atual iniciada pelo Unit of Work
                var dbTransaction = this.appDbContext.Database
                    .CurrentTransaction?
                    .GetDbTransaction();

                if (dbTransaction == null)
                    throw new InvalidOperationException(
                        "Não foi possível obter a transação ativa do DbContext para a operação Bulk Insert."
                    );

                // Executa o Bulk Insert usando a transação existente
                await this.appDbContext.BulkInsertAsync(
                    WorkListaGG009ToCreate,
                    operation =>
                    {
                        operation.BatchSize = BULK_BATCH_SIZE;
                        operation.SqlBulkCopyOptions = (int)BULK_OPTIONS;
                    }
                );
            }
            return CSResult<string>.Success($"Saldos de contas gerados com sucesso para o ano {prm.InAnoNovo}.");
        }

        private static void CS_CriaSaldoContaMes1Ao12(
            int Tenant,
            PR139137_PrmCS_GeraSaldoConta PrmInput,
            List<CSICP_CG009> WorkListaGG009ToCreate,
            string currentCondaID, int mes)
        {
            var WorkGG009ToCreate = CSICP_CG009.CreateInstanceComValoresDebitoCreditoESaldoZerados(
                    tenant: Tenant,
                    ICS_GenerateId: PrmInput.CS_GenerateId,
                    cg009FilialId: PrmInput.InFilialID,
                    cg009TipoSaldoId: PrmInput.InTipoSaldoID,
                    cg009ContaId: currentCondaID,
                    cg009Ano: PrmInput.InAnoFechamento + 1,
                    cg009Mes: mes);

            WorkGG009ToCreate.NavCG006Conta_CG009 = null;
            WorkGG009ToCreate.NavBB001Estab_CG009 = null;
            WorkGG009ToCreate.NavCG008TipoSaldo_CG009 = null;
            WorkListaGG009ToCreate.Add(WorkGG009ToCreate);
        }

        private static CSICP_CG009 CS_CriaSaldoContaMesZero(
            int Tenant,
            int AnoPosterior,
            PR139137_PrmCS_GeraSaldoConta PrmInput,
            decimal saldoAtualFinalDoAnoInicial,
            string contaID)
        {
            var WorkGG009ToCreate_MesZero
               = CSICP_CG009.CreateInstanceComValoresDebitoCreditoMesZero(
                   tenant: Tenant,
                   ICS_GenerateId: PrmInput.CS_GenerateId,
                   cg009FilialId: PrmInput.InFilialID,
                   cg009TipoSaldoId: PrmInput.InTipoSaldoID,
                   cg009ContaId: contaID,
                   cg009Ano: AnoPosterior,
                   Saldo: saldoAtualFinalDoAnoInicial);
            WorkGG009ToCreate_MesZero.NavCG006Conta_CG009 = null;
            WorkGG009ToCreate_MesZero.NavBB001Estab_CG009 = null;
            WorkGG009ToCreate_MesZero.NavCG008TipoSaldo_CG009 = null;
            return WorkGG009ToCreate_MesZero;
        }


        /*PRIVADO*/
        private static List<SaldoContaPorMesResult> CS_CalculaSaldosPorMes(
               PR139137_PrmCS_TransSaldoCnt prm,
               List<DadosCG009> dadosPorConta)
        {
            var resultado = new List<SaldoContaPorMesResult>();
            var saldoPorConta = new Dictionary<string, decimal>();

            //int mesInicial = prm.GetMesInicial();
            int mesFinal = prm.GetMesFinal();

            var registrosOrdenados = dadosPorConta
                .Where(e => e.Cg009Mes != null && e.Cg009Mes >= 0 && e.Cg009Mes <= mesFinal)
                .OrderBy(e => e.Cg009ContaId)
                .ThenBy(e => e.Cg009Mes ?? 0);

            foreach (var registro in registrosOrdenados)
            {
                var contaId = registro.Cg009ContaId;
                int mes = registro.Cg009Mes ?? 0;
                decimal totalDebito = registro.Cg009Totaldebito ?? 0;
                decimal totalCredito = registro.Cg009Totalcredito ?? 0;


                // Se for o primeiro registro da conta, saldo anterior é o saldo do mês 0
                if (!saldoPorConta.ContainsKey(contaId))
                {
                    var saldoContaMesInicial = dadosPorConta
                        .FirstOrDefault(x => x.Cg009ContaId == contaId && x.Cg009Mes == 0)?.Cg009Saldo ?? 0;
                    saldoPorConta[contaId] = saldoContaMesInicial;
                }

                decimal saldoAnterior = saldoPorConta[contaId];
                decimal saldoAtual = saldoAnterior + (totalDebito - totalCredito);

                resultado.Add(new SaldoContaPorMesResult(
                    ContaId: contaId,
                    Mes: mes,
                    SaldoAnterior: saldoAnterior,
                    TotalDebito: totalDebito,
                    TotalCredito: totalCredito,
                    SaldoAtual: saldoAtual,
                    CodigoConta: registro.CodigoConta,
                    NomeConta: registro.NomeConta
                ));

                saldoPorConta[contaId] = saldoAtual;
            }
            return resultado;
        }

        private async Task<List<DadosCG009>> CS_FiltraDadosCG009(int Tenant, PR139137_PrmCS_TransSaldoCnt prm, List<string> batch)
        {
  
            return await this.appDbContext.Osusr8dwCsicpCg009s
                .AsNoTracking()
                .Where(e => e.TenantId == Tenant)
                .Where(e => e.Cg009FilialId == prm.InFilialID)
                .Where(e => e.Cg009TipoSaldoId == prm.InCG008_ID_TipoSaldo)
                .Where(e => e.Cg009Ano == prm.InAnoAtual)
                .Where(e => e.Cg009Mes >= 0 && e.Cg009Mes <= prm.GetMesFinal())
                .Where(e => batch.Contains(e.Cg009ContaId))
                .Select(e => new DadosCG009(
                e.Cg009ContaId,
                e.Cg009Mes,
                e.Cg009Saldo,
                e.Cg009Totaldebito,
                e.Cg009Totalcredito,
                e.NavCG006Conta_CG009 != null ? e.NavCG006Conta_CG009.Cg006Codigoplano : string.Empty,
                e.NavCG006Conta_CG009 != null ? e.NavCG006Conta_CG009.Cg006Descricao : string.Empty
            ))
                .ToListAsync();
        }



    }
}
