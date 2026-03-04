using System;
using System.Collections.Generic;
using System.Text;
using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies.Novas
{
    internal class PrioridadeGestanteRiscoIntermediario : IPrioridadeStrategy
    {
        public string Nome => string.Empty;
        public decimal Peso => 0m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            if (consulta.TryGetValue("pesoPacienteEspecial", out var peso) && int.TryParse(peso, out var pesoInt))
            {
                return pesoInt * 1.0m;
            }

            return 0m;
        }
    }
}
