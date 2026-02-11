//using CSCore.ClinicTime.Motor.Paciente;
//using CSCore.ClinicTime.Motor.Paciente.dto;
//using CSCore.Redis;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.Json;

//namespace CSCore.ClinicTime.Motor.BackgroundServices
//{

//    public sealed class PacienteAguardandoAtendimentoBackgroundService : BackgroundService
//    {
//        private static readonly TimeOnly HORARIO_INICIO = new(8, 0);   // 08:00
//        private static readonly TimeOnly HORARIO_FIM = new(20, 0);     // 20:00
//        private const int INTERVALO_EXECUCAO_MINUTOS = 1;

//        private readonly IServiceProvider serviceProvider;
//        private readonly ILogger<PacienteAguardandoAtendimentoBackgroundService> logger;

//        public PacienteAguardandoAtendimentoBackgroundService(IServiceProvider serviceProvider, ILogger<PacienteAguardandoAtendimentoBackgroundService> logger)
//        {
//            this.serviceProvider = serviceProvider;
//            this.logger = logger;
//        }

//        /// <summary>
//        /// Esse metodo aumenta a prioridade gradativamente conforme o paciente esta aguardando atendimento por muito tempo
//        /// </summary>
//        /// <param name="stoppingToken"></param>
//        /// <returns></returns>
//        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//        {
//            this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Iniciando serviço de verificação de pacientes aguardando atendimento.");

//            while (!stoppingToken.IsCancellationRequested)
//            {
//                try
//                {
//                    var agora = DateTime.UtcNow.AddHours(-3); // Ajuste para o fuso horário local
//                    var horarioAtual = TimeOnly.FromDateTime(agora);

//                    // Verifica se está fora do horário de operação
//                    if (horarioAtual < HORARIO_INICIO || horarioAtual >= HORARIO_FIM)
//                    {
//                        var proximoHorario = CalcularProximoInicioOperacao(agora);
//                        var tempoEspera = proximoHorario - agora;

//                        this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Fora do horário de operação. Próxima execução às {ProximoHorario}. Aguardando {TempoEspera}...",
//                            proximoHorario.ToString("dd/MM/yyyy HH:mm:ss"),
//                            FormatarTempoEspera(tempoEspera));

//                        await Task.Delay(tempoEspera, stoppingToken);
//                        continue;
//                    }

//                    this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Executando verificação às {Horario}", agora.ToString("HH:mm:ss"));

//                    using var scope = this.serviceProvider.CreateScope();
//                    var redis = scope.ServiceProvider.GetRequiredService<IRedisConnection>();
//                    var motorPaciente = scope.ServiceProvider.GetRequiredService<IClinicTimeMotorPaciente>();
//                    var db = redis.GetDatabase();

//                    var pacientesAguardando = await db.SetMembersAsync(ConfigRedis.GetKeyJobsBackgroundPacienteAguardando(DateOnly.FromDateTime(DateTime.UtcNow.Date)));

//                    if (pacientesAguardando.Length == 0)
//                    {
//                        this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Nenhum paciente aguardando processamento.");
//                    }
//                    else
//                    {
//                        this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] {Count} paciente(s) aguardando processamento.", pacientesAguardando.Length);

//                        foreach (var paciente in pacientesAguardando)
//                        {
//                            try
//                            {
//                                var dados = JsonSerializer.Deserialize<DtoDadosPrincipaisPaciente>(paciente.ToString());

//                                if (dados is null)
//                                {
//                                    this.logger.LogWarning("[PacienteAguardandoAtendimentoBackgroundService] Dados do paciente inválidos: {Paciente}", paciente);
//                                    continue;
//                                }

//                                this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Processando paciente {PacienteID} da agenda {AgendaID}", dados.PacienteId, dados.AgendaID);

//                                var (sucesso, mensagem) = await motorPaciente.PacienteEstaNoLocalMasAindaNaoFoiAtendido_AumetandoOTempoNoLocalParaDefinirANovaPrioridade(dados);

//                                if (!sucesso)
//                                    this.logger.LogWarning("[PacienteAguardandoAtendimentoBackgroundService] Falha ao processar paciente {PacienteID}: {Mensagem}", dados.PacienteId, mensagem);

//                                await RemovePacienteCasoAConsultaTenhaIniciado(db, paciente, dados);
//                            }
//                            catch (Exception ex)
//                            {
//                                this.logger.LogError(ex, "[PacienteAguardandoAtendimentoBackgroundService] Erro ao processar paciente: {Paciente}", paciente);
//                            }
//                        }
//                    }

//                    await Task.Delay(TimeSpan.FromMinutes(INTERVALO_EXECUCAO_MINUTOS), stoppingToken);
//                }
//                catch (Exception ex)
//                {
//                    this.logger.LogError(ex, "[PacienteAguardandoAtendimentoBackgroundService] Erro no ciclo de execução do serviço.");
//                    await Task.Delay(TimeSpan.FromMinutes(INTERVALO_EXECUCAO_MINUTOS), stoppingToken);
//                }
//            }

//            this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Serviço de verificação de pacientes aguardando finalizado.");
//        }

//        private async Task RemovePacienteCasoAConsultaTenhaIniciado(StackExchange.Redis.IDatabase db, StackExchange.Redis.RedisValue paciente, DtoDadosPrincipaisPaciente dados)
//        {
//            await db.HashGetAllAsync(ConfigRedis.GetKeyDadosPacientePorAgendaMedica(
//                dados.AgendaData,
//                dados.AgendaID,
//                dados.EstabelecimentoId,
//                dados.ProfissionalId,
//                dados.PacienteId
//            )).ContinueWith(hashTask =>
//            {
//                var hashEntries = hashTask.Result;
//                var statusAtendimento = hashEntries.FirstOrDefault(e => e.Name == "paciente_em_consulta").Value.ToString();
//                if (statusAtendimento == "true" || statusAtendimento == "1")
//                {
//                    db.SetRemoveAsync(
//                        ConfigRedis.GetKeyJobsBackgroundPacienteAguardando(dados.AgendaData),
//                        paciente
//                    );
//                    this.logger.LogInformation("[PacienteAguardandoAtendimentoBackgroundService] Paciente {PacienteID} iniciou atendimento. Removido da fila de verificação.", dados.PacienteId);
//                }
//            });
//        }

//        private static DateTime CalcularProximoInicioOperacao(DateTime agora)
//        {
//            var hoje = DateOnly.FromDateTime(agora);
//            var horarioAtual = TimeOnly.FromDateTime(agora);

//            // Se ainda não chegou na hora de início hoje, retorna o início de hoje
//            if (horarioAtual < HORARIO_INICIO)
//            {
//                return hoje.ToDateTime(HORARIO_INICIO);
//            }

//            // Caso contrário, retorna o início de amanhã
//            var amanha = hoje.AddDays(1);
//            return amanha.ToDateTime(HORARIO_INICIO);
//        }

//        private static string FormatarTempoEspera(TimeSpan tempo)
//        {
//            if (tempo.TotalHours >= 1)
//                return $"{(int)tempo.TotalHours}h {tempo.Minutes}min";

//            if (tempo.TotalMinutes >= 1)
//                return $"{(int)tempo.TotalMinutes}min {tempo.Seconds}s";

//            return $"{(int)tempo.TotalSeconds}s";
//        }
//    }
//}