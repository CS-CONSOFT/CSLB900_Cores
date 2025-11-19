//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using System.Diagnostics;

//namespace CSCore.Ifs.LB900
//{
//    public interface IMetricsService
//    {
//        Task StartAsync(CancellationToken cancellationToken);
//    }

//    /// <summary>
//    /// Serviço para coletar e logar métricas de saúde do processo (CPU, Memória, Threads) em um arquivo CSV.
//    /// É compatível com ambientes Linux e Windows, e tenta calcular a CPU de forma mais robusta.
//    /// </summary>
//    public class MetricsService : IMetricsService, IDisposable, IHostedService
//    {
//        // Variáveis e Constantes
//        private const int LoggingIntervalSeconds = 30;
//        private readonly string _logPath;
//        private readonly Timer _timer;
//        private readonly Process _process;
//        private readonly ILogger<MetricsService> _logger;
//        private readonly IConfiguration _configuration;

//        // Variáveis de estado para o cálculo da CPU
//        private TimeSpan _lastCpuTime;
//        private DateTime _lastCheck;
//        private readonly int _cpuCores;
//        private long _lastRefreshTimestamp; // Para controle de execução do timer

//        // Propriedade para verificar se o serviço está rodando em Docker/Linux.
//        // Em muitos ambientes Linux/Docker, TotalProcessorTime pode não ser preciso, mas é a melhor heurística simples.
//        private static bool IsRunningOnUnix => Environment.OSVersion.Platform == PlatformID.Unix;

//        public MetricsService(ILogger<MetricsService> logger, IConfiguration configuration)
//        {
//            _logger = logger;
//            _configuration = configuration;

//            try
//            {
//                // 1. Definição e Criação do Caminho
//                // Prioridade: variável de ambiente > configuração > padrão
//                string baseDir = _configuration["MetricsService:LogPath"]
//                    ?? Environment.GetEnvironmentVariable("METRICS_LOG_PATH")
//                    ?? "/app/metrics";

//                // Se não for caminho absoluto, usar o diretório base da aplicação
//                if (!Path.IsPathRooted(baseDir))
//                {
//                    baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, baseDir);
//                }

//                _logPath = Path.Combine(baseDir, "metrics_log.csv");

//                _logger.LogInformation("=== INICIALIZAÇÃO DO METRICSSERVICE ===");
//                _logger.LogInformation("Sistema Operacional: {OS}", Environment.OSVersion);
//                _logger.LogInformation("Plataforma: {Platform}", IsRunningOnUnix ? "Unix/Linux" : "Windows");
//                _logger.LogInformation("Diretório Base da Aplicação: {BaseDirectory}", AppDomain.CurrentDomain.BaseDirectory);
//                _logger.LogInformation("Diretório de trabalho atual: {WorkingDirectory}", Directory.GetCurrentDirectory());
//                _logger.LogInformation("Diretório de Logs (configurado): {LogDirectory}", baseDir);
//                _logger.LogInformation("Caminho completo do arquivo: {LogPath}", _logPath);

//                // Verificar se o diretório existe ou pode ser criado
//                _logger.LogInformation("Verificando existência do diretório: {BaseDirectory}", baseDir);
//                bool dirExistsBefore = Directory.Exists(baseDir);
//                _logger.LogInformation("Diretório existe antes da criação: {DirExists}", dirExistsBefore);

//                // Tentar criar o diretório
//                _logger.LogInformation("Tentando criar diretório: {BaseDirectory}", baseDir);
//                Directory.CreateDirectory(baseDir);

//                // Verificar se foi criado com sucesso
//                bool dirExistsAfter = Directory.Exists(baseDir);
//                _logger.LogInformation("Diretório existe após criação: {DirExists}", dirExistsAfter);

//                if (!dirExistsAfter)
//                {
//                    throw new DirectoryNotFoundException($"Não foi possível criar ou acessar o diretório: {baseDir}");
//                }

//                // Testar permissões de escrita
//                try
//                {
//                    var testFile = Path.Combine(baseDir, $".test_write_{Guid.NewGuid()}.tmp");
//                    _logger.LogInformation("Testando permissão de escrita no diretório: {TestFile}", testFile);
//                    File.WriteAllText(testFile, "test");
//                    File.Delete(testFile);
//                    _logger.LogInformation("Teste de permissão de escrita: SUCESSO");
//                }
//                catch (Exception ex)
//                {
//                    _logger.LogError(ex, "Teste de permissão de escrita FALHOU no diretório: {BaseDirectory}", baseDir);
//                    throw new UnauthorizedAccessException($"Sem permissão de escrita no diretório: {baseDir}", ex);
//                }

//                // 2. Criação do Arquivo de Log
//                if (!File.Exists(_logPath))
//                {
//                    _logger.LogInformation("Arquivo de log não existe. Criando: {LogPath}", _logPath);

//                    try
//                    {
//                        File.WriteAllText(_logPath, "Timestamp,GC(MB),WorkingSet(MB),Private(MB),CPU%,Threads\n");
//                        _logger.LogInformation("Arquivo criado com sucesso");

//                        // Verificar se foi criado
//                        if (File.Exists(_logPath))
//                        {
//                            var fileInfo = new FileInfo(_logPath);
//                            _logger.LogInformation("Arquivo verificado - Tamanho: {FileSize} bytes, Criado em: {CreationTime}",
//                                fileInfo.Length, fileInfo.CreationTime);
//                        }
//                        else
//                        {
//                            throw new IOException($"Arquivo não foi encontrado após criação: {_logPath}");
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        _logger.LogError(ex, "ERRO ao criar arquivo de log: {LogPath}", _logPath);
//                        throw;
//                    }
//                }
//                else
//                {
//                    var fileInfo = new FileInfo(_logPath);
//                    _logger.LogInformation("Arquivo de log já existe: {LogPath} - Tamanho: {FileSize} bytes, Última modificação: {LastWrite}",
//                        _logPath, fileInfo.Length, fileInfo.LastWriteTime);
//                }

//                // 3. Inicialização do Processo e Métricas
//                _process = Process.GetCurrentProcess();
//                _cpuCores = Environment.ProcessorCount;

//                // Inicialização das variáveis de cálculo da CPU
//                _lastCpuTime = _process.TotalProcessorTime;
//                _lastCheck = DateTime.UtcNow;

//                // 4. Configuração do Timer
//                ExecutionContext.SuppressFlow();
//                _timer = new Timer(async _ => await LogMetricsAsync(), null, Timeout.Infinite, Timeout.Infinite);
//                ExecutionContext.RestoreFlow();

//                _logger.LogInformation("MetricsService inicializado com sucesso. CPU Cores: {CpuCores}", _cpuCores);
//                _logger.LogInformation("=== FIM DA INICIALIZAÇÃO ===");
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Erro crítico ao inicializar MetricsService");
//                throw;
//            }
//        }

//        public Task StartAsync(CancellationToken cancellationToken)
//        {
//            _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(LoggingIntervalSeconds));
//            _logger.LogInformation("Monitoramento de métricas INICIADO. Intervalo: {IntervalSeconds}s", LoggingIntervalSeconds);
//            return Task.CompletedTask;
//        }

//        /// <summary>
//        /// Coleta as métricas do processo atual, calcula o uso de CPU e grava no arquivo CSV.
//        /// </summary>
//        private async Task LogMetricsAsync()
//        {
//            if (Interlocked.CompareExchange(ref _lastRefreshTimestamp, 1, 0) != 0)
//            {
//                _logger.LogWarning("Tentativa de execução concorrente ignorada");
//                return;
//            }

//            try
//            {
//                // 1. Coleta de Dados
//                _process.Refresh();

//                // Métricas de Memória e Threads
//                double gcMemMB = GC.GetTotalMemory(false) / 1024.0 / 1024.0;
//                double workingMB = _process.WorkingSet64 / 1024.0 / 1024.0;
//                double privateMB = _process.PrivateMemorySize64 / 1024.0 / 1024.0;
//                int threads = _process.Threads.Count;

//                // 2. Cálculo do Uso de CPU
//                var now = DateTime.UtcNow;
//                var cpuTime = _process.TotalProcessorTime;

//                double cpuMs = (cpuTime - _lastCpuTime).TotalMilliseconds;
//                double elapsedMs = (now - _lastCheck).TotalMilliseconds;

//                double cpuPercent = 0;

//                if (elapsedMs > 0)
//                {
//                    cpuPercent = (cpuMs / elapsedMs) * 100.0;
//                }

//                // 3. Atualização das Variáveis de Estado
//                _lastCpuTime = cpuTime;
//                _lastCheck = now;

//                // 4. Geração e Gravação da Linha
//                string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{gcMemMB:F2},{workingMB:F2},{privateMB:F2},{cpuPercent:F2},{threads}";

//                // Verificar se o arquivo ainda existe antes de escrever
//                if (!File.Exists(_logPath))
//                {
//                    _logger.LogWarning("Arquivo de log não existe mais. Recriando: {LogPath}", _logPath);
//                    await Task.Run(() => File.WriteAllText(_logPath, "Timestamp,GC(MB),WorkingSet(MB),Private(MB),CPU%,Threads\n"));
//                }

//                // Usar Task.Run com FileStream/StreamWriter garante que a operação de IO não bloqueie o thread do Timer.
//                await Task.Run(() =>
//                {
//                    try
//                    {
//                        using (var stream = new FileStream(_logPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
//                        using (var writer = new StreamWriter(stream))
//                        {
//                            writer.WriteLine(line);
//                        }
//                    }
//                    catch (Exception writeEx)
//                    {
//                        _logger.LogError(writeEx, "Erro ao escrever no arquivo: {LogPath}", _logPath);
//                        throw;
//                    }
//                });

//                // 5. Log estruturado das métricas
//                _logger.LogInformation("Métricas coletadas - CPU: {CpuPercent:F2}%, RAM: {WorkingMemoryMB:F2}MB, Threads: {ThreadCount}",
//                    cpuPercent, workingMB, threads);
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Erro ao gravar métricas");

//                // Tenta gravar a linha de erro
//                try
//                {
//                    string errorLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},ERRO,-,-,-,-,{ex.Message.Replace(",", ";")}";
//                    await Task.Run(() => File.AppendAllText(_logPath, errorLine + "\n"));
//                }
//                catch (Exception innerEx)
//                {
//                    _logger.LogError(innerEx, "Não foi possível gravar linha de erro no arquivo");
//                }
//            }
//            finally
//            {
//                Interlocked.Exchange(ref _lastRefreshTimestamp, 0);
//            }
//        }

//        public void Dispose()
//        {
//            _timer?.Change(Timeout.Infinite, Timeout.Infinite);
//            _timer?.Dispose();

//            _logger.LogInformation("Serviço de métricas encerrado");
//            GC.SuppressFinalize(this);
//        }

//        public Task StopAsync(CancellationToken cancellationToken)
//        {
//            _logger.LogInformation("Recebido sinal para encerrar serviço de métricas");
//            Dispose();
//            return Task.CompletedTask;
//        }
//    }
//}