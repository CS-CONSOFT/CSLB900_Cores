using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade.Strategies;
using StackExchange.Redis;

namespace CSCore.ClinicTime.Motor.Prioridade
{
    /// <summary>
    /// Calculador de prioridade da fila usando o padrão Strategy
    /// </summary>
    public class CalculadorPrioridade
    {
        private readonly List<IPrioridadeStrategy> _strategies;
        private readonly IDatabase _dbRedis;

        public CalculadorPrioridade(IDatabase dbRedis)
        {
            _dbRedis = dbRedis;
            _strategies = new List<IPrioridadeStrategy>
            {
                new PcdPrioridadeStrategy(),
                new IdosoPrioridadeStrategy(),
                new GestantePrioridadeStrategy(),
                new CheckInAppPrioridadeStrategy(),
                new CheckInLocalPrioridadeStrategy(),
                new ProximidadePrioridadeStrategy(),
                new HorarioPrioridadeStrategy(),
                new TempoEsperaPrioridadeStrategy()
            };
        }

        /// <summary>
        /// Construtor alternativo que permite injetar estratégias customizadas
        /// </summary>
        public CalculadorPrioridade(IDatabase dbRedis, IEnumerable<IPrioridadeStrategy> strategies)
        {
            _dbRedis = dbRedis;
            _strategies = strategies.ToList();
        }


        /// <summary>
        /// Recalcula a prioridade de UMA consulta (paciente específico)
        /// </summary>
        public async Task<decimal> RecalcularPrioridadeConsulta(DtoAtualizaLocPaciente dto)
        {
            var keyPaciente =
                $"{CHAVES_REDIS.STR_CONSULTA}Estabelecimentos:{dto.EstabelecimentoId}:" +
                $"Profissionais:{dto.ProfissionalId}:PacientesDados:{dto.PacienteId}";

            var consulta = await _dbRedis.HashGetAllAsync(keyPaciente);

            if (consulta.Length == 0)
                return 0m;

            var dict = consulta.ToDictionary(
                he => he.Name.ToString(),
                he => he.Value.ToString()
            );

            decimal prioridadeTotal = 0m;

            foreach (var strategy in _strategies)
            {
                var prioridade = strategy.CalcularPrioridade(dict, dto);
                prioridadeTotal += prioridade;
            }

            await _dbRedis.HashSetAsync(
              keyPaciente,
              "prioridadeEfetiva",
              prioridadeTotal.ToString("F2")
          );

            await _dbRedis.SortedSetAddAsync(
                $"{CHAVES_REDIS.STR_FILA}Estabelecimentos:{dto.EstabelecimentoId}:Profissionais:{dto.ProfissionalId}",
                dto.PacienteId,
                (double)prioridadeTotal
            );

            return prioridadeTotal;
        }

    }
}
