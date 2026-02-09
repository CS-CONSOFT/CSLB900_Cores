using CSCore.ClinicTime.Motor.Paciente;
using CSCore.ClinicTime.Motor.Prioridade;
using CSCore.Redis;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CSCore.ClinicTime.Motor.Medico
{
    public interface IClinicTimeMotorMedico
    {
        Task<(string, bool)> MedicoSolicitaTempoExtraNaConsulta(
            string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId, long TempoEmMinutosExtensaoConsulta);

        Task<(string, bool)> FinalizarConsulta(string AgendaID, DateOnly AgendaData, string EstabelecimentoID, string ProfissionalID, string PacienteID);

        Task<(string, bool)> IniciarConsulta(string AgendaID, DateOnly AgendaData, string EstabelecimentoID, string ProfissionalID, string PacienteID);

    }
    public class ClinicTimeMotorMedico : IClinicTimeMotorMedico
    {
        private IRedisConnection redisConnection;
        private ILogger<ClinicTimeMotorPaciente>? logger;
        private ISetarHorarioPacienteNaFila setarHorarioPacienteNaFila;

        public ClinicTimeMotorMedico(IRedisConnection redisConnection, ILogger<ClinicTimeMotorPaciente>? logger, ISetarHorarioPacienteNaFila setarHorarioPacienteNaFila)
        {
            this.redisConnection = redisConnection;
            this.logger = logger;
            this.setarHorarioPacienteNaFila = setarHorarioPacienteNaFila;
        }

        public async Task<(string, bool)> FinalizarConsulta(string AgendaID, DateOnly AgendaData, string EstabelecimentoID, string ProfissionalID, string PacienteID)
        {
            this.logger?.LogInformation($"Iniciando finalização de consulta para PacienteID: {PacienteID}, AgendaID: {AgendaID}, ProfissionalID: {ProfissionalID}, EstabelecimentoID: {EstabelecimentoID}, AgendaData: {AgendaData}");
            try
            {
                var dbRedis = redisConnection.GetDatabase();
                var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(AgendaData, AgendaID, EstabelecimentoID, ProfissionalID, PacienteID);
                await dbRedis.HashSetAsync(keyPaciente,
                  [
                    new HashEntry("paciente_em_consulta", false),
                    new HashEntry("paciente_atendido", true),
                    new HashEntry("horario_saida_consulta", DateTime.UtcNow.ToString("t")),
              ]);

                await AdicionaPacienteNaListaPacienteAtendidos(AgendaID, AgendaData, EstabelecimentoID, ProfissionalID, PacienteID, dbRedis);

                await this.setarHorarioPacienteNaFila.AtualizaHorarioPacientesAposUmaFinalizacaoDeConsulta(AgendaID, AgendaData, EstabelecimentoID, ProfissionalID);

                this.logger?.LogInformation($"Consulta finalizada com sucesso para PacienteID: {PacienteID}, AgendaID: {AgendaID}, ProfissionalID: {ProfissionalID}, EstabelecimentoID: {EstabelecimentoID}, AgendaData: {AgendaData}");

                return ("Consulta finalizada com sucesso.", true);
            }
            catch (Exception ex)
            {
                this.logger?.LogInformation($"Erro ao finalizar consulta para PacienteID: {PacienteID}, AgendaID: {AgendaID}, ProfissionalID: {ProfissionalID}, EstabelecimentoID: {EstabelecimentoID}, AgendaData: {AgendaData}. Erro: {ex.Message}");
                return ($"Ocorreu um erro ao finalizar a consulta: {ex.Message}", false);
            }

        }

    
        public async Task<(string, bool)> IniciarConsulta(string AgendaID, DateOnly AgendaData, string EstabelecimentoID, string ProfissionalID, string PacienteID)
        {
            this.logger?.LogInformation($"Iniciando consulta para PacienteID: {PacienteID}, AgendaID: {AgendaID}, ProfissionalID: {ProfissionalID}, EstabelecimentoID: {EstabelecimentoID}, AgendaData: {AgendaData}");
            try
            {
                var dbRedis = redisConnection.GetDatabase();
                var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(AgendaData, AgendaID, EstabelecimentoID, ProfissionalID, PacienteID);
                await dbRedis.HashSetAsync(keyPaciente,
                  [
                    new HashEntry("paciente_em_consulta", true),
                    new HashEntry("horario_entrada_consulta", DateTime.UtcNow.AddHours(-3).ToString("t")),
              ]);

                await RemoverPacienteDaFilaDeAguardoDeAtendimento(AgendaID, AgendaData, EstabelecimentoID, ProfissionalID, PacienteID, dbRedis);

                this.logger?.LogInformation($"Consulta iniciada com sucesso para PacienteID: {PacienteID}, AgendaID: {AgendaID}, ProfissionalID: {ProfissionalID}, EstabelecimentoID: {EstabelecimentoID}, AgendaData: {AgendaData}");

                return ("Consulta iniciada com sucesso.", true);
            }
            catch (Exception ex)
            {
                this.logger?.LogInformation($"Erro ao iniciar consulta para PacienteID: {PacienteID}, AgendaID: {AgendaID}, ProfissionalID: {ProfissionalID}, EstabelecimentoID: {EstabelecimentoID}, AgendaData: {AgendaData}. Erro: {ex.Message}");
                return ($"Ocorreu um erro ao inciar a consulta: {ex.Message}", false);
            }
        }

        public async Task<(string, bool)> MedicoSolicitaTempoExtraNaConsulta(
            string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId, long TempoEmMinutosExtensaoConsulta)
        {
            this.logger?.LogInformation($"Médico solicitando tempo extra na consulta para AgendaID: {agendaId}, AgendaData: {agendaData}, EstabelecimentoID: {estabelecimentoId}, ProfissionalID: {profissionalId}, TempoEmMinutosExtensaoConsulta: {TempoEmMinutosExtensaoConsulta}");
            try
            {
                await this.setarHorarioPacienteNaFila.AtualizaHorarioPacientesAposMedicoSolicitarExtensaoDeHorario(agendaId, agendaData, estabelecimentoId,profissionalId,TempoEmMinutosExtensaoConsulta);
                this.logger?.LogInformation($"Tempo extra de {TempoEmMinutosExtensaoConsulta} minutos solicitado com sucesso para AgendaID: {agendaId}, AgendaData: {agendaData}, EstabelecimentoID: {estabelecimentoId}, ProfissionalID: {profissionalId}");
                return ($"Tempo extra de {TempoEmMinutosExtensaoConsulta} minutos solicitado com sucesso.", true);
            }
            catch (Exception ex)
            {
                this.logger?.LogInformation($"Erro ao solicitar tempo extra na consulta para AgendaID: {agendaId}, AgendaData: {agendaData}, EstabelecimentoID: {estabelecimentoId}, ProfissionalID: {profissionalId}, TempoEmMinutosExtensaoConsulta: {TempoEmMinutosExtensaoConsulta}. Erro: {ex.Message}");
                return ($"Ocorreu um erro ao solicitar tempo extra na consulta: {ex.Message}", false);
            }
        }

        private static async Task AdicionaPacienteNaListaPacienteAtendidos(string AgendaID, DateOnly AgendaData, string EstabelecimentoID, string ProfissionalID, string PacienteID, IDatabase dbRedis)
        {
            await dbRedis.ListLeftPushAsync(ConfigRedis.GetKeyPacientesAtendidos(AgendaData, AgendaID, EstabelecimentoID, ProfissionalID), PacienteID);
        }


        private static async Task RemoverPacienteDaFilaDeAguardoDeAtendimento(string AgendaID, DateOnly AgendaData, string EstabelecimentoID, string ProfissionalID, string PacienteID, IDatabase dbRedis)
        {
            var keyFila = ConfigRedis.GetKeyFila(AgendaID, AgendaData, EstabelecimentoID, ProfissionalID);
            await dbRedis.SortedSetRemoveAsync(keyFila, PacienteID);
        }

  
    }
}
