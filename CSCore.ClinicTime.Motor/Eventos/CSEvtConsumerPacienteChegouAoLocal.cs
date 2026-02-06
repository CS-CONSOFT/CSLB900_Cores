using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade;
using CSCore.Redis;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;
using System.Globalization;
using System.Text.Json;

namespace CSCore.ClinicTime.Motor.Eventos
{
    public class CSEvtConsumerPacienteChegouAoLocal : IHostedService
    {
        private readonly IRedisConnection _redisConnection;
        private readonly IPrioridadeStrategy _chekinLocalPrioriedadeStrategy;

        public CSEvtConsumerPacienteChegouAoLocal(IRedisConnection redisConnection, IPrioridadeStrategy _chekinLocalPrioriedadeStrategy)
        {
            _redisConnection = redisConnection;
            this._chekinLocalPrioriedadeStrategy = _chekinLocalPrioriedadeStrategy;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            CSEvtHandler.EvtHandlerPacienteChegouAoLocalDaConsulta += AtualizarEstruturaDoUsuarioNoRedisInformandoQueChegouAoLocal;
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            CSEvtHandler.EvtHandlerPacienteChegouAoLocalDaConsulta -= AtualizarEstruturaDoUsuarioNoRedisInformandoQueChegouAoLocal;
            return Task.CompletedTask;
        }

        private async void AtualizarEstruturaDoUsuarioNoRedisInformandoQueChegouAoLocal(object? sender, PacienteChegouEventArgs e)
        {
            var dbRedis = _redisConnection.GetDatabase();
            var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(e.AgendaData, e.AgendaID, e.EstabelecimentoId, e.ProfissionalId, e.PacienteId);

            await dbRedis.HashSetAsync(
                  keyPaciente,
                  "checkInNoLocal",
                  "true"
                    );

            RedisValue redisValue = await dbRedis.HashGetAsync(keyPaciente, "prioridadeEfetiva");
            var prioridade = decimal.Parse((string)redisValue, CultureInfo.InvariantCulture);

            prioridade += _chekinLocalPrioriedadeStrategy.CalcularPrioridade(e.DictConsulta, dto: DtoDadosPrincipaisPaciente.DtoVazioPorFaltaDeUsoNesseMetodo());

            await dbRedis.HashSetAsync(
            keyPaciente,
            "prioridadeEfetiva",
            prioridade.ToString("F2"));


            await dbRedis.SetAddAsync(ConfigRedis.GetKeyJobsBackgroundPacienteAguardando(DateOnly.FromDateTime(DateTime.UtcNow.Date)), JsonSerializer.Serialize(new
            {
                AgendaData = e.AgendaData,
                ProfissionalId = e.ProfissionalId,
                AgendaID = e.AgendaID,
                EstabID = e.EstabelecimentoId,
                PacienteID = e.PacienteId
            }));
        }
    }
}