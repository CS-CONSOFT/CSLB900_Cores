using CLT200APIClinicTime.Controllers.Motor;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.Redis;
using CSLB900.MSTools.Calculos.Distancia;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace CSCore.ClinicTime.Motor.Paciente
{
    #region INTERFACES
    public interface IClinicTimeMotorPaciente
    {
        /// <summary>
        /// Esse método é responsável por marcar a presença do paciente no local da consulta.
        /// </summary>
        void MarcarPresencaNoLocal();

        /// <summary>
        /// Esse método é responsável por fazer com que o paciente faça chekin, afirmando que irá para a consulta.
        /// Ele é um pré requisito para MarcarPresencaNoLocal
        /// </summary>
        void RealizarCheckInPrevio();

        void PacienteMarcarDesistencia();

        /// <summary>
        /// Esse método é responsável por atualizar a localização do paciente. A cada 30-60 segundos ou mudança > 50 metros
        /// </summary>
        Task<double> AtualizarLocalizacao(DtoDadosPrincipaisPaciente dtoAtualizaLocPaciente);

        /// <summary>
        /// Retorna a posição atual do paciente na fila e o score de prioridade
        /// </summary>
        /// <param name="dtoAtualizaLocPaciente"></param>
        /// <returns></returns>
        Task<(int, double)> RetornaPosicaoPacienteNaFila(DtoDadosPrincipaisPaciente dtoAtualizaLocPaciente);
    }
    #endregion


    public class ClinicTimeMotorPaciente : IClinicTimeMotorPaciente
    {
        private const double LAT_MOCK_CS = -1.4364263147359764;
        private const double LONG_MOCK_CS = -48.45746371713742;
        private IRedisConnection redisConnection;
        private ILogger<ClinicTimeMotorPaciente>? logger;
        private IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente;


        public ClinicTimeMotorPaciente(IRedisConnection redisConnection, IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente, ILogger<ClinicTimeMotorPaciente>? logger = null)
        {
            this.recuperaDadosDaConsultaDoPaciente = recuperaDadosDaConsultaDoPaciente;
            this.redisConnection = redisConnection;
            this.logger = logger;
        }



        /// <summary>
        /// Esse método é responsável por marcar a presença do paciente no local da consulta.
        /// </summary>
        public void MarcarPresencaNoLocal()
        {
            throw new NotImplementedException();
        }

        public void MedicoSolicitaTempoExtraNaConsulta()
        {
            throw new NotImplementedException();
        }

        public void PacienteMarcarDesistencia()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Esse método é responsável por fazer com que o paciente faça chekin, afirmando que irá para a consulta.
        /// Ele é um pré requisito para MarcarPresencaNoLocal
        /// </summary>
        public void RealizarCheckInPrevio()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Esse método é responsável por atualizar a localização do paciente. A cada 30-60 segundos ou mudança > 50 metros
        /// </summary>
        public async Task<double> AtualizarLocalizacao(DtoDadosPrincipaisPaciente dto)
        {
            try
            {
                var dbRedis = this.redisConnection.GetDatabase();

                await AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(dto, dbRedis);

                this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizarLocalizacao] Localização do paciente {dto.PacienteId} atualizada com sucesso no Redis.");

                /*ISSO AQUI DEVE SAIR DAQUI, FOI PRA TESTE, DEVE SER SALVO AO REGISTRAR UM ESTABELECIMENTO E FICAR ETERNAMENTE SALVO*/
                await dbRedis.GeoAddAsync(
                   ConfigRedis.STR_LOCALIZACOES,
                   LONG_MOCK_CS,
                   LAT_MOCK_CS,
                   $"{ConfigRedis.MBR_LOCALIZACAO_CLINICA_MEMBRO}{dto.EstabelecimentoId}");

                double? distanciaAteClinica = await CalculaDistanciaEntreLocalPacienteEClinica(dto, dbRedis);

                this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizarLocalizacao] Distância do paciente {dto.PacienteId} até o estabelecimento {dto.EstabelecimentoId} é de {distanciaAteClinica} metros.");

                var tempoAteClinica = CalcularTempoAteLocal.Calcular((distanciaAteClinica ?? 0) * 1000, dto.VelocidadeAtualPaciente);

                this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizarLocalizacao] Tempo do paciente {dto.PacienteId} até o estabelecimento {dto.EstabelecimentoId} é de {tempoAteClinica} metros.");

                await AtualizaDicionarioDadosDaConsultaAtual(dto, dbRedis, distanciaAteClinica, tempoAteClinica);

                this.logger?.LogInformation("Recalculando prioridade da fila para o paciente {PacienteId}", dto.PacienteId);
                await CalcularPrioridadeDaFila.RecalcularPrioridadeConsultaAtualizandoNoRedis(this.recuperaDadosDaConsultaDoPaciente, dbRedis, dto, this.logger);

                return tempoAteClinica;
            }
            catch (Exception)
            {
                throw;
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
            var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(dto.AgendaData,dto.AgendaID,dto.EstabelecimentoId, dto.ProfissionalId, dto.PacienteId);

            await dbRedis.HashSetAsync(
                keyPaciente,
                ConfigRedis.CriaEstruturaDeDadosDoPacienteDeUmaConsulta(
                        dto.PacientePCD,
                        dto.PacienteIdoso,
                        dto.PacienteGestante,
                        dto.PacienteIsChekinLocal,
                        dto.PacienteIsChekinApp,
                        (distanciaAteClinica ?? 0),
                        tempoAteClinica,
                        (dto.VelocidadeAtualPaciente * 3.6)
                    )
            );
        }

        private void AjustarProximaConsulta()
        {
            throw new NotImplementedException();
        }

        private void RecalcularFila()
        {
            throw new NotImplementedException();
        }

        private void NotificarMudancaDaFila()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
