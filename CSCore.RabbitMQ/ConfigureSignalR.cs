using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace CSCore.RabbitMQ
{
    public static class ConfigureSignalR
    {
        public static void ConfigurarSignalR(this IServiceCollection services)
        {
            Log.Information("Configurando SignalR com suporte a WebSocket");

            services.AddSignalR(options =>
            {
                // ✅ Habilita erros detalhados (apenas em desenvolvimento)
                options.EnableDetailedErrors = true;

                // ✅ Tempo máximo que uma conexão pode ficar inativa
                options.ClientTimeoutInterval = TimeSpan.FromMinutes(1);

                // ✅ Intervalo para enviar mensagens keep-alive
                options.KeepAliveInterval = TimeSpan.FromSeconds(15);

                // ✅ Tamanho máximo da mensagem (1MB)
                options.MaximumReceiveMessageSize = 1024 * 1024;

                // ✅ Tamanho do buffer de transmissão paralela
                options.StreamBufferCapacity = 10;
            })
            .AddJsonProtocol(options =>
            {
                // ✅ Configurações de serialização JSON
                options.PayloadSerializerOptions.PropertyNamingPolicy = null; // Mantém nomes originais
                options.PayloadSerializerOptions.WriteIndented = false; // Compacto para produção
            });

            Log.Information("SignalR configurado com sucesso");
        }
    }
}