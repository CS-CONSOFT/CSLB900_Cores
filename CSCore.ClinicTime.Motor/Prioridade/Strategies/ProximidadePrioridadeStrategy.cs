using CSCore.ClinicTime.Motor.Paciente.dto;

namespace CSCore.ClinicTime.Motor.Prioridade.Strategies
{
    /// <summary>
    /// Estratégia de prioridade baseada na proximidade do paciente ao estabelecimento
    /// Só é aplicada se o paciente NÃO estiver no local
    /// </summary>
    public class ProximidadePrioridadeStrategy : IPrioridadeStrategy
    {
        public string Nome => "Proximidade";
        public decimal Peso => 15m;

        // Flag para indicar se o paciente chegou ao local
        public bool PacienteChegouAoLocal { get; private set; }

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            PacienteChegouAoLocal = false; // Reset flag

            _ = consulta.TryGetValue("checkInNoLocal", out var checkInLocal);
            bool.TryParse(checkInLocal, out bool checkInLocalBool);
            bool estaNoLocal = checkInLocalBool || dto.PacienteIsChekinLocal;

            if (estaNoLocal)
            {
                return 0m;
            }

            var scoreProximidade = CalcularScoreProximidade(dto.DistanciaPacienteEstabelecimentoMetros);

            if (dto.DistanciaPacienteEstabelecimentoMetros < 100)
            {
                // Marca que chegou ao local para processamento posterior
                PacienteChegouAoLocal = true;
                consulta["checkInNoLocal"] = "true";

                return Peso * 1m;
            }

            return Peso * scoreProximidade;
        }

        private decimal CalcularScoreProximidade(double distanciaMetros)
        {
            double distanciaKm = distanciaMetros / 1000.0;
            if (distanciaKm < 0.5) return 1.0m;   // < 500m
            if (distanciaKm < 1.0) return 0.8m;   // < 1km
            if (distanciaKm < 2.0) return 0.5m;   // < 2km
            if (distanciaKm < 5.0) return 0.2m;   // < 5km
            return 0m;                            // > 5km
        }
    }
}