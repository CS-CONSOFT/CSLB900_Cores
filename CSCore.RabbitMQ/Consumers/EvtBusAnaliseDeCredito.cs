using CSCore.Ifs.AnaliseDeCredito.AnaliseCredito;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusAnaliseDeCredito(CreditoSemScore creditoSemScore, IHubContext<HubNotification> hubContext) : IConsumer<Rbt_CS_AnaliseCredito>
    {
        private CreditoSemScore _creditoSemScore = creditoSemScore;
        private readonly IHubContext<HubNotification> _hubContext = hubContext;
        public async Task Consume(ConsumeContext<Rbt_CS_AnaliseCredito> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
                    this.GetType().Name,
                    DateTime.UtcNow.ToLocalTime(),
                    context.Message.GetType().Name,
                    context.Message);
            try
            {

                await _creditoSemScore.ExecutarAnaliseCredito(
                    context.Message.in_CalcularScoreClearsale,
                    context.Message.in_tenantID,
                    context.Message.in_conta_ID);

                await _hubContext.Clients.Group("analise-de-credito-" + context.Message.in_usuarioID)
                   .SendAsync(HubMethodNames.ANALISE_CREDITO, new
                   {
                       Success = true,
                       Message = "Sucesso ao realizar analise de credito",
                       Timestamp = DateTime.UtcNow
                   });
            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("analise-de-credito-" + context.Message.in_usuarioID)
                .SendAsync(HubMethodNames.ANALISE_CREDITO, new
                {
                    Success = false,
                    Message = "Falha ao realizar analise de credito: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                    Timestamp = DateTime.UtcNow
                });
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
