using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade para check-in realizado no local
    /// </summary>
    public class CheckInLocalPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "CheckIn Local";
        public decimal Peso => 30m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoAtualizaLocPaciente dto)
        {
            if (consulta.TryGetValue("checkInNoLocal", out var checkInLocal) )
            {
                return Peso * 1.0m;
            }

            return 0m;
        }
    }
}
