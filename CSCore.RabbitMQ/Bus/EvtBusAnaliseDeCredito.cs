using CSCore.Ifs.AnaliseDeCredito.NovaPasta;
using CSCore.RabbitMQ.PublishObjetos;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusAnaliseDeCredito(CreditoSemScore creditoSemScore) : IConsumer<Rbt_CS_AnaliseCredito>
    {
        private CreditoSemScore _creditoSemScore = creditoSemScore;
        public async Task Consume(ConsumeContext<Rbt_CS_AnaliseCredito> context)
        {
            await _creditoSemScore.ExecutarAnaliseCredito(
                context.Message.in_CalcularScoreClearsale,
                context.Message.in_tenantID,
                context.Message.in_conta_ID);
        }
    }
}
