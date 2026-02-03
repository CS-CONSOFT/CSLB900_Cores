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
        Task<double> AtualizarLocalizacao(DtoAtualizaLocPaciente dtoAtualizaLocPaciente);
    }
    #endregion


    public class ClinicTimeMotorPaciente : IClinicTimeMotorPaciente
    {
        private const double LAT_MOCK_CS = -1.4364263147359764;
        private const double LONG_MOCK_CS = -48.45746371713742;
        private IRedisConnection redisConnection;
        private ILogger<ClinicTimeMotorPaciente>? logger;

        public ClinicTimeMotorPaciente(IRedisConnection redisConnection, ILogger<ClinicTimeMotorPaciente>? logger = null)
        {
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
        public async Task<double> AtualizarLocalizacao(DtoAtualizaLocPaciente dto)
        {
            this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizarLocalizacao] Atualizando localização do paciente {dto.PacienteId} para Lat: {dto.Latitude} Long: {dto.Longitude}");
            try
            {
                var dbRedis = this.redisConnection.GetDatabase();

                await AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(dto, dbRedis);

                this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizarLocalizacao] Localização do paciente {dto.PacienteId} atualizada com sucesso no Redis.");

                /*ISSO AQUI DEVE SAIR DAQUI, FOI PRA TESTE, DEVE SER SALVO AO REGISTRAR UM ESTABELECIMENTO E FICAR ETERNAMENTE SALVO*/
                await dbRedis.GeoAddAsync(
                   CHAVES_REDIS.STR_LOCALIZACOES,
                   LAT_MOCK_CS,
                   LONG_MOCK_CS,
                   $"{CHAVES_REDIS.MBR_LOCALIZACAO_CLINICA_MEMBRO}{dto.EstabelecimentoId}");

                double? distanciaAteClinica = await CalculaDistanciaEntreLocalPacienteEClinica(dto, dbRedis);

                this.logger?.LogInformation($"[ClinicMotorPaciente - AtualizarLocalizacao] Distância do paciente {dto.PacienteId} até o estabelecimento {dto.EstabelecimentoId} é de {distanciaAteClinica} metros.");

                var tempoAteClinica = CalcularTempoAteLocal.Calcular((distanciaAteClinica ?? 0) * 1000, dto.VelocidadeAtualPaciente);

                await AtualizaDicionarioDadosDaConsultaAtual(dto, dbRedis, distanciaAteClinica, tempoAteClinica);

                await CalcularPrioridadeDaFila.RecalcularPrioridadeConsulta(dbRedis, dto);

                return tempoAteClinica;
            }
            catch (Exception)
            {

                throw;
            }
        }



        #region PRIVATE METHODS

    

        private static async Task<double?> CalculaDistanciaEntreLocalPacienteEClinica(DtoAtualizaLocPaciente dto, IDatabase dbRedis)
        {
            return await dbRedis.GeoDistanceAsync(
                    CHAVES_REDIS.STR_LOCALIZACOES,
                    $"{CHAVES_REDIS.MBR_LOCALIZACAO_PACIENTES_MEMBRO}{dto.PacienteId}",
                    $"{CHAVES_REDIS.MBR_LOCALIZACAO_CLINICA_MEMBRO}{dto.EstabelecimentoId}",
                    StackExchange.Redis.GeoUnit.Meters
                );
        }

        private static async Task AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(DtoAtualizaLocPaciente dto, IDatabase dbRedis)
        {
            await dbRedis.GeoAddAsync(
                                $"{CHAVES_REDIS.STR_LOCALIZACOES}",
                                dto.Longitude,
                                dto.Latitude,
                                $"{CHAVES_REDIS.MBR_LOCALIZACAO_PACIENTES_MEMBRO}{dto.PacienteId}");
        }


        private static async Task AtualizaDicionarioDadosDaConsultaAtual(
          DtoAtualizaLocPaciente dto,
          IDatabase dbRedis,
          double? distanciaAteClinica,
          double tempoAteClinica)
        {
            var keyPaciente =
                $"{CHAVES_REDIS.STR_CONSULTA}Estabelecimentos:{dto.EstabelecimentoId}:" +
                $"Profissionais:{dto.ProfissionalId}:PacientesDados:{dto.PacienteId}";   

            await dbRedis.HashSetAsync(
                keyPaciente,
                new HashEntry[]
                {
            new("pacientePcd", true),
            new("pacienteIdoso", false),
            new("pacienteGestante", false),
            new("checkIn", true),
            new("checkInNoLocal", false),
            new("distanciaClinica", distanciaAteClinica ?? 0),
            new("tempoChegada", tempoAteClinica),
            new("velocidadeAtual", dto.VelocidadeAtualPaciente),
            new("ultimaAtualizacaoLoc", DateTime.UtcNow.ToString("O"))
                }
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
