using CSLB900.MSTools.GenerateId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.CG.Repository.CG00X.PR139_137_FechamentoAnual
{
    public record SaldoContaResult(
 string ContaId,
 decimal Saldo
     );

    public record SaldoContaResultListMesValores(decimal TotalCredito,
     decimal TotalDebito,
     int Mes)
    {
       
    };

    public record SaldoContaResultV2(
     string ContaId,
     string ContaCodigo,
     string ContaNome,
     decimal SaldoAtual,
     decimal SaldoAnterior,
     IEnumerable<SaldoContaResultListMesValores> MesValores
 );

    public record SaldoMesAtual_Conta(string ContaId, decimal TotalCredito, decimal TotalDebito)
    {

    }
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

    public record PR139137_PrmCS_TransSaldoCnt(
        string InFilialID,
        int InAnoAtual,
        int InAnoNovo,
        int InMes,
        string InCG008_ID_TipoSaldo, ICS_GenerateId CS_GenerateId)
    {
        /// <summary>
        /// Lista de meses para cálculo. Se null, usa apenas InMes.
        /// Exemplos: [1,2,3] para 1º trimestre, [1,2,3,4,5,6] para 1º semestre
        /// </summary>
        public List<int>? InMeses { get; init; }

        /// <summary>
        /// Retorna a lista de meses a serem considerados no cálculo
        /// </summary>
        public List<int> GetMesesParaCalculo() => InMeses ?? new List<int> { InMes };

        /// <summary>
        /// Retorna o maior mês do período
        /// </summary>
        public int GetMesFinal() => InMeses?.Max() ?? InMes;
        public int GetMesInicial() => InMeses?.Min() ?? InMes;


    };
}
