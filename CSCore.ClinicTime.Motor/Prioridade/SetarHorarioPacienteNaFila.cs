using CSCore.Redis;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSCore.ClinicTime.Motor.Prioridade
{
    public interface ISetarHorarioPacienteNaFila
    {
        Task AtribuirHorariosParaTodosPacientesDaFila(string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId, TimeOnly horarioInicio, TimeOnly horarioFim);
        Task AtualizaHorarioPacientesAposUmaFinalizacaoDeConsulta(string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId);
        Task AtualizaHorarioPacientesAposMedicoSolicitarExtensaoDeHorario(
            string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId, long TempoEmMinutosExtensaoConsulta);
    }
    public class SetarHorarioPacienteNaFila : ISetarHorarioPacienteNaFila
    {
        private readonly IRedisConnection redisConnection;
        private readonly ILogger<SetarHorarioPacienteNaFila> _logger;
        public SetarHorarioPacienteNaFila(IRedisConnection redisConnection, ILogger<SetarHorarioPacienteNaFila> logger)
        {
            this.redisConnection = redisConnection;
            this._logger = logger;
        }

        public async Task AtualizaHorarioPacientesAposMedicoSolicitarExtensaoDeHorario(
            string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId, long TempoEmMinutosExtensaoConsulta)
        {
            var _dbRedis = redisConnection.GetDatabase();
            var keyFila = ConfigRedis.GetKeyFila(agendaId, agendaData, estabelecimentoId, profissionalId);

            // Recupera todos os pacientes ordenados por prioridade DECRESCENTE (maior score = maior prioridade)
            var pacientesOrdenados = await _dbRedis.SortedSetRangeByRankAsync(keyFila, 0, -1, Order.Descending);

            if (pacientesOrdenados.Length == 0)
            {
                this._logger?.LogInformation("Nenhum paciente na fila da agenda {AgendaID} do dia {AgendaData} para atualizar horários após finalização de consulta.",
                    agendaId, agendaData);
                return;
            }

            // Atualiza o horario do paciente apos a finalizacao do primeiro
            for (int i = 0; i < pacientesOrdenados.Length; i++)
            {
                var pacienteId = pacientesOrdenados[i].ToString();
                var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                    agendaData, agendaId, estabelecimentoId, profissionalId, pacienteId
                );


                RedisValue rvHoraAtendimentoPacienteSalvo = await _dbRedis.HashGetAsync(keyPaciente, "horario_previsto_atendimento_consulta_paciente");
                var horaAtendimentoPacienteSalvo = TimeOnly.Parse(rvHoraAtendimentoPacienteSalvo!);
                var dataHoraAtendimento = horaAtendimentoPacienteSalvo.AddMinutes(TempoEmMinutosExtensaoConsulta);

                await _dbRedis.HashSetAsync(keyPaciente,
                    "horario_previsto_atendimento_consulta_paciente",
                    dataHoraAtendimento.ToString("t")
                );
            }
        }



        public async Task AtualizaHorarioPacientesAposUmaFinalizacaoDeConsulta(string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId)
        {
            var _dbRedis = redisConnection.GetDatabase();
            var keyFila = ConfigRedis.GetKeyFila(agendaId, agendaData, estabelecimentoId, profissionalId);

            // Recupera todos os pacientes ordenados por prioridade DECRESCENTE (maior score = maior prioridade)
            var pacientesOrdenados = await _dbRedis.SortedSetRangeByRankAsync(keyFila, 0, -1, Order.Descending);

            if (pacientesOrdenados.Length == 0)
            {
                this._logger?.LogInformation("Nenhum paciente na fila da agenda {AgendaID} do dia {AgendaData} para atualizar horários após finalização de consulta.",
                    agendaId, agendaData);
                return;
            }

            // Atualiza o horario do paciente apos a finalizacao do primeiro
            for (int i = 0; i < pacientesOrdenados.Length; i++)
            {
                var pacienteId = pacientesOrdenados[i].ToString();

                /*
                    primeiro paciente = 0 * 30 = 0 minutos de espera
                    segundo paciente = 1 * 30 = 30 minutos de espera
                    terceiro paciente = 2 * 30 = 60 minutos de espera
                 */
                var dataHoraAtendimento = DateTime.UtcNow.AddMinutes(i * 30);

                var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                    agendaData, agendaId, estabelecimentoId, profissionalId, pacienteId
                );

                await _dbRedis.HashSetAsync(keyPaciente,
                    "horario_previsto_atendimento_consulta_paciente",
                    dataHoraAtendimento.AddHours(-3).ToString("t")
                );
            }
        }

        /// <summary>
        /// Atribui horários para todos os pacientes na fila baseado na ordem de prioridade.
        /// Deve ser chamado APÓS todos os pacientes terem sido inseridos no sorted set.
        /// </summary>
        public async Task AtribuirHorariosParaTodosPacientesDaFila(string agendaId, DateOnly agendaData, string estabelecimentoId, string profissionalId, TimeOnly horarioInicio, TimeOnly horarioFim)
        {
            var _dbRedis = redisConnection.GetDatabase();
            var keyFila = ConfigRedis.GetKeyFila(agendaId, agendaData, estabelecimentoId, profissionalId);

            // Recupera todos os pacientes ordenados por prioridade DECRESCENTE (maior score = maior prioridade)
            var pacientesOrdenados = await _dbRedis.SortedSetRangeByRankAsync(keyFila, 0, -1, Order.Descending);

            if (pacientesOrdenados.Length == 0)
            {
                this._logger?.LogInformation("Nenhum paciente na fila da agenda {AgendaID} do dia {AgendaData} para atribuir horários.",
                    agendaId, agendaData);
                return;
            }

            // Gera os horários disponíveis
            var horariosDisponiveis = GerarHorariosDisponiveis(horarioInicio, horarioFim);

            this._logger?.LogInformation("Iniciando atribuição de horários para {TotalPacientes} pacientes na agenda {AgendaID} do dia {AgendaData}. Horários disponíveis: {TotalHorarios}",
                pacientesOrdenados.Length, agendaId, agendaData, horariosDisponiveis.Count);

            // Atribui horários sequencialmente baseado na ordem da fila
            for (int i = 0; i < pacientesOrdenados.Length; i++)
            {
                var pacienteId = pacientesOrdenados[i].ToString();

                if (i < horariosDisponiveis.Count)
                {
                    var horarioAtendimento = horariosDisponiveis[i];
                    var dataHoraAtendimento = agendaData.ToDateTime(horarioAtendimento);

                    var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                        agendaData, agendaId, estabelecimentoId, profissionalId, pacienteId
                    );

                    await _dbRedis.HashSetAsync(keyPaciente,
                        "horario_previsto_atendimento_consulta_paciente",
                        dataHoraAtendimento.ToString("t")
                    );

                    this._logger?.LogInformation("Paciente {PacienteId} na posição {Posicao} agendado para o horário {HorarioAtendimento}.",
                        pacienteId, i + 1, dataHoraAtendimento);
                }
                else
                {
                    this._logger?.LogWarning("Paciente {PacienteId} na posição {Posicao} excede os horários disponíveis ({TotalHorarios}) para a agenda {AgendaID}.",
                        pacienteId, i + 1, horariosDisponiveis.Count, agendaId);

                    /*NAO TEM HORARIO DISPONIVEL DO MECIDO PRO PACIENTE, ENTAO REMOVER O PACIENTE DA FILA*/
                    var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                        agendaData, agendaId, estabelecimentoId, profissionalId, pacienteId
                    );

                    // Remove o hash completo dos dados do paciente
                    await _dbRedis.KeyDeleteAsync(keyPaciente);

                    // Remove o paciente do sorted set da fila
                    await _dbRedis.SortedSetRemoveAsync(keyFila, pacienteId);


                    await _dbRedis.ListLeftPushAsync(ConfigRedis.GetKeyPacientesQueNaoPuderamSerAtendidosNoHorario(agendaId, agendaData, estabelecimentoId, profissionalId), pacienteId);
                }
            }

            this._logger?.LogInformation("Atribuição de horários concluída para a agenda {AgendaID} do dia {AgendaData}. {TotalAtribuidos} horários atribuídos.",
                agendaId, agendaData, Math.Min(pacientesOrdenados.Length, horariosDisponiveis.Count));
        }


        private List<TimeOnly> GerarHorariosDisponiveis(TimeOnly horarioInicio, TimeOnly horarioFim)
        {
            var horarios = new List<TimeOnly>();
            var intervaloAtendimento = TimeSpan.FromMinutes(30);
            var horarioAtual = horarioInicio;

            while (horarioAtual <= horarioFim)
            {
                horarios.Add(horarioAtual);
                horarioAtual = horarioAtual.Add(intervaloAtendimento);
            }

            return horarios;
        }


    }
}
