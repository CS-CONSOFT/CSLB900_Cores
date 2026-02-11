using CLT200APIClinicTime.Controllers.Motor;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.ClinicTime.Motor.Prioridade;
using CSCore.Redis;
using CSLB900.MSTools.Calculos.Distancia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pipelines.Sockets.Unofficial.Arenas;
using StackExchange.Redis;

namespace CSCore.ClinicTime.Motor.Paciente
{
    #region INTERFACES
    public interface IClinicTimeMotorPaciente
    {
        Task<(bool, string)> PacienteMarcaChekinNoApp(DtoPacienteCheknApp dto);

        /// <summary>
        /// Esse método é responsável por atualizar a localização do paciente. A cada 30-60 segundos ou mudança > 50 metros
        /// </summary>
        Task<double> AtualizaPosicaoDoPacienteAoSeMovimentar(DtoDadosPrincipaisPaciente dtoAtualizaLocPaciente);

        /// <summary>
        /// Retorna a posição atual do paciente na fila e o score de prioridade
        /// </summary>
        /// <param name="dtoAtualizaLocPaciente"></param>
        /// <returns></returns>
        Task<(int, double)> RetornaPosicaoPacienteNaFila(DtoDadosPrincipaisPaciente dtoAtualizaLocPaciente);

        Task<(bool, string)> PacienteEstaNoLocalMasAindaNaoFoiAtendido_AumetandoOTempoNoLocalParaDefinirANovaPrioridade(DateOnly AgendaData, string ProfissionalId, string AgendaID, string EstabID, string PacienteID);

    }
    #endregion


    public class ClinicTimeMotorPaciente : IClinicTimeMotorPaciente
    {

        private IRedisConnection redisConnection;
        private ILogger<ClinicTimeMotorPaciente>? logger;
        private IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente;
        private ISetarHorarioPacienteNaFila setarHorarioPacienteNaFila;

        public ClinicTimeMotorPaciente(IRedisConnection redisConnection, IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente, ILogger<ClinicTimeMotorPaciente>? logger = null, ISetarHorarioPacienteNaFila setarHorarioPacienteNaFila = null)
        {
            this.recuperaDadosDaConsultaDoPaciente = recuperaDadosDaConsultaDoPaciente;
            this.redisConnection = redisConnection;
            this.logger = logger;
            this.setarHorarioPacienteNaFila = setarHorarioPacienteNaFila;
        }


        public async Task<(bool, string)> PacienteEstaNoLocalMasAindaNaoFoiAtendido_AumetandoOTempoNoLocalParaDefinirANovaPrioridade(DateOnly AgendaData, string ProfissionalId, string AgendaID, string EstabID, string PacienteID)
        {
            this.logger?.LogInformation($"[ClinicTimeMotorPaciente - PacienteEstaNoLocalMasAindaNaoFoiAtendido_AumetandoOTempoNoLocalParaDefinirANovaPrioridade] Verificando se o paciente {PacienteID} está no local e ainda não foi atendido para aumentar o tempo no local e definir nova prioridade.");
            var dadosPacienteConsulta = await recuperaDadosDaConsultaDoPaciente.RetornaDadosConsultaPaciente(PacienteID, AgendaData, AgendaID, EstabID, ProfissionalId);

            if (dadosPacienteConsulta.Count == 0)
                return (false, $"Paciente sem dados de consulta pra esses parametros: Dia: {AgendaData} - Clinica: {EstabID} - Medico: {ProfissionalId}");

            dadosPacienteConsulta.TryGetValue("tempoEmMinutosQueUsuarioEstaNoLocal", out var tempoEmMinutosQueUsuarioEstaNoLocal);
            var conseguiuParsear = double.TryParse(tempoEmMinutosQueUsuarioEstaNoLocal, out double tempoEmMinutos);

            if (!conseguiuParsear) return (false, "Falha ao passar tempoEmMinutosQueUsuarioEstaNoLocal para double");

            tempoEmMinutos += 1; // Incrementa 1 minuto a cada chamada desse método, que é chamado a cada 1 minuto pelo sistema de background job

            return (true, $"Tempo no local atualizado para {tempoEmMinutos} minutos para o paciente {PacienteID} na consulta {AgendaID} do dia {AgendaData}.");
        }


        /// <summary>
        /// Esse método é responsável por atualizar a localização do paciente. A cada 30-60 segundos ou mudança > 50 metros
        /// </summary>
        public async Task<double> AtualizaPosicaoDoPacienteAoSeMovimentar(DtoDadosPrincipaisPaciente dto)
        {
            try
            {
                var dbRedis = this.redisConnection.GetDatabase();

                Dictionary<string, string> dictionary = await this.recuperaDadosDaConsultaDoPaciente.RetornaDadosConsultaPaciente(dto.PacienteId, dto.AgendaData, dto.AgendaID, dto.EstabelecimentoId, dto.ProfissionalId);
                if (dictionary == null || dictionary.Count == 0) return 0;
                await AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(dto, dbRedis);

                //this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizaPosicaoDoPacienteAoSeMovimentar] Localização do paciente {dto.PacienteId} atualizada com sucesso no Redis.");


                double? distanciaAteClinicaEmMetros = await CalculaDistanciaEntreLocalPacienteEClinica(dto, dbRedis);

                //this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizaPosicaoDoPacienteAoSeMovimentar] Distância do paciente {dto.PacienteId} até o estabelecimento {dto.EstabelecimentoId} é de {distanciaAteClinicaEmMetros} metros.");

                var tempoAteClinica = CalcularTempoAteLocal.Calcular((distanciaAteClinicaEmMetros ?? 0), dto.VelocidadeAtualPaciente);

                //this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizaPosicaoDoPacienteAoSeMovimentar] Tempo do paciente {dto.PacienteId} até o estabelecimento {dto.EstabelecimentoId} é de {tempoAteClinica} metros.");

                await AtualizaDicionarioDadosDaConsultaAtual(dto, dbRedis, distanciaAteClinicaEmMetros, tempoAteClinica);

                //this.logger?.LogInformation("Recalculando prioridade da fila para o paciente {PacienteId}", dto.PacienteId);

                await CalcularPrioridadeDaFila.RecalcularPrioridadeConsultaAtualizandoNoRedis(this.recuperaDadosDaConsultaDoPaciente, dbRedis, dto, this.logger);

                await this.setarHorarioPacienteNaFila.AtribuirHorariosParaTodosPacientesDaFila(
                  dto.AgendaID,
                  dto.AgendaData,
                  dto.EstabelecimentoId,
                  dto.ProfissionalId,
                  dto.AgendaHorarioInicio,
                  dto.AgendaHorarioFim
              );

                return tempoAteClinica;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<(bool, string)> PacienteMarcaChekinNoApp(DtoPacienteCheknApp dto)
        {
            try
            {
                Dictionary<string, string> dict = await this.recuperaDadosDaConsultaDoPaciente.RetornaDadosConsultaPaciente(dto.PacienteID, dto.AgendaData, dto.AgendaID, dto.EstabelecimentoID, dto.ProfissionalID);
                if (dict == null || dict.Count == 0)
                    return (false, "Paciente sem dados de consulta pra esses parametros: Dia: " + dto.AgendaData + " - Clinica: " + dto.EstabelecimentoID + " - Medico: " + dto.ProfissionalID);

                dict.TryGetValue("chekinApp", out var valorChekinApp);
                if (valorChekinApp != null && valorChekinApp.Equals("true", StringComparison.OrdinalIgnoreCase))
                    return (false, "Paciente já tinha feito check-in no app para essa consulta.");

                var dbRedis = this.redisConnection.GetDatabase();
                var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(dto.AgendaData, dto.AgendaID, dto.EstabelecimentoID, dto.ProfissionalID, dto.PacienteID);
                await dbRedis.HashSetAsync(keyPaciente,
                [
                    new HashEntry("chekinApp", "true"),
                    new HashEntry("hora_paciente_chekin_app", dto.HoraChekinApp.ToString("t"))
                ]);

                return (true, "Check-in no app registrado com sucesso para o paciente.");
            }
            catch (Exception ex)
            {
                return (false, $"Erro ao registrar check-in no app para o paciente: {ex.Message}");
            }
        }

        public async Task<(int, double)> RetornaPosicaoPacienteNaFila(DtoDadosPrincipaisPaciente dto)
        {
            this.logger?.LogInformation($"[ClinicMotorPaciente - RetornaPosicaoPacienteNaFila] Retornando posição do paciente {dto.PacienteId} na fila da consulta {dto.PacienteId}");
            try
            {
                var dbRedis = this.redisConnection.GetDatabase();
                var keyFila = ConfigRedis.GetKeyFila(dto.AgendaID, dto.AgendaData, dto.EstabelecimentoId, dto.ProfissionalId);
                var score = await dbRedis.SortedSetScoreAsync(keyFila, dto.PacienteId);
                if (!score.HasValue)
                {
                    this.logger?.LogWarning($"[ClinicMotorPaciente - RetornaPosicaoPacienteNaFila] Paciente {dto.PacienteId} não encontrado na fila da consulta {dto.PacienteId}");
                    return (-1, 0);
                }
                var posicao = await dbRedis.SortedSetRankAsync(keyFila, dto.PacienteId, Order.Descending);
                if (!posicao.HasValue)
                {
                    this.logger?.LogWarning($"[ClinicMotorPaciente - RetornaPosicaoPacienteNaFila] Paciente {dto.PacienteId} não encontrado na fila da consulta {dto.PacienteId}");
                    return (-1, score.Value);
                }
                var posicaoReal = (int)posicao.Value + 1; // Rank é zero-based
                this.logger?.LogInformation($"[ClinicMotorPaciente - RetornaPosicaoPacienteNaFila] Paciente {dto.PacienteId} está na posição {posicaoReal} na fila da consulta {dto.PacienteId} com score {score.Value}");
                return (posicaoReal, score.Value);
            }
            catch (Exception)
            {
                throw;
            }
        }



        #region PRIVATE METHODS



        private static async Task<double?> CalculaDistanciaEntreLocalPacienteEClinica(DtoDadosPrincipaisPaciente dto, IDatabase dbRedis)
        {
            return await dbRedis.GeoDistanceAsync(
                    ConfigRedis.STR_LOCALIZACOES,
                    $"{ConfigRedis.MBR_LOCALIZACAO_PACIENTES_MEMBRO}{dto.PacienteId}",
                    $"{ConfigRedis.MBR_LOCALIZACAO_CLINICA_MEMBRO}{dto.EstabelecimentoId}",
                    StackExchange.Redis.GeoUnit.Meters
                );
        }

        private static async Task AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(DtoDadosPrincipaisPaciente dto, IDatabase dbRedis)
        {
            await dbRedis.GeoAddAsync(
                                $"{ConfigRedis.STR_LOCALIZACOES}",
                                dto.Longitude,
                                dto.Latitude,
                                $"{ConfigRedis.MBR_LOCALIZACAO_PACIENTES_MEMBRO}{dto.PacienteId}");
        }


        private static async Task AtualizaDicionarioDadosDaConsultaAtual(
          DtoDadosPrincipaisPaciente dto,
          IDatabase dbRedis,
          double? distanciaAteClinica,
          double tempoAteClinica)
        {
            var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(dto.AgendaData, dto.AgendaID, dto.EstabelecimentoId, dto.ProfissionalId, dto.PacienteId);

            await dbRedis.HashSetAsync(keyPaciente, new HashEntry[]
              {
                    new HashEntry("distanciaClinica_Metros", distanciaAteClinica ?? 0),
                    new HashEntry("tempoChegada_Minutos", tempoAteClinica),
                    new HashEntry("velocidadeAtual_KMH", dto.VelocidadeAtualPaciente * 3.6),
                    new HashEntry("ultimaAtualizacaoLoc", DateTime.UtcNow.ToString("O"))
              });
        }




        #endregion
    }
}
