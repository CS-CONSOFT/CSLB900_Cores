using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade para pacientes gestantes
    /// </summary>
    public class GestantePrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "Gestante";
        public decimal Peso => 45m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            if (consulta.TryGetValue("pacienteGestante", out var gestante))
            {
                return Peso * 1.0m;
            }

            return 0m;
        }
    }
}
