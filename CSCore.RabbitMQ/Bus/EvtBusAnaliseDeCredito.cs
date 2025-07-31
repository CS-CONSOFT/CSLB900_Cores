using CSCore.Ifs.AnaliseDeCredito.AnaliseCredito;
using CSCore.RabbitMQ.PublishObjetos;
using MassTransit;
using Serilog;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusAnaliseDeCredito(CreditoSemScore creditoSemScore) : IConsumer<Rbt_CS_AnaliseCredito>
    {
        private CreditoSemScore _creditoSemScore = creditoSemScore;
        public async Task Consume(ConsumeContext<Rbt_CS_AnaliseCredito> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
                this.GetType().Name,
                DateTime.UtcNow.ToLocalTime(),
                context.Message.GetType().Name,
                context.Message);
            await _creditoSemScore.ExecutarAnaliseCredito(
                context.Message.in_CalcularScoreClearsale,
                context.Message.in_tenantID,
                context.Message.in_conta_ID);
        }
    }
}
