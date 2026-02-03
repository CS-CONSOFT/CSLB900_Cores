using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade baseada na aderência ao horário agendado
    /// </summary>
    public class HorarioPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "Horário";
        public decimal Peso => 25m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoAtualizaLocPaciente dto)
        {
            if (consulta.TryGetValue("horaInicio", out var horaInicio))
            {
                var scoreHorario = CalcularScoreHorario(TimeSpan.Parse(horaInicio), DateTime.UtcNow.TimeOfDay);
                return Peso * scoreHorario;
            }

            return 0m;
        }

        private decimal CalcularScoreHorario(TimeSpan horaAgendada, TimeSpan horaAtual)
        {
            var diferencaMinutos = Math.Abs((horaAtual - horaAgendada).TotalMinutes);

            if (diferencaMinutos <= 5) return 1.0m;   // ±5min
            if (diferencaMinutos <= 15) return 0.8m;  // ±15min
            if (diferencaMinutos <= 30) return 0.5m;  // ±30min
            return 0.2m;
        }
    }
}
