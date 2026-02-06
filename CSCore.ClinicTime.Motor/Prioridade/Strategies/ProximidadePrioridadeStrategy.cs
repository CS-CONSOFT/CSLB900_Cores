using CSCore.ClinicTime.Motor.Eventos;
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

      

        public decimal CalcularPrioridade(Dictionary<string, string> consulta, DtoDadosPrincipaisPaciente dto)
        {
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
                consulta.Remove("checkInNoLocal");
                consulta.Add("checkInNoLocal", "true");
                CSEvtHandler.DispararPacienteChegouAoLocal(new PacienteChegouEventArgs
                {
                    PacienteId = dto.PacienteId,
                    EstabelecimentoId = dto.EstabelecimentoId,
                    AgendaId = dto.AgendaID,
                    DistanciaMetros = dto.DistanciaPacienteEstabelecimentoMetros,
                    AgendaData = dto.AgendaData,
                    ProfissionalId = dto.ProfissionalId,
                    AgendaID = dto.AgendaID,
                    DictConsulta = consulta
                });
                return Peso * 1.1m;
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
