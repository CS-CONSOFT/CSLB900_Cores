using Azure.Messaging;
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
        public async Task<List<SaldoContaResultV2>> CS_SaldoAtual_Conta_Otimizado(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID)
        {
            if (WorkListaContasID == null || !WorkListaContasID.Any()) return new List<SaldoContaResultV2>();

            const int BATCH_SIZE = 1000;
            var resultadoFinal = new List<SaldoContaResultV2>();

            for (int i = 0; i < WorkListaContasID.Count; i += BATCH_SIZE)
            {
                var batch = WorkListaContasID.Skip(i).Take(BATCH_SIZE).ToList();
                List<DadosCG009> dadosFiltrados = await CS_FiltraDadosCG009(Tenant, prm, batch);
                List<SaldoContaResultV2> resultadoBatch = CS_CalculaSaldoContaAgrupado(prm, dadosFiltrados);
                resultadoFinal.AddRange(resultadoBatch);
            }
            CS_AdicionaContasSemMovimentacao(WorkListaContasID, resultadoFinal);
            return resultadoFinal.OrderBy(e => e.ContaCodigo).ToList();
        }


        /// <summary>
        /// Gera saldo (cg009) zerados para os meses 1 ao 12 quando uma conta é criada.
        /// </summary>
        /// <param name="Tenant"></param>
        /// <param name="InPrmGeraSaldoProx"></param>
        /// <returns></returns>
        public async Task CS_GeraSaldoConta(int Tenant, PR139137_PrmCS_GeraSaldoConta PrmInput, List<string> WorkListaContasID)
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


        /// <summary>
        /// Transfere saldo para o proximo período no mês '0'
        /// </summary>
        /// <returns></returns>
        public async Task CS_TransSaldoCnt(int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID)
        {
            var CS_SaldoAtual_Conta = this.CS_SaldoAtual_Conta_Otimizado(Tenant, prm, WorkListaContasID);
            var ListaContasAnoNovoMesZero = GetSaldoContaCG009AnoNovoMes0(Tenant, WorkListaContasID, prm.InAnoNovo, prm.InMes, prm.InCG008_ID_TipoSaldo, prm.InFilialID);

            await Task.WhenAll(CS_SaldoAtual_Conta, ListaContasAnoNovoMesZero);

            var ListaCG009Update = new List<CSICP_CG009>();
            var ListaCG009Create = new List<CSICP_CG009>();

            for (int i = 0; i < CS_SaldoAtual_Conta.Result.Count; i++)
            {
                var saldoAtualConta = CS_SaldoAtual_Conta.Result[i];
                var contaAnoNovoMesZero = ListaContasAnoNovoMesZero.Result.FirstOrDefault(c => c.Cg009ContaId == saldoAtualConta.ContaId);

                if (CS_ContaAnoNovoMesZeroExiste(contaAnoNovoMesZero))
                    CS_AtualizaSaldoContaExistente(ListaCG009Update, saldoAtualConta, contaAnoNovoMesZero);

                if (CS_ContaAnoNovoMesZeroNaoExiste(contaAnoNovoMesZero))
                    CS_CriaSaldoContaAnoNovoMesZero(Tenant, prm, ListaCG009Create, saldoAtualConta);

            }
            this.appDbContext.Osusr8dwCsicpCg009s.UpdateRange(ListaCG009Update);
            this.appDbContext.Osusr8dwCsicpCg009s.AddRange(ListaCG009Update);
        }


        public async Task<List<SaldoContaResult>> CS_SaldoAtual_Conta(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID)
        {
            prm = prm with { InMes = 12 };
            // Busca saldos anteriores (mês < prm.InMes)
            var saldosAnterioresTask = CS_SaldoAnt_Conta(Tenant, prm, WorkListaContasID);
            var totaisMesAtualTask = CS_SaldoMesAtual_Conta(Tenant, prm, WorkListaContasID);

            await Task.WhenAll(saldosAnterioresTask, totaisMesAtualTask);
            var saldosAnteriores = saldosAnterioresTask.Result;
            var totaisMesAtual = totaisMesAtualTask.Result;

            // Combina saldo anterior com movimentação do mês atual
            var resultado = totaisMesAtual.Select(mesAtual =>
            {
                var saldoAnt = saldosAnteriores.FirstOrDefault(s => s.ContaId == mesAtual.ContaId);
                var saldoFinal = saldoAnt?.Saldo + (mesAtual.TotalDebito - mesAtual.TotalCredito);

                return new SaldoContaResult(
                    ContaId: mesAtual.ContaId,
                    Saldo: saldoFinal ?? 0
                );
            }).ToList();

            return resultado;
        }




        /*PRIVADO*/
        private static bool CS_ContaAnoNovoMesZeroNaoExiste(CSICP_CG009? contaAnoNovoMesZero)
        {
            return !CS_ContaAnoNovoMesZeroExiste(contaAnoNovoMesZero);
        }

        private static void CS_CriaSaldoContaAnoNovoMesZero(int Tenant, PR139137_PrmCS_TransSaldoCnt prm, List<CSICP_CG009> ListaCG009Create, SaldoContaResultV2 saldoAtualConta)
        {
            var WorkGG009ToCreate
               = CSICP_CG009.CreateInstanceComValoresDebitoCreditoMesZerados(
                   tenant: Tenant,
                   ICS_GenerateId: prm.CS_GenerateId,
                   cg009FilialId: prm.InFilialID,
                   cg009TipoSaldoId: prm.InCG008_ID_TipoSaldo,
                   cg009ContaId: saldoAtualConta.ContaId,
                   cg009Ano: prm.InAnoNovo,
                   Saldo: saldoAtualConta.SaldoAtual);
            ListaCG009Create.Add(WorkGG009ToCreate);
        }

        private static void CS_AtualizaSaldoContaExistente(List<CSICP_CG009> ListaCG009Update, SaldoContaResultV2 saldoAtualConta, CSICP_CG009? contaAnoNovoMesZero)
        {
            contaAnoNovoMesZero!.Cg009Saldo = saldoAtualConta.SaldoAtual;
            ListaCG009Update.Add(contaAnoNovoMesZero!);
        }

        private static bool CS_ContaAnoNovoMesZeroExiste(CSICP_CG009? contaAnoNovoMesZero)
        {
            return contaAnoNovoMesZero != null;
        }


        private static void CS_AdicionaContasSemMovimentacao(List<string> WorkListaContasID, List<SaldoContaResultV2> resultadoFinal)
        {
            // Adicionar contas que não têm movimentação (saldo zerado)
            if (resultadoFinal.Count < WorkListaContasID.Count)
            {
                var contasEncontradas = resultadoFinal.Select(r => r.ContaId).ToHashSet();
                var contasFaltantes = WorkListaContasID.Where(id => !contasEncontradas.Contains(id));

                foreach (var contaId in contasFaltantes)
                {
                    resultadoFinal.Add(new SaldoContaResultV2(
                        ContaId: contaId,
                        SaldoAtual: 0,
                        ContaNome: string.Empty,
                        ContaCodigo: string.Empty,
                        SaldoAnterior: 0,
                        MesValores: []
                    ));
                }
            }
        }



        private static List<SaldoContaResultV2> CS_CalculaSaldoContaAgrupado(
            PR139137_PrmCS_TransSaldoCnt prm,
            List<DadosCG009> dadosFiltrados)
        {
            var mesValores = new List<SaldoContaResultListMesValores>();
            var dados = dadosFiltrados
                .GroupBy(e => e.Cg009ContaId)
                .Select(listaAgrupadaCG009PorConta =>
                {
                    var saldoInicial 
                        = listaAgrupadaCG009PorConta
                        .Where(x => x.Cg009Mes == 0).Sum(x => x.Cg009Saldo ?? 0);

                    var totalDebitoAnt = listaAgrupadaCG009PorConta
                        .Where(x => x.Cg009Mes > 0 && x.Cg009Mes <= prm.GetMesInicial() - 1)
                        .Sum(x => x.Cg009Totaldebito);

                    var totalCreditoAnt = listaAgrupadaCG009PorConta
                       .Where(x => x.Cg009Mes > 0 && x.Cg009Mes <= prm.GetMesInicial() - 1)
                       .Sum(x => x.Cg009Totalcredito);

                    var saldoAnteriorAnt = (saldoInicial + (totalDebitoAnt - totalCreditoAnt) ?? 0);

                    var mesValores = listaAgrupadaCG009PorConta
                       .Where(x => x.Cg009Mes != null && x.Cg009Mes >= prm.GetMesInicial())
                       .OrderBy(x => x.Cg009Mes)
                       .Select(x => new SaldoContaResultListMesValores(
                           TotalCredito: x.Cg009Totalcredito ?? 0,
                           TotalDebito: x.Cg009Totaldebito ?? 0,
                           Mes: x.Cg009Mes ?? -1
                       )).ToList();

                    var totalDebito = mesValores.Sum(e => e.TotalDebito);
                    var totalCredito = mesValores.Sum(e => e.TotalCredito);
                    var saldoAtual = (saldoAnteriorAnt + (totalDebito - totalCredito));

                    return new SaldoContaResultV2(
                         ContaId: listaAgrupadaCG009PorConta.Key,
                         SaldoAtual: saldoAtual,
                         SaldoAnterior: saldoAnteriorAnt,
                         MesValores: mesValores,
                         ContaCodigo: listaAgrupadaCG009PorConta.FirstOrDefault()?.CodigoConta ?? string.Empty,
                         ContaNome: listaAgrupadaCG009PorConta.FirstOrDefault()?.NomeConta ?? string.Empty
                     );
                })
                .ToList();
            return dados;
        }

        private async Task<List<DadosCG009>> CS_FiltraDadosCG009(int Tenant, PR139137_PrmCS_TransSaldoCnt prm, List<string> batch)
        {
            return await this.appDbContext.Osusr8dwCsicpCg009s
                .AsNoTracking()
                .Where(e => e.TenantId == Tenant)
                .Where(e => e.Cg009FilialId == prm.InFilialID)
                .Where(e => e.Cg009TipoSaldoId == prm.InCG008_ID_TipoSaldo)
                .Where(e => e.Cg009Ano == prm.InAnoAtual)
                .Where(e => e.Cg009Mes <= prm.GetMesFinal() && e.Cg009Mes >= 0)
                .Where(e => e.NavCG006Conta_CG009.Cg006Descricao == "CAIXA DA MATRIZ")
                .Where(e => batch.Contains(e.Cg009ContaId))
                .Select(e => new DadosCG009(
                    e.Cg009ContaId,
                    e.Cg009Mes,
                    e.Cg009Saldo,
                    e.Cg009Totaldebito,
                    e.Cg009Totalcredito,
                    e.NavCG006Conta_CG009.Cg006Codigoplano,
                    e.NavCG006Conta_CG009.Cg006Descricao
                ))
                .ToListAsync();
        }

        private async Task<List<SaldoMesAtual_Conta>> CS_SaldoMesAtual_Conta(
            int Tenant, PR139137_PrmCS_TransSaldoCnt prm, List<string> WorkListaContasID)
        {

            // Busca totais do mês atual
            return await this.appDbContext.Osusr8dwCsicpCg009s
                .AsNoTracking()
                .Where(e => e.TenantId == Tenant)
                .Where(e => e.Cg009FilialId == prm.InFilialID)
                .Where(e => e.Cg009TipoSaldoId == prm.InCG008_ID_TipoSaldo)
                .Where(e => e.Cg009Ano == prm.InAnoAtual)
                .Where(e => e.Cg009Mes == prm.InMes)
                .Where(e => WorkListaContasID.Contains(e.Cg009ContaId))
                .GroupBy(e => e.Cg009ContaId)
                .Select(g =>
                new SaldoMesAtual_Conta(g.Key, g.Sum(x => x.Cg009Totalcredito ?? 0), g.Sum(x => x.Cg009Totaldebito ?? 0)))
                .ToListAsync();
        }



        public async Task<List<SaldoContaResult>> CS_SaldoAnt_Conta(
            int Tenant,
            PR139137_PrmCS_TransSaldoCnt prm,
            List<string> WorkListaContasID)
        {
            var saldosAnteriores = await this.appDbContext.Osusr8dwCsicpCg009s
                 .AsNoTracking()
                 .Where(e => e.TenantId == Tenant)
                 .Where(e => e.Cg009FilialId == prm.InFilialID)
                 .Where(e => e.Cg009TipoSaldoId == prm.InCG008_ID_TipoSaldo)
                 .Where(e => e.Cg009Ano == prm.InAnoAtual)
                 .Where(e => e.Cg009Mes < prm.InMes)
                 .Where(e => WorkListaContasID.Contains(e.Cg009ContaId))
                 .GroupBy(e => e.Cg009ContaId)
                .Select(grupo => new SaldoContaResult(
                        grupo.Key,
                        grupo.Where(x => x.Cg009Mes == 0).Sum(x => x.Cg009Saldo ?? 0)
                            + (grupo.Sum(x => x.Cg009Totaldebito ?? 0)
                             - grupo.Sum(x => x.Cg009Totalcredito ?? 0))
                    )).ToListAsync();
            return saldosAnteriores;
        }
    }
}
