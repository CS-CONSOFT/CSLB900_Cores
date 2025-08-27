using Serilog;
using Serilog.Events;

namespace CS_Logs;

public class LoggerConfig
{
    public static void ConfigurarLogger(LogEventLevel minLevel = LogEventLevel.Information)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Is(minLevel)
             .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning) // Filtra logs do ASP.NET Core
            .MinimumLevel.Override("Microsoft.Extensions.Http", LogEventLevel.Warning) // Filtra logs de HTTP Client
            .MinimumLevel.Override("Steeltoe", LogEventLevel.Warning) // Filtra logs do Steeltoe (Eureka)
            .MinimumLevel.Override("MassTransit", LogEventLevel.Warning) // Filtra logs do MassTransit
             .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Error) // Filtra logs do EF Core
            .MinimumLevel.Override("Microsoft.EntityFrameworkCore.Database.Command", LogEventLevel.Error) // Filtra comandos SQL
            .MinimumLevel.Override("Microsoft.EntityFrameworkCore.Query", LogEventLevel.Error) // Filtra queries
            .Filter.ByExcluding(logEvent =>
                logEvent.MessageTemplate.Text.Contains("Start processing HTTP request") ||
                logEvent.MessageTemplate.Text.Contains("Sending HTTP request") ||
                logEvent.MessageTemplate.Text.Contains("Received HTTP response headers") ||
                logEvent.MessageTemplate.Text.Contains("End processing HTTP request") ||
                logEvent.MessageTemplate.Text.Contains("Request starting HTTP") ||
                logEvent.MessageTemplate.Text.Contains("Request finished HTTP") ||
                logEvent.MessageTemplate.Text.Contains("Now listening on") ||
                logEvent.MessageTemplate.Text.Contains("Application started") ||
                logEvent.MessageTemplate.Text.Contains("Hosting environment") ||
                logEvent.MessageTemplate.Text.Contains("Content root path") ||
                logEvent.MessageTemplate.Text.Contains("Starting HeartBeat") ||
                (logEvent.MessageTemplate.Text.Contains("eureka") && logEvent.Level == LogEventLevel.Information))
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
