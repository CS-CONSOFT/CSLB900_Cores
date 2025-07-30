using Serilog;
using Serilog.Events;

namespace CS_Logs;

public class LoggerConfig
{
    public static void ConfigurarLogger(LogEventLevel minLevel = LogEventLevel.Debug)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Is(minLevel)
            .Enrich.WithMachineName()
            .Enrich.WithEnvironmentName()
            .WriteTo.Console()
            //.WriteTo.File("logs/info-.txt", rollingInterval: RollingInterval.Day, restrictedToMinimumLevel: LogEventLevel.Information)
            //.WriteTo.File("logs/error-.txt", rollingInterval: RollingInterval.Day, restrictedToMinimumLevel: LogEventLevel.Error, retainedFileCountLimit: 7)
            //.WriteTo.File(new Serilog.Formatting.Json.JsonFormatter(), "logs/log-.json", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Information("Logger configurado a partir de CSLogs! Nível mínimo: {MinLevel}", minLevel);
    }
}
