using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using GG104Materiais.C82Application.Service.BancoDoBrasil;
using MassTransit;
using Microsoft.AspNetCore.SignalR;

namespace CSCore.RabbitMQ.Consumers
{
    public class EvtConsumer_BancoBrasil_EnviaTitulo(IBancoBrasilService bancoBrasilService,
        ISendEndpointProvider sendEndpointProvider,
        IHubContext<HubBancoBrasil> hubContext) : IConsumer<Rbt_CS_BancoBrasil_EnviaTitulo>
    {
        private readonly IBancoBrasilService _bancoBrasilService = bancoBrasilService;
        private readonly ISendEndpointProvider _sendEndpointProvider = sendEndpointProvider;
        private readonly IHubContext<HubBancoBrasil> _hubContext = hubContext;


        public async Task Consume(ConsumeContext<Rbt_CS_BancoBrasil_EnviaTitulo> context)
        {
            try
            {
                await _bancoBrasilService.CS01_Envio_Titulos(context.Message.in_ff102ID, context.Message.in_tenantID);

                // Enviar notificação de sucesso via SignalR
                await _hubContext.Clients.Group(HubGroupNames.BANCO_BRASIL_HUB_GRUPO)
                    .SendAsync("CS01_Envio_Titulos", new
                    {
                        CorrelationId = context.Message.in_correlationID,
                        Success = true,
                        Message = "Processado com sucesso!",
                        FF102ID = context.Message.in_ff102ID,
                        Timestamp = DateTime.UtcNow
                    });
            }
            catch (Exception ex)
            {
                // Enviar notificação de erro via SignalR
                await _hubContext.Clients.Group(HubGroupNames.BANCO_BRASIL_HUB_GRUPO)
                    .SendAsync("CS01_Envio_Titulos", new
                    {
                        CorrelationId = context.Message.in_correlationID,
                        Success = false,
                        Message = HandlerExceptionMessage.CreateExceptionMessage(ex),
                        FF102ID = context.Message.in_ff102ID,
                        Timestamp = DateTime.UtcNow
                    });
                Console.WriteLine($"Enviando para grupo: {HubGroupNames.BANCO_BRASIL_HUB_GRUPO}");
            }
        }
    }
}
