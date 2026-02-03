using CSCore.ClinicTime.Motor;
using CSCore.ClinicTime.Motor.EntidadesMock;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade;
using StackExchange.Redis;

namespace CLT200APIClinicTime.Controllers.Motor
{
    /// <summary>
    /// Classe de compatibilidade que mantém a API estática original
    /// Internamente utiliza o padrão Strategy através de CalculadorPrioridade
    /// </summary>
    public static class CalcularPrioridadeDaFila
    {
        /// <summary>
        /// Recalcula a prioridade de uma consulta na fila
        /// </summary>
        /// <param name="DbRedis">Instância do banco Redis</param>
        /// <returns>Prioridade calculada</returns>
        public static async Task<decimal> RecalcularPrioridadeConsulta(IDatabase DbRedis, DtoAtualizaLocPaciente dto)
        {
            var calculador = new CalculadorPrioridade(DbRedis);
            return await calculador.RecalcularPrioridadeConsulta(dto);
        }

      
    }
}
