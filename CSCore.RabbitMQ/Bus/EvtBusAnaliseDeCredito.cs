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
            Log.Information("Rbt_CS_AnaliseCredito recebido em {Data}", DateTime.Now);
            await _creditoSemScore.ExecutarAnaliseCredito(
                context.Message.in_CalcularScoreClearsale,
                context.Message.in_tenantID,
                context.Message.in_conta_ID);
        }
    }
}
