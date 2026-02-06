using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade para pacientes com deficiência (PCD)
    /// </summary>
    public class PcdPrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "PCD";
        public decimal Peso => 50m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            _ = consulta.TryGetValue("pacientePcd", out var pacientePcd);
            bool isTrue = (pacientePcd == "1" || pacientePcd == "true");
            if (isTrue)
            {
                return Peso * 1.0m;
            }

            return 0m;
        }
    }
}
