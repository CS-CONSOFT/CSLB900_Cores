using CSCore.Domain.Interfaces.GG._03X;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtGerarInventarioEmMassa(IGG032Repository gG032Repository,
        IHubContext<HubNotification> hubContext) : IConsumer<Rbt_CS_GerarInventarioEmMassa_GG032>
    {
        private readonly IGG032Repository _GG032Repository = gG032Repository;
        private readonly IHubContext<HubNotification> _hubContext = hubContext;
        public async Task Consume(ConsumeContext<Rbt_CS_GerarInventarioEmMassa_GG032> context)
        {
            Log.Debug("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);

            try
            {
                string result = await _GG032Repository
                .CS_GeradorInventarioEmMassa(
               context.Message.in_tenantId,
               context.Message.idgg001_talmox_virtual,
               context.Message.isQtdZero,
               context.Message.request);


                await _hubContext.Clients.Group("gerar-inventario-em-massa-" + context.Message.in_usuarioId)
                   .SendAsync(HubMethodNames.GERAR_INVENTARIO_EM_MASSA_GG032, new
                   {
                       Success = true,
                       Message = "Inventário processado com sucesso!",
                       DetailsError = "",
                       Timestamp = DateTime.UtcNow
                   });
            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("gerar-inventario-em-massa-" + context.Message.in_usuarioId)
                .SendAsync(HubMethodNames.GERAR_INVENTARIO_EM_MASSA_GG032, new
                {
                    Success = false,
                    Message = "Falha ao processar inventário",
                    DetailsError = HandlerExceptionMessage.CreateExceptionMessage(ex),
                    Timestamp = DateTime.UtcNow
                });
            }
        }
    }
}
