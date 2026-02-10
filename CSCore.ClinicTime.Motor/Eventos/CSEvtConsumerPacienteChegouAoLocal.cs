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
            var prioridade = decimal.Parse((string)redisValue!, CultureInfo.InvariantCulture);
            prioridade += _chekinLocalPrioriedadeStrategy.CalcularPrioridade(e.DictConsulta, dto: DtoDadosPrincipaisPaciente.DtoVazioPorFaltaDeUsoNesseMetodo());

            await dbRedis.HashSetAsync(
               keyPaciente,
               "hora_paciente_checkin_local",
               DateTime.UtcNow.AddHours(-3).ToString("t"));

            prioridade = await IncrementaPrioridadeBaseadoNoHorarioDoChekin(dbRedis, keyPaciente, prioridade);

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

        private static async Task<decimal> IncrementaPrioridadeBaseadoNoHorarioDoChekin(IDatabase dbRedis, string keyPaciente, decimal prioridade)
        {
            RedisValue horaPacienteChekinLocal = await dbRedis.HashGetAsync(keyPaciente, "hora_paciente_checkin_local");
            var horaChekinLocal = DateTime.Parse((string)horaPacienteChekinLocal!, CultureInfo.InvariantCulture);
            double diferencaMinutosHoraAtualComHoraChekinLocal = DateTime.UtcNow.AddHours(-3).Subtract(horaChekinLocal).TotalMinutes;
            prioridade += (decimal)diferencaMinutosHoraAtualComHoraChekinLocal;

            /*recupera a hora que o paciente fez o check-in*/
            RedisValue horaPacienteChekinApp = await dbRedis.HashGetAsync(keyPaciente, "hora_paciente_chekin_app");

            if (!PacienteFezChekinNoApp(horaPacienteChekinApp)) return prioridade;

            var horaChekinApp = DateTime.Parse((string)horaPacienteChekinApp!, CultureInfo.InvariantCulture);

            double diferencaMinutosHoraAtualComHoraChekin = DateTime.UtcNow.AddHours(-3).Subtract(horaChekinApp).TotalMinutes;

            RedisValue pacienteEspecial = await dbRedis.HashGetAsync(keyPaciente, "pacienteEspecial");

            if (!IsPacienteEspecial(pacienteEspecial)) prioridade += (decimal)diferencaMinutosHoraAtualComHoraChekin;

            RedisValue pesoPacienteEspecial = await dbRedis.HashGetAsync(keyPaciente, "pesoPacienteEspecial");

            if (!PacienteEspecialTemPesoValido(pesoPacienteEspecial)) return prioridade;

            /*variavel criada para ser controle do peso, quando tiver que fazer multiplicacao pra somar na prioridade*/
            var _pesoPacienteEspecial = 1;

            _pesoPacienteEspecial = int.Parse((string)pesoPacienteEspecial!, CultureInfo.InvariantCulture);

            prioridade += (decimal)diferencaMinutosHoraAtualComHoraChekin * _pesoPacienteEspecial;

            return prioridade;
        }

        private static bool PacienteEspecialTemPesoValido(RedisValue pesoPacienteEspecial)
        {
            return pesoPacienteEspecial != "-1";
        }

        private static bool IsPacienteEspecial(RedisValue pacienteEspecial)
        {
            return pacienteEspecial == "1";
        }

        private static bool PacienteFezChekinNoApp(RedisValue horaPacienteChekinApp)
        {
            return horaPacienteChekinApp != "0";
        }
    }
}