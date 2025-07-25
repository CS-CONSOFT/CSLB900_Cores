using Serilog;

namespace CS_Logs;

public class LoggerConfig
{
    public static void ConfigurarLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Information("Logger configurado a partir de MinhaBibliotecaLogs!");
    }
}
