using CSCore.ClinicTime.Motor;
using CSCore.ClinicTime.Motor.EntidadesMock;
using CSCore.ClinicTime.Motor.Eventos;
using CSCore.ClinicTime.Motor.Paciente;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System.Runtime.CompilerServices;

namespace CLT200APIClinicTime.Controllers.Motor
{
    /// <summary>
    /// Classe de compatibilidade que mantém a API estática original
    /// Internamente utiliza o padrão Strategy através de ServiceCalculadorPrioridade
    /// </summary>
    public static class CalcularPrioridadeDaFila
    {
        /// <summary>
        /// Recalcula a prioridade de uma consulta na fila
        /// </summary>
        /// <param name="DbRedis">Instância do banco Redis</param>
        public static async Task RecalcularPrioridadeConsultaAtualizandoNoRedis(IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente,IDatabase DbRedis, DtoDadosPrincipaisPaciente dto, ILogger? logger = null)
        {
            var calculador = new ServiceCalculadorPrioridade(DbRedis, recuperaDadosDaConsultaDoPaciente, logger);
            await calculador.RecalcularPrioridadeConsultaESalvaNoRedis(dto, EnumTipoEstrategiaCalculoPrioridade.MOVIMENTO);
        }

        /// <summary>
        /// Apenas Insere o paciente na fila, com score basico de prioridades
        /// </summary>
        /// <param name="DbRedis">Instância do banco Redis</param>
        public static async Task InserePacienteNaFilaNoRedis(IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente,IDatabase DbRedis, DtoDadosPrincipaisPaciente dto)
        {
            var calculador = new ServiceCalculadorPrioridade( DbRedis, recuperaDadosDaConsultaDoPaciente);
            await calculador.RecalcularPrioridadeConsultaESalvaNoRedis(dto, EnumTipoEstrategiaCalculoPrioridade.INICIAL);
        }


    }
}
