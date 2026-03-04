using System;
using System.Collections.Generic;
using System.Text;
using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies.Novas
{
    internal class PrioridadeSemPrioridade : IPrioridadeStrategy
    {
        public string Nome => string.Empty;
        public decimal Peso => 0m;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            return 0m;
        }
    }
}
