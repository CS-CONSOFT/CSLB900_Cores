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
        public decimal Peso => 1m;

        private double DistanciaMaximaEmMetrosDoLocalPraMarcarQueChegouNoLocal = 100;

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
            ConfiguraStatusPaciente.ResetarStatus();
            _ = consulta.TryGetValue("checkInNoLocal", out var checkInLocal);
            bool.TryParse(checkInLocal, out bool checkInLocalBool);
            bool estaNoLocal = checkInLocalBool || dto.PacienteIsChekinLocal;

            if (ChegouAoLocalEPermaneceNele(dto, estaNoLocal))
            {
                ConfiguraStatusPaciente.PacienteChegouESeLocomoveuNoLocal();
                return 0m;
            }
               

            if (ChegouAoLocalMasComecouADistanciar(dto, estaNoLocal))
            {
                ConfiguraStatusPaciente.PacienteChegouESaiuDoLocal();
                return Convert.ToDecimal(dto.DistanciaPacienteEstabelecimentoMetros * -1);
            }

            var scoreProximidade = CalcularScoreProximidade(dto.DistanciaPacienteEstabelecimentoMetros);

            if (dto.DistanciaPacienteEstabelecimentoMetros < DistanciaMaximaEmMetrosDoLocalPraMarcarQueChegouNoLocal)
            {
                // Marca que chegou ao local para processamento posterior
                ConfiguraStatusPaciente.PacienteChegouAoLocal();
                return Peso * 1m;
            }

            return Peso * scoreProximidade;
        }

        private bool ChegouAoLocalEPermaneceNele(DtoDadosPrincipaisPaciente dto, bool estaNoLocal)
        {
            return estaNoLocal && dto.DistanciaPacienteEstabelecimentoMetros < DistanciaMaximaEmMetrosDoLocalPraMarcarQueChegouNoLocal;
        }

        private bool ChegouAoLocalMasComecouADistanciar(DtoDadosPrincipaisPaciente dto, bool estaNoLocal)
        {
            return estaNoLocal && dto.DistanciaPacienteEstabelecimentoMetros > DistanciaMaximaEmMetrosDoLocalPraMarcarQueChegouNoLocal;
        }

        private decimal CalcularScoreProximidade(double distanciaMetros)
        {
            double distanciaKm = distanciaMetros / 1000.0;
            if (distanciaKm < 0.5) return 10m;   // < 500m
            if (distanciaKm < 1.0) return 8m;   // < 1km
            if (distanciaKm < 2.0) return 5m;   // < 2km
            if (distanciaKm < 5.0) return 2m;   // < 5km
            return 0m;                            // > 5km
        }
    }
}