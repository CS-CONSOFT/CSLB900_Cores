using CSCore.ClinicTime.Motor.Eventos;
using CSCore.ClinicTime.Motor.Paciente;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade.Strategies;
using CSCore.ClinicTime.Motor.Prioridade.Strategies.Novas;
using CSCore.ClinicTime.Motor.Util;
using Microsoft.Extensions.Logging;
using Pipelines.Sockets.Unofficial.Arenas;
using StackExchange.Redis;

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
    public class CalculadorPrioridade
    {
        private readonly List<IPrioridadeStrategy> EstrategiasQuandoPacienteEstaEmMovimento;
        private readonly List<IPrioridadeStrategy> EstrategiaBaseQuandoPacienteEntraNaFilaConsiderandoPrioridades;
        private readonly IDatabase _dbRedis;
        private readonly ILogger? _logger;
        private readonly IRecuperaDadosDaConsultaDoPacienteDoRedis _recuperaDadosDaConsultaDoPaciente;


        public CalculadorPrioridade(IDatabase dbRedis, IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente, ILogger? logger = null)
        {

            _dbRedis = dbRedis;
            _logger = logger;
            _recuperaDadosDaConsultaDoPaciente = recuperaDadosDaConsultaDoPaciente;
            EstrategiasQuandoPacienteEstaEmMovimento = new List<IPrioridadeStrategy>
            {
                new CheckInAppPrioridadeStrategy(),
                new ProximidadePrioridadeStrategy(),
                new HorarioPrioridadeStrategy(),
                new TempoEsperaPrioridadeStrategy()
            };
            EstrategiaBaseQuandoPacienteEntraNaFilaConsiderandoPrioridades = [];
            this._logger?.LogInformation("CalculadorPrioridade inicializado com {CountEstrategiasMovimento} estratégias para movimento e {CountEstrategiasBase} estratégias base", EstrategiasQuandoPacienteEstaEmMovimento.Count, EstrategiaBaseQuandoPacienteEntraNaFilaConsiderandoPrioridades.Count);
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

            foreach (var strategy in estrategiasASeremUsadas)
            {   
                /*dentro da estratégia de proximidade existe um evento que dispara quando o paciente chega ao local da consulta*/
                var prioridade = strategy.CalcularPrioridade(dict, dto);
                prioridadeTotal += prioridade;
            }

            this._logger?.LogInformation("Prioridade recalculada para paciente {PacienteId} na agenda {AgendaID} do dia {AgendaData}. Nova prioridade: {PrioridadeTotal}", dto.PacienteId, dto.AgendaID, dto.AgendaData, prioridadeTotal);

            await AtualizaAPrioridadeEfetivaDoUsuarioAposAtualizacao(dto, prioridadeTotal);

            await CriaOuAtualizaFilaDosPacientesEmUmaAgenda(dto, prioridadeTotal, dict);
        }



        #region Métodos Privados

        private IList<IPrioridadeStrategy> GetEstrategiasQuandoIniciaAFila(Dictionary<string, string> dict)
        {
            dict.TryGetValue("pacienteEspecial", out var pacienteEspecialStr);

            this._logger?.LogInformation("Verificando se o paciente é especial para aplicar estratégias iniciais. Valor encontrado: {PacienteEspecialStr}", pacienteEspecialStr);

            bool isOk = bool.TryParse(pacienteEspecialStr, out bool isPacienteEspecial);
            bool _isPacienteEspecial = isOk ? isPacienteEspecial : false;

            this._logger?.LogInformation("Paciente é especial? {IsPacienteEspecial}", _isPacienteEspecial);

            dict.TryGetValue("tipoPacienteEspecial", out var tipoPacienteEspecial);
            return VerificaTipoPacienteEspecial.ConverteTipoPacienteEspecialParaIPriority(tipoPacienteEspecial);

        }

        /*ISSO DEVE ACONTECER DEPOIS DE INSERIR TODOS*/
        private async Task CriaOuAtualizaFilaDosPacientesEmUmaAgenda(DtoDadosPrincipaisPaciente dto, decimal prioridadeTotal, Dictionary<string, string> dadosPacienteConsulta)
        {
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
