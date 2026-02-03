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

        private readonly double _distanciaMaximaKm = 5.0; // Distância máxima considerada para pontuação

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoAtualizaLocPaciente dto)
        {
            bool estaNoLocal = consulta.TryGetValue("checkInNoLocal", out var checkInLocal);
            
            if (estaNoLocal)
            {
                return 0m;
            }

            var scoreProximidade = CalcularScoreProximidade(_distanciaMaximaKm);
            return Peso * scoreProximidade;
        }

        private decimal CalcularScoreProximidade(double distanciaKm)
        {
            if (distanciaKm < 0.5) return 1.0m;   // < 500m
            if (distanciaKm < 1.0) return 0.8m;   // < 1km
            if (distanciaKm < 2.0) return 0.5m;   // < 2km
            if (distanciaKm < 5.0) return 0.2m;   // < 5km
            return 0m;                            // > 5km
        }
    }
}
