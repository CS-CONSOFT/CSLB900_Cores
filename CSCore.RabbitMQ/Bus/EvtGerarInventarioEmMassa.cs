using CSCore.Domain.Interfaces.GG._03X;
using CSCore.RabbitMQ.PublishObjetos;
using MassTransit;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtGerarInventarioEmMassa(IGG032Repository gG032Repository) : IConsumer<Rbt_CS_GerarInventarioEmMassa_GG032>
    {
        private readonly IGG032Repository _GG032Repository = gG032Repository;
        public async Task Consume(ConsumeContext<Rbt_CS_GerarInventarioEmMassa_GG032> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);
            string result = await _GG032Repository
                 .CS_GeradorInventarioEmMassa(
                context.Message.in_tenantId,
                context.Message.idgg001_talmox_virtual,
                context.Message.isQtdZero,
                context.Message.request);
        }
    }
}
