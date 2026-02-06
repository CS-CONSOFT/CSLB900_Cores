using CSCore.ClinicTime.Motor.Paciente;
using CSCore.Redis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CSCore.ClinicTime.Motor.BackgroundServices
{
    record DadosProcessamento(
            DateOnly AgendaData,
            string ProfissionalId,
            string AgendaID,
            string EstabID,
            string PacienteID
        );

    public sealed class PacienteBackgroundService : BackgroundService
    {
        private static readonly TimeOnly HORARIO_INICIO = new(8, 0);   // 08:00
        private static readonly TimeOnly HORARIO_FIM = new(20, 0);     // 20:00
        private const int INTERVALO_EXECUCAO_MINUTOS = 1;

        private readonly IServiceProvider serviceProvider;
        private readonly ILogger<PacienteBackgroundService> logger;

        public PacienteBackgroundService(IServiceProvider serviceProvider, ILogger<PacienteBackgroundService> logger)
        {
            this.serviceProvider = serviceProvider;
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this.logger.LogInformation("[PacienteBackgroundService] Iniciando serviço de verificação de pacientes aguardando.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var agora = DateTime.Now;
                    var horarioAtual = TimeOnly.FromDateTime(agora);

                    // Verifica se está fora do horário de operação
                    if (horarioAtual < HORARIO_INICIO || horarioAtual >= HORARIO_FIM)
                    {
                        var proximoHorario = CalcularProximoInicioOperacao(agora);
                        var tempoEspera = proximoHorario - agora;

                        this.logger.LogInformation("[PacienteBackgroundService] Fora do horário de operação. Próxima execução às {ProximoHorario}. Aguardando {TempoEspera}...",
                            proximoHorario.ToString("dd/MM/yyyy HH:mm:ss"),
                            FormatarTempoEspera(tempoEspera));

                        await Task.Delay(tempoEspera, stoppingToken);
                        continue;
                    }

                    this.logger.LogInformation("[PacienteBackgroundService] Executando verificação às {Horario}", agora.ToString("HH:mm:ss"));

                    using var scope = this.serviceProvider.CreateScope();
                    var redis = scope.ServiceProvider.GetRequiredService<IRedisConnection>();
                    var motorPaciente = scope.ServiceProvider.GetRequiredService<IClinicTimeMotorPaciente>();
                    var db = redis.GetDatabase();

                    var pacientesAguardando = await db.ListRangeAsync(ConfigRedis.GetKeyJobsBackgroundPacienteAguardando(DateOnly.FromDateTime(DateTime.UtcNow.Date)));

                    if (pacientesAguardando.Length == 0)
                    {
                        this.logger.LogInformation("[PacienteBackgroundService] Nenhum paciente aguardando processamento.");
                    }
                    else
                    {
                        this.logger.LogInformation("[PacienteBackgroundService] {Count} paciente(s) aguardando processamento.", pacientesAguardando.Length);

                        foreach (var paciente in pacientesAguardando)
                        {
                            try
                            {
                                var dados = JsonSerializer.Deserialize<DadosProcessamento>(paciente.ToString());

                                if (dados is null)
                                {
                                    this.logger.LogWarning("[PacienteBackgroundService] Dados do paciente inválidos: {Paciente}", paciente);
                                    continue;
                                }

                                this.logger.LogInformation("[PacienteBackgroundService] Processando paciente {PacienteID} da agenda {AgendaID}", dados.PacienteID, dados.AgendaID);

                                var (sucesso, mensagem) = await motorPaciente.PacienteEstaNoLocalMasAindaNaoFoiAtendido_AumetandoOTempoNoLocalParaDefinirANovaPrioridade(
                                    dados.AgendaData,
                                    dados.ProfissionalId,
                                    dados.AgendaID,
                                    dados.EstabID,
                                    dados.PacienteID
                                );

                                if (!sucesso)
                                    this.logger.LogWarning("[PacienteBackgroundService] Falha ao processar paciente {PacienteID}: {Mensagem}", dados.PacienteID, mensagem);

                                /*QUANDO O PACIENTE TIVER O ATENDIMENTO INCIADO, DEVE REMOVER ELE DA FILA ConfigRedis.GetKeyJobsBackgroundPacienteAguardando*/

                            }
                            catch (Exception ex)
                            {
                                this.logger.LogError(ex, "[PacienteBackgroundService] Erro ao processar paciente: {Paciente}", paciente);
                            }
                        }
                    }

                    await Task.Delay(TimeSpan.FromMinutes(INTERVALO_EXECUCAO_MINUTOS), stoppingToken);
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "[PacienteBackgroundService] Erro no ciclo de execução do serviço.");
                    await Task.Delay(TimeSpan.FromMinutes(INTERVALO_EXECUCAO_MINUTOS), stoppingToken);
                }
            }

            this.logger.LogInformation("[PacienteBackgroundService] Serviço de verificação de pacientes aguardando finalizado.");
        }

        private static DateTime CalcularProximoInicioOperacao(DateTime agora)
        {
            var hoje = DateOnly.FromDateTime(agora);
            var horarioAtual = TimeOnly.FromDateTime(agora);

            // Se ainda não chegou na hora de início hoje, retorna o início de hoje
            if (horarioAtual < HORARIO_INICIO)
            {
                return hoje.ToDateTime(HORARIO_INICIO);
            }

            // Caso contrário, retorna o início de amanhã
            var amanha = hoje.AddDays(1);
            return amanha.ToDateTime(HORARIO_INICIO);
        }

        private static string FormatarTempoEspera(TimeSpan tempo)
        {
            if (tempo.TotalHours >= 1)
                return $"{(int)tempo.TotalHours}h {tempo.Minutes}min";

            if (tempo.TotalMinutes >= 1)
                return $"{(int)tempo.TotalMinutes}min {tempo.Seconds}s";

            return $"{(int)tempo.TotalSeconds}s";
        }
    }
}