using CSCore.RabbitMQ;
using MassTransit;
using Serilog;

namespace CSCore.RabbitMQ.Configuration;

public static class ConfigureConsumers
{
    public static void CSConfigure<T>(this IRabbitMqBusFactoryConfigurator cfg, IBusRegistrationContext context, 
        string Fila,
        string Exchange,
        string Acao) where T : class, IConsumer
    {
        string? urlParaRoutingKey = Environment.GetEnvironmentVariable("API_URL")
         ?? "http://localhost:9607";
        string nomeDominio = "";
        if (!string.IsNullOrEmpty(urlParaRoutingKey))
        {
            var url = urlParaRoutingKey.Replace("https://", "")
                                       .Replace("http://", "");
            var partes = url.Split('.');
            nomeDominio = partes[0].Contains("/") ? partes[0].Split('/')[0] : partes[0];
        }

        cfg.ReceiveEndpoint(Fila + nomeDominio, e =>
        {
            e.ConfigureConsumer<T>(context);
            e.PrefetchCount = 1;
            e.ConcurrentMessageLimit = 1;

           
            var routingKey = RoutingKeys.GetRoutingKey(urlParaRoutingKey, action: Acao);

            Log.Warning(
                "RabbitMQ - Configurando endpoint: {Endpoint} | Exchange: {Exchange} | RoutingKey: {RoutingKey}",
                Fila + nomeDominio, Exchange, routingKey);

            //cria um vinculo entre a fila e o exchange
            e.Bind(Exchange, s =>
            {
                s.RoutingKey = routingKey;
                s.ExchangeType = "direct";
            });
        });
    }
}