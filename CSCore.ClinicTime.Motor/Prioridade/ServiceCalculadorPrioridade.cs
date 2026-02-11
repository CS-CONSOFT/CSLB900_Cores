using CSCore.ClinicTime.Motor.Paciente;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade.Strategies;
using CSCore.ClinicTime.Motor.Util;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System.Globalization;

namespace CSCore.ClinicTime.Motor.Prioridade
{


    /// <summary>
    /// Movimento representa a utilização das estratégias quando o paciente já está em movimento (check-in, proximidade, etc) para recalcular a prioridade
    /// Calcula a prioridade inicial conforme os parametros de PCD, Idoso, Gestante
    /// </summary>
    public enum EnumTipoEstrategiaCalculoPrioridade
    {
        MOVIMENTO, INICIAL
    }

    /// <summary>
    /// Calculador de prioridade da fila usando o padrão Strategy
    /// </summary>
    public class ServiceCalculadorPrioridade
    {
        private readonly List<IPrioridadeStrategy> EstrategiasQuandoPacienteEstaEmMovimento;
        private readonly IDatabase _dbRedis;
        private readonly ILogger? _logger;
        private readonly IRecuperaDadosDaConsultaDoPacienteDoRedis _recuperaDadosDaConsultaDoPaciente;


        public ServiceCalculadorPrioridade(IDatabase dbRedis, IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente, ILogger? logger = null)
        {

            _dbRedis = dbRedis;
            _logger = logger;
            _recuperaDadosDaConsultaDoPaciente = recuperaDadosDaConsultaDoPaciente;
            EstrategiasQuandoPacienteEstaEmMovimento = new List<IPrioridadeStrategy>
            {
                new ProximidadePrioridadeStrategy(),
                new TempoEsperaPrioridadeStrategy()
            };
            //this._logger?.LogInformation("ServiceCalculadorPrioridade inicializado com {CountEstrategiasMovimento} estratégias para movimento e {CountEstrategiasBase} estratégias base", EstrategiasQuandoPacienteEstaEmMovimento.Count, EstrategiaBaseQuandoPacienteEntraNaFilaConsiderandoPrioridades.Count);
        }



        /// <summary>
        /// Recalcula a prioridade de UMA consulta (paciente específico)
        /// </summary>
        public async Task RecalcularPrioridadeConsultaESalvaNoRedis(DtoDadosPrincipaisPaciente dto, EnumTipoEstrategiaCalculoPrioridade tipoEstrategia)
        {
            if (DataAtualDaConsultaEhIgualAOntem(dto))
            {
                await RemoveFilaDeUmDiaAntesDaConsulta(dto);
                return;
            }

            var dict = await _recuperaDadosDaConsultaDoPaciente.RetornaDadosConsultaPaciente(dto.PacienteId, dto.AgendaData, dto.AgendaID, dto.EstabelecimentoId, dto.ProfissionalId);
            if (dict.Count == 0)
                return;

            decimal prioridadeTotal = RecuperaAPrioridadeTotalSalvaNaEstruturaDoUsuario(dict);

            var estrategiasASeremUsadas = tipoEstrategia == EnumTipoEstrategiaCalculoPrioridade.MOVIMENTO
                ? EstrategiasQuandoPacienteEstaEmMovimento
                : GetEstrategiasQuandoIniciaAFila(dict);

            bool pacienteChegouAoLocal = false;

            foreach (var strategy in estrategiasASeremUsadas)
            {
                var prioridade = strategy.CalcularPrioridade(dict, dto);
                prioridadeTotal += prioridade;

                // Detecta se o paciente chegou ao local
                if (strategy is ProximidadePrioridadeStrategy proximidade && proximidade.PacienteChegouAoLocal)
                {
                    pacienteChegouAoLocal = true;
                }
            }

            // 🎯 PROCESSA CHECK-IN LOCAL ATOMICAMENTE
            if (pacienteChegouAoLocal)
            {
                this._logger?.LogInformation("Paciente {PacienteId} chegou ao local! Aplicando bonificação de check-in", dto.PacienteId);

                var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(dto.AgendaData, dto.AgendaID, dto.EstabelecimentoId, dto.ProfissionalId, dto.PacienteId);

                // Marca check-in no local
                await _dbRedis.HashSetAsync(keyPaciente, "checkInNoLocal", "true");
                await _dbRedis.HashSetAsync(keyPaciente, "hora_paciente_checkin_local", DateTime.UtcNow.AddHours(-3).ToString("t"));

                // Aplica bonificação de check-in local
                prioridadeTotal += 1000m;

                // Incrementa com tempo de espera desde check-in no app (se existir)
                prioridadeTotal = await IncrementaPrioridadeComTempoDeChegadaNoLocal(keyPaciente, prioridadeTotal);

                this._logger?.LogInformation("Bonificação aplicada para paciente {PacienteId} por check-in local. Nova prioridade: {PrioridadeTotal}", dto.PacienteId, prioridadeTotal);

                // Adiciona ao job de background para monitoramento
                await _dbRedis.SetAddAsync(
                    ConfigRedis.GetKeyJobsBackgroundPacienteAguardando(DateOnly.FromDateTime(DateTime.UtcNow.Date), dto.AgendaID, dto.EstabelecimentoId, dto.ProfissionalId),
                    System.Text.Json.JsonSerializer.Serialize(dto));
            }

            this._logger?.LogInformation("Prioridade recalculada para paciente {PacienteId} na agenda {AgendaID} do dia {AgendaData}. Nova prioridade: {PrioridadeTotal}", dto.PacienteId, dto.AgendaID, dto.AgendaData, prioridadeTotal);

            await AtualizaAPrioridadeEfetivaDoUsuarioAposAtualizacao(dto, prioridadeTotal);

            await CriaOuAtualizaFilaDosPacientesEmUmaAgenda(dto, prioridadeTotal, dict);
        }



        #region Métodos Privados
        private async Task<decimal> IncrementaPrioridadeComTempoDeChegadaNoLocal(string keyPaciente, decimal prioridade)
        {

            // Calcula tempo desde check-in local
            RedisValue horaPacienteChekinLocal = await _dbRedis.HashGetAsync(keyPaciente, "hora_paciente_checkin_local");
            if (!horaPacienteChekinLocal.IsNullOrEmpty)
            {
                var horaChekinLocal = DateTime.Parse((string)horaPacienteChekinLocal!, CultureInfo.InvariantCulture);
                double minutosEntreHorarioDeChekinEHorarioAtual = horaChekinLocal.Subtract(DateTime.UtcNow.AddHours(-3)).TotalMinutes;
                if (minutosEntreHorarioDeChekinEHorarioAtual < 0) minutosEntreHorarioDeChekinEHorarioAtual = minutosEntreHorarioDeChekinEHorarioAtual * -1;
                prioridade += ((decimal)minutosEntreHorarioDeChekinEHorarioAtual * 2);
            }


            // Recupera check-in no app
            RedisValue horaPacienteChekinApp = await _dbRedis.HashGetAsync(keyPaciente, "hora_paciente_chekin_app");
            RedisValue pacienteEspecial = await _dbRedis.HashGetAsync(keyPaciente, "pacienteEspecial"); ;
            DateTime horaChekinApp;
            double minutosDesdeCheckinApp = 0;

            if (IsHoraPacienteCheckinAppNullOrZero(horaPacienteChekinApp) && IsNotPacienteEspecial(pacienteEspecial))
                return prioridade;

            if (IsHoraPacienteCheckinAppNullOrZero(horaPacienteChekinApp) && IsPacienteEspecial(pacienteEspecial))
            {
                prioridade = await IncrementaPrioridadeComPesoPacienteEspecial(keyPaciente, prioridade, minutosDesdeCheckinApp: null);
                return prioridade;
            }
               

            if (IsHoraPacienteCheckinAppValido(horaPacienteChekinApp) && IsPacienteEspecial(pacienteEspecial))
            {
                CalculaMinutosDesdeCheckinApp(horaPacienteChekinApp, out horaChekinApp, out minutosDesdeCheckinApp);
                prioridade = await IncrementaPrioridadeComPesoPacienteEspecial(keyPaciente, prioridade, minutosDesdeCheckinApp);
                return prioridade;
            }

            if (IsHoraPacienteCheckinAppValido(horaPacienteChekinApp) && IsNotPacienteEspecial(pacienteEspecial))
            {
                CalculaMinutosDesdeCheckinApp(horaPacienteChekinApp, out horaChekinApp, out minutosDesdeCheckinApp);
                prioridade += (decimal)minutosDesdeCheckinApp;
                return prioridade;
            }
            return prioridade;
        }

        private async Task<decimal> IncrementaPrioridadeComPesoPacienteEspecial(string keyPaciente, decimal prioridade, double? minutosDesdeCheckinApp)
        {
            RedisValue pesoPacienteEspecial = await _dbRedis.HashGetAsync(keyPaciente, "pesoPacienteEspecial");
            bool isPesoValido = int.TryParse((string)pesoPacienteEspecial!, out int peso);
            if (isPesoValido && minutosDesdeCheckinApp.HasValue)
                prioridade += (decimal)minutosDesdeCheckinApp * peso;
            else
                prioridade += 30 * peso; // Bonificação fixa para pacientes especiais sem check-in no app


            return prioridade;
        }

        private static void CalculaMinutosDesdeCheckinApp(RedisValue horaPacienteChekinApp, out DateTime horaChekinApp, out double minutosDesdeCheckinApp)
        {
            horaChekinApp = DateTime.Parse((string)horaPacienteChekinApp!, CultureInfo.InvariantCulture);
            minutosDesdeCheckinApp = horaChekinApp.Subtract(DateTime.UtcNow.AddHours(-3)).TotalMinutes;
            if (minutosDesdeCheckinApp < 0) minutosDesdeCheckinApp = minutosDesdeCheckinApp * -1;
        }

        private static bool IsNotPacienteEspecial(RedisValue pacienteEspecial)
        {
            return pacienteEspecial != "1";
        }

        private static bool IsPacienteEspecial(RedisValue pacienteEspecial)
        {
            return pacienteEspecial == "1";
        }

        private static bool IsHoraPacienteCheckinAppNullOrZero(RedisValue horaPacienteChekinApp)
        {
            return horaPacienteChekinApp.IsNullOrEmpty || horaPacienteChekinApp == "0";
        }

        private static bool IsHoraPacienteCheckinAppValido(RedisValue horaPacienteChekinApp)
        {
            return !horaPacienteChekinApp.IsNullOrEmpty && horaPacienteChekinApp != "0";
        }


        private IList<IPrioridadeStrategy> GetEstrategiasQuandoIniciaAFila(Dictionary<string, string> dict)
        {
            dict.TryGetValue("pacienteEspecial", out var pacienteEspecialStr);

            //this._logger?.LogInformation("Verificando se o paciente é especial para aplicar estratégias iniciais. Valor encontrado: {PacienteEspecialStr}", pacienteEspecialStr);

            bool isOk = bool.TryParse(pacienteEspecialStr, out bool isPacienteEspecial);
            bool _isPacienteEspecial = isOk ? isPacienteEspecial : false;

            //this._logger?.LogInformation("Paciente é especial? {IsPacienteEspecial}", _isPacienteEspecial);

            dict.TryGetValue("tipoPacienteEspecial", out var tipoPacienteEspecial);
            return VerificaTipoPacienteEspecial.ConverteTipoPacienteEspecialParaIPriority(tipoPacienteEspecial);

        }

        /*ISSO DEVE ACONTECER DEPOIS DE INSERIR TODOS*/
        private async Task CriaOuAtualizaFilaDosPacientesEmUmaAgenda(DtoDadosPrincipaisPaciente dto, decimal prioridadeTotal, Dictionary<string, string> dadosPacienteConsulta)
        {
            //this._logger?.LogInformation("Criando ou atualizando posição do paciente {PacienteId} na fila da agenda {AgendaID} do dia {AgendaData} com prioridade {PrioridadeTotal}", dto.PacienteId, dto.AgendaID, dto.AgendaData, prioridadeTotal);
            await _dbRedis.SortedSetAddAsync(
                ConfigRedis.GetKeyFila(dto.AgendaID, dto.AgendaData, dto.EstabelecimentoId, dto.ProfissionalId),
                dto.PacienteId,
                (double)prioridadeTotal
            );
        }

        private async Task AtualizaAPrioridadeEfetivaDoUsuarioAposAtualizacao(DtoDadosPrincipaisPaciente dto, decimal prioridadeTotal)
        {
            var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(dto.AgendaData, dto.AgendaID, dto.EstabelecimentoId, dto.ProfissionalId, dto.PacienteId);
            await _dbRedis.HashSetAsync(
              keyPaciente,
              "prioridadeEfetiva",
              prioridadeTotal.ToString("F2")
            );
        }

        private static decimal RecuperaAPrioridadeTotalSalvaNaEstruturaDoUsuario(Dictionary<string, string> dict)
        {
            dict.TryGetValue("prioridadeEfetiva", out var prioridadeBaseStr);
            bool isOk = decimal.TryParse(prioridadeBaseStr, out decimal prioridadeBase);
            decimal prioridadeTotal = isOk ? prioridadeBase : 0m;
            return prioridadeTotal;
        }

        private async Task RemoveFilaDeUmDiaAntesDaConsulta(DtoDadosPrincipaisPaciente dto)
        {
            await _dbRedis.SortedSetRemoveAsync(ConfigRedis.GetKeyFila(dto.AgendaID, DateOnly.FromDateTime(DateTime.UtcNow.AddDays(-1)), dto.EstabelecimentoId, dto.ProfissionalId), dto.PacienteId);
        }

        private static bool DataAtualDaConsultaEhIgualAOntem(DtoDadosPrincipaisPaciente dto)
        {
            return dto.AgendaData == DateOnly.FromDateTime(DateTime.UtcNow.AddDays(-1));
        }

        #endregion

        #region Privte Class

        private class HorarioFuncionamento
        {
            public DayOfWeek DiaSemana { get; set; }
            public TimeOnly HoraInicio { get; set; }
            public TimeOnly HoraFim { get; set; }
        }

        #endregion
    }
}
