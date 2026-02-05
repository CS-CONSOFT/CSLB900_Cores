using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade para pacientes idosos (60+ anos)
    /// </summary>
    public class IdosoPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "Idoso";
        public decimal Peso => 40m;

        public decimal   CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            if (consulta.TryGetValue("pacienteIdoso", out var idoso))
            {
                return Peso * 1.0m;
            }

            return 0m;
        }
    }
}
