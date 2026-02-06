using CLT200APIClinicTime.Controllers.Motor;
using CLT900DbCore.CSCore.Domain.ModelDBClinicTime;
using CSCore.ClinicTime.Motor.EntidadesMock;
using CSCore.ClinicTime.Motor.Eventos;
using CSCore.ClinicTime.Motor.Paciente;
using CSCore.ClinicTime.Motor.Paciente.dto;
using CSCore.Redis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace CSCore.ClinicTime.Motor.Sincronizacao
{
    public interface IClinicSyncMSSQLRedis
    {
        Task SincronizarMSSQL_Redis();
        Task SincronizarRedis_MSSQL();
    }
    public class ClinicSyncMSSQLRedis : IClinicSyncMSSQLRedis
    {
        private readonly AppDbContext appDbContext;
        private readonly IRedisConnection redisConnection;
        private ILogger<ClinicSyncMSSQLRedis>? logger;
        private IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente;

        public ClinicSyncMSSQLRedis(AppDbContext appDbContext, IRedisConnection redisConnection, ILogger<ClinicSyncMSSQLRedis> logger, IRecuperaDadosDaConsultaDoPacienteDoRedis recuperaDadosDaConsultaDoPaciente)
        {
            this.recuperaDadosDaConsultaDoPaciente = recuperaDadosDaConsultaDoPaciente; 
            this.appDbContext = appDbContext;
            this.redisConnection = redisConnection;
            this.logger = logger;

        }

        /// <summary>
        /// Isso deve ser executado em background sempre que uma agenda for finalizada. Pode ser executado a meia noite, ou sempre
        /// que o botao finalizar agenda for apertado. Caso alguma alteração seja feita na agenda, a acao deve ser executada novamente
        /// </summary>
        /// <returns></returns>
        public async Task SincronizarMSSQL_Redis()
        {
            var redisDb = this.redisConnection.GetDatabase();
            var query = from agenda in appDbContext.Sph015Agendas
                            //where agenda.Data == DateOnly.FromDateTime(DateTime.UtcNow)

                        join estabelecimento in appDbContext.Sph011Estabelecimentos
                        on agenda.EstabelecimentoId equals estabelecimento.EstabelecimentoId into agendaEstabGroup
                        from estabelecimento in agendaEstabGroup.DefaultIfEmpty()

                        join profissional in appDbContext.Sph012Profissionais
                        on agenda.ProfissionalId equals profissional.ProfissionalId into agendaProfGroup
                        from profissional in agendaProfGroup.DefaultIfEmpty()

                        let consultas = (from consulta in appDbContext.Sph014Consultas
                                         where consulta.AgendaId == agenda.AgendaId

                                         join paciente in appDbContext.Sph010Pacientes
                                         on consulta.PacienteId equals paciente.PacienteId into consultaPacGroup
                                         from paciente in consultaPacGroup.DefaultIfEmpty()

                                         select new
                                         {
                                             consulta.ConsultaId,
                                             consulta.PacienteId,
                                             paciente
                                         }).ToList()

                        select new
                        {
                            agenda.AgendaId,
                            agenda.EstabelecimentoId,
                            agenda.Data,
                            EstabelecimentoNome = estabelecimento != null ? estabelecimento.Nome : null,
                            agenda.ProfissionalId,
                            ProfissionalNome = profissional != null ? profissional.Nome : null,
                            Consultas = consultas
                        };

            query = query.AsNoTracking();
            var resultados = await query.ToListAsync();

            this.logger?.LogInformation($"[ClinicSyncMSSQLRedis - SincronizarMSSQL_Redis] Iniciando sincronização de {resultados.Count} agendas do MSSQL para o Redis.");

            var resultado_achatado = resultados.SelectMany(
                        agenda => agenda.Consultas,
                        (agenda, consulta) => new
                        {
                            agenda.AgendaId,
                            agenda.Data,
                            agenda.EstabelecimentoId,
                            agenda.EstabelecimentoNome,
                            agenda.ProfissionalId,
                            agenda.ProfissionalNome,
                            consulta.ConsultaId,
                            Paciente = consulta.paciente
                        }
                    );


            var options = new ParallelOptions { MaxDegreeOfParallelism = -1 };
            await Parallel.ForEachAsync(resultado_achatado, options, async (agenda, cancellationToken) =>
            {
                cancellationToken.ThrowIfCancellationRequested();

                var keyDiaAnterior = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                    DateOnly.FromDateTime(DateTime.UtcNow).AddDays(-1),
                    agenda.AgendaId,
                    agenda.EstabelecimentoId,
                    agenda.ProfissionalId,
                    agenda.Paciente.PacienteId);


                if (DataDaAgendaEhIgualADataDeOntem(agenda.Data))
                {
                    await RemoveAgendaDoDiaAnterior(redisDb, keyDiaAnterior);
                    return;
                }

                var key = ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
                    agenda.Data,
                    agenda.AgendaId,
                    agenda.EstabelecimentoId,
                    agenda.ProfissionalId,
                    agenda.Paciente.PacienteId);

                await redisDb.HashSetAsync(
                    key,
                    ConfigRedis.CriaEstruturaDeDadosDoPacienteDeUmaConsulta(
                        isPcd: false,
                        isIdoso: true,
                        isGestante: false,
                        isCheckinApp: false,
                        isCheckinLocal: false,
                        distanciaAteClinica: -1,
                        tempoAteClinica: -1,
                        velocidadeAtual: 0
                    )
                );

                var dto = new DtoDadosPrincipaisPaciente(
                    agenda.AgendaId,
                    agenda.Data,
                    agenda.Paciente.PacienteId,
                    agenda.ProfissionalId,
                    //agenda.ConsultaId,
                    agenda.EstabelecimentoId,
                    latitude: 0,
                    longitude: 0,
                    VelocidadeAtualPaciente: 0);

                await CalcularPrioridadeDaFila.InserePacienteNaFilaNoRedis(recuperaDadosDaConsultaDoPaciente, redisDb, dto);
                await AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(dto, redisDb);

            });
        }

        private static async Task AtualizaLocalizacaoPacienteNaEstruturaDeGeolocalizacaoRedis(DtoDadosPrincipaisPaciente dto, IDatabase dbRedis)
        {
            await dbRedis.GeoAddAsync(
                                $"{ConfigRedis.STR_LOCALIZACOES}",
                                dto.Longitude,
                                dto.Latitude,
                                $"{ConfigRedis.MBR_LOCALIZACAO_PACIENTES_MEMBRO}{dto.PacienteId}");
        }

        private static async Task RemoveAgendaDoDiaAnterior(IDatabase redisDb, string keyDiaAnterior)
        {
            await redisDb.KeyDeleteAsync(keyDiaAnterior);
        }

        private static bool DataDaAgendaEhIgualADataDeOntem(DateOnly DATA_AGENDA)
        {
            return DATA_AGENDA == DateOnly.FromDateTime(DateTime.UtcNow).AddDays(-1);
        }


        public async Task SincronizarRedis_MSSQL()
        {

        }
    }
}
