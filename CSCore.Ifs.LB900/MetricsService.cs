using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CSCore.Ifs.LB900
{
    public interface IMetricsService
    {
        Task StartAsync(CancellationToken cancellationToken);
    }

    /// <summary>
    /// Serviço para coletar e logar métricas de saúde do processo (CPU, Memória, Threads) em um arquivo CSV.
    /// É compatível com ambientes Linux e Windows, e tenta calcular a CPU de forma mais robusta.
    /// </summary>
    public class MetricsService : IMetricsService, IDisposable, IHostedService
    {
        // Variáveis e Constantes
        private const int LoggingIntervalSeconds = 30;
        private readonly string _logPath;
        private readonly Timer _timer;
        private readonly Process _process;
        private readonly ILogger<MetricsService> _logger;

        // Variáveis de estado para o cálculo da CPU
        private TimeSpan _lastCpuTime;
        private DateTime _lastCheck;
        private readonly int _cpuCores;
        private long _lastRefreshTimestamp; // Para controle de execução do timer

        // Propriedade para verificar se o serviço está rodando em Docker/Linux.
        // Em muitos ambientes Linux/Docker, TotalProcessorTime pode não ser preciso, mas é a melhor heurística simples.
        private static bool IsRunningOnUnix => Environment.OSVersion.Platform == PlatformID.Unix;

        public MetricsService(ILogger<MetricsService> logger)
        {
            _logger = logger;

            try
            {
                // 1. Definição e Criação do Caminho
                string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
                _logPath = Path.Combine(baseDir, "metrics_log.csv");

                _logger.LogInformation("Tentando criar diretório: {BaseDirectory}", baseDir);
                Directory.CreateDirectory(baseDir);

                // 2. Criação do Arquivo de Log
                if (!File.Exists(_logPath))
                {
                    _logger.LogInformation("Criando arquivo de log: {LogPath}", _logPath);
                    File.WriteAllText(_logPath, "Timestamp,GC(MB),WorkingSet(MB),Private(MB),CPU%,Threads\n");
                }
                else
                {
                    _logger.LogInformation("Arquivo de log já existe: {LogPath}", _logPath);
                }

                // 3. Inicialização do Processo e Métricas
                _process = Process.GetCurrentProcess();
                _cpuCores = Environment.ProcessorCount;

                // Inicialização das variáveis de cálculo da CPU
                _lastCpuTime = _process.TotalProcessorTime;
                _lastCheck = DateTime.UtcNow;

                // 4. Configuração do Timer
                // Usamos a flag ExecutionContext.SuppressFlow() para evitar vazamento de contexto
                // ao agendar o timer em uma task que não depende do contexto de execução.
                ExecutionContext.SuppressFlow();
                _timer = new Timer(async _ => await LogMetricsAsync(), null, Timeout.Infinite, Timeout.Infinite);
                ExecutionContext.RestoreFlow();

                _logger.LogInformation("MetricsService inicializado com sucesso. CPU Cores: {CpuCores}", _cpuCores);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao inicializar MetricsService");
                throw;
            }
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // O timer inicia a partir de agora e repete a cada LoggingIntervalSeconds
            _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(LoggingIntervalSeconds));
            _logger.LogInformation("Monitoramento iniciado. Intervalo: {IntervalSeconds}s", LoggingIntervalSeconds);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Coleta as métricas do processo atual, calcula o uso de CPU e grava no arquivo CSV.
        /// </summary>
        private async Task LogMetricsAsync()
        {
            // Implementação de "mutex" simples para prevenir execuções concorrentes do timer,
            // embora o Timer não deva disparar novamente antes do intervalo, é uma segurança extra.
            if (Interlocked.CompareExchange(ref _lastRefreshTimestamp, 1, 0) != 0)
            {
                _logger.LogWarning("Tentativa de execução concorrente ignorada");
                return;
            }

            try
            {
                // 1. Coleta de Dados
                _process.Refresh();

                // Métricas de Memória e Threads
                double gcMemMB = GC.GetTotalMemory(false) / 1024.0 / 1024.0;
                double workingMB = _process.WorkingSet64 / 1024.0 / 1024.0;
                double privateMB = _process.PrivateMemorySize64 / 1024.0 / 1024.0;
                int threads = _process.Threads.Count;

                // 2. Cálculo do Uso de CPU
                var now = DateTime.UtcNow;
                var cpuTime = _process.TotalProcessorTime;

                double cpuMs = (cpuTime - _lastCpuTime).TotalMilliseconds;
                double elapsedMs = (now - _lastCheck).TotalMilliseconds;

                double cpuPercent = 0;

                if (elapsedMs > 0)
                {
                    // A fórmula padrão calcula a porcentagem de uso do processador total
                    // (tempo gasto pelo processo / tempo total decorrido)
                    // Multiplicamos por _cpuCores para normalizar a porcentagem em relação
                    // ao número de núcleos disponíveis. Isso é crucial em ambientes Linux/Docker.
                    cpuPercent = (cpuMs / elapsedMs) * 100.0;
                }

                // 3. Atualização das Variáveis de Estado
                _lastCpuTime = cpuTime;
                _lastCheck = now;

                // 4. Geração e Gravação da Linha
                string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{gcMemMB:F2},{workingMB:F2},{privateMB:F2},{cpuPercent:F2},{threads}";

                // Usar Task.Run com FileStream/StreamWriter garante que a operação de IO não bloqueie o thread do Timer.
                await Task.Run(() =>
                {
                    // Usar FileShare.ReadWrite para permitir que o arquivo seja lido por outras ferramentas enquanto gravamos.
                    using (var stream = new FileStream(_logPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(line);
                    }
                });

                // 5. Log de Console (Opcional, a cada 30s)
                _logger.LogInformation("Métricas coletadas - CPU: {CpuPercent:F2}%, RAM: {WorkingMemoryMB:F2}MB, Threads: {ThreadCount}",
                    cpuPercent, workingMB, threads);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao gravar métricas");

                // Tenta gravar a linha de erro (sem precisar do bloco try-catch aninhado)
                try
                {
                    string errorLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},ERRO,-,-,-,-,-,{ex.Message.Replace(",", ";")}";
                    await Task.Run(() => File.AppendAllText(_logPath, errorLine + "\n"));
                }
                catch
                {
                    // Ignorar se não conseguir gravar o erro
                }
            }
            finally
            {
                // Libera o "mutex"
                Interlocked.Exchange(ref _lastRefreshTimestamp, 0);
            }
        }

        public void Dispose()
        {
            // Garante que o timer pare antes de ser descartado
            _timer?.Change(Timeout.Infinite, Timeout.Infinite);
            _timer?.Dispose();

            // Não é necessário descartar o processo, pois GetCurrentProcess() retorna uma referência.

            _logger.LogInformation("Encerrando serviço de métricas");
            GC.SuppressFinalize(this);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Recebido sinal para encerrar serviço de métricas");
            Dispose(); // Chama o método Dispose que para o Timer
            return Task.CompletedTask;
        }
    }
}