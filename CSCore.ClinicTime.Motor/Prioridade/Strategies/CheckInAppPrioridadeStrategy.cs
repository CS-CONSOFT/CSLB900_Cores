using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade para check-in realizado pelo aplicativo
    /// </summary>
    public class CheckInAppPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "CheckIn App";
        public decimal Peso => 20m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoAtualizaLocPaciente dto)
        {
            if (consulta.TryGetValue("checkIn", out var checkIn))
            {
                return Peso * 1.0m;
            }

            return 0m;
        }
    }
}
