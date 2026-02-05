using CSCore.Redis;
using StackExchange.Redis;

namespace CSCore.ClinicTime.Motor.Paciente
{
    public interface IRecuperaDadosDaConsultaDoPacienteDoRedis
    {
        Task<Dictionary<string, string>> RetornaDadosConsultaPaciente(
            string PacienteId,
            DateOnly AgendaData,
            string AgendaID,
            string EstabelecimentoId,
            string ProfissionalId);

        Task<Dictionary<string, string>> RetornaLatLongDaClinicaQueOPacienteVaiSerAtendidoNessaAgenda(string EstabelecimentoId);
    }

    public sealed class RecuperaDadosDaConsultaDoPacienteDoRedis : IRecuperaDadosDaConsultaDoPacienteDoRedis
    {
        private readonly IRedisConnection _redisConnection; 

        public RecuperaDadosDaConsultaDoPacienteDoRedis(IRedisConnection redisConnection) 
        {
            _redisConnection = redisConnection;
        }

        public async Task<Dictionary<string, string>> RetornaDadosConsultaPaciente(
            string PacienteId,
            DateOnly AgendaData,
            string AgendaID,
            string EstabelecimentoId,
            string ProfissionalId)
        {
            var dbRedis = _redisConnection.GetDatabase(); 

            var keyPaciente = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                AgendaData,
                AgendaID,
                EstabelecimentoId,
                ProfissionalId,
                PacienteId);

            var dadosConsultaPaciente = await dbRedis.HashGetAllAsync(keyPaciente);

            if (dadosConsultaPaciente.Length == 0)
                return [];

            var dict = dadosConsultaPaciente.ToDictionary(
                he => he.Name.ToString(),
                he => he.Value.ToString()
            );

            GeoPosition? latLongClinica = await dbRedis.GeoPositionAsync(
                ConfigRedis.STR_LOCALIZACOES,
                ConfigRedis.MBR_LOCALIZACAO_CLINICA_MEMBRO + EstabelecimentoId);

            dict.Add("ClinicaLatitude", latLongClinica?.Latitude.ToString() ?? string.Empty);
            dict.Add("ClinicaLongitude", latLongClinica?.Longitude.ToString() ?? string.Empty);


            return dict;
        }

        public async Task<Dictionary<string, string>> RetornaLatLongDaClinicaQueOPacienteVaiSerAtendidoNessaAgenda(string EstabelecimentoId)
        {
            var dbRedis = _redisConnection.GetDatabase();

            var dict = new Dictionary<string, string>();

            GeoPosition? latLongClinica = await dbRedis.GeoPositionAsync(
                ConfigRedis.STR_LOCALIZACOES,
                ConfigRedis.MBR_LOCALIZACAO_CLINICA_MEMBRO + EstabelecimentoId);

            dict.Add("ClinicaLatitude", latLongClinica?.Latitude.ToString() ?? string.Empty);
            dict.Add("ClinicaLongitude", latLongClinica?.Longitude.ToString() ?? string.Empty);


            return dict;
        }
    }
}