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
            if (consulta.TryGetValue("tempoEmMinutosQueUsuarioEstaNoLocal", out var tempoEmMinutosString))
            {
               var tempoEmMinutos = int.Parse(tempoEmMinutosString);
                if (tempoEmMinutos >= 30) return Peso * 1.0m;   // 30+ minutos
                if (tempoEmMinutos >= 15) return Peso * 0.8m;   // 15-29 minutos
                if (tempoEmMinutos >= 5) return Peso * 0.5m;    // 5-14 minutos
                return Peso * 0.2m;                             // <5 minutos
            }

            return 0m;
        }
    }
}