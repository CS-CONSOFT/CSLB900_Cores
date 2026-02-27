using CSCore.ClinicTime.Motor.Paciente.dto;
using StackExchange.Redis;

namespace CSCore.ClinicTime.Motor.Prioridade
{
    /// <summary>
    /// Interface para estratégias de cálculo de prioridade na fila
    /// </summary>
    public interface IPrioridadeStrategy
    {
        /// <summary>
        /// Nome identificador da estratégia
        /// </summary>
        string Nome { get; }

        /// <summary>
        /// Peso da estratégia no cálculo final de prioridade
        /// </summary>
        decimal Peso { get; }

        /// <summary>
        /// Calcula o score de prioridade para esta estratégia (retorna valor entre 0 e 1)
        /// </summary>
        /// <param name="consulta">Dados da consulta do Redis</param>
        /// <param name="dadosAdicionais">Dados adicionais como distância, velocidade, etc.</param>
        /// <returns>Score normalizado (0 a 1) multiplicado pelo peso</returns>
        decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto);

        
    }
}
