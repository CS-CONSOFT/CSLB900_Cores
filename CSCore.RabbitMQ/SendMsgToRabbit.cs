using MassTransit;
using Serilog;

namespace CSCore.RabbitMQ
{
    public interface ISendMsgToRabbit
    {
        Task SendMessage<T>(T message, string routingKey, string exchangeName);
        Task SendMessageV2<T>(T message, string exchangeName, string action);
    }
    public class SendMsgToRabbit(ISendEndpointProvider sendEndpointProvider) : ISendMsgToRabbit
    {
        private readonly ISendEndpointProvider _sendEndpointProvider = sendEndpointProvider;

        public async Task SendMessage<T>(T message, string routingKey, string exchangeName)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));
            if (string.IsNullOrEmpty(routingKey)) throw new ArgumentException("Routing key cannot be null or empty.", nameof(routingKey));
            if (string.IsNullOrEmpty(exchangeName)) throw new ArgumentException("Exchange name cannot be null or empty.", nameof(exchangeName));

           


            Log.Information("RabbitMQ - Enviando movimento entrada saída para Routing Key: " + routingKey);

            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"exchange:{exchangeName}?type=direct"));
            await endpoint.Send(message, ctx =>
            {
                ctx.SetRoutingKey(routingKey);
            });
        }

        public async Task SendMessageV2<T>(T message, string exchangeName, string action)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));
          
            if (string.IsNullOrEmpty(exchangeName)) throw new ArgumentException("Exchange name cannot be null or empty.", nameof(exchangeName));

            string? currentURL = Environment.GetEnvironmentVariable("API_URL") ?? "http://localhost:9607";
            (string routingKey, string _) = RoutingKeys.GetRoutingKeyComDominio(currentURL, action);


            Log.Information("RabbitMQ - Enviando movimento entrada saída para Routing Key: " + routingKey);

            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri($"exchange:{exchangeName}?type=direct"));
            await endpoint.Send(message, ctx =>
            {
                ctx.SetRoutingKey(routingKey);
            });
        }
    }
}
