using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade baseada no tempo de espera após check-in
    /// </summary>
    public class TempoEsperaPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "Tempo de Espera";
        public decimal Peso => 10m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            if (consulta.TryGetValue("checkInTimestamp", out var timestamp))
            {
                var checkInTime = DateTime.Parse(timestamp);
                var minutosEsperando = (DateTime.UtcNow - checkInTime).TotalMinutes;

                var scoreEspera = (decimal)(minutosEsperando / 10);
                return Peso * scoreEspera;
            }

            return 0m;
        }
    }
}