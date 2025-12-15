using CSCore.Application.Dto.Dtos.EvtRabbitMQ;
using CSCore.Ifs.LB900.Repository;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace CSCore.RabbitMQ.Consumers
{
    public class EvtBusGeraProtocoloCI(IGenerateProtocolo generateProtocolo, IHubContext<HubNotification> hubContext) : IConsumer<DtoGerarProtocoloCI>
    {
        private readonly IGenerateProtocolo _gerarProtocolo = generateProtocolo;
        private readonly IHubContext<HubNotification> _hubContext = hubContext;
        public async Task Consume(ConsumeContext<DtoGerarProtocoloCI> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
                 this.GetType().Name,
                 DateTime.UtcNow.ToLocalTime(),
                 context.Message.GetType().Name,
                 context.Message);
            try
            {
                await _gerarProtocolo.Fcn_ProtocoloGeral(context.Message.EmpresaID, context.Message.InTenantID);


                await _hubContext.Clients.Group("gera-protocolo-ci-" + context.Message.InUsuarioID)
                .SendAsync(HubMethodNames.GERA_PROTOCOLO_CI, new
                {
                    Success = true,
                    Message = "Sucesso ao gerar protocolo CI",
                    Timestamp = DateTime.UtcNow
                });
            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("gera-protocolo-ci-" + context.Message.InUsuarioID)
              .SendAsync(HubMethodNames.GERA_PROTOCOLO_CI, new
              {
                  Success = false,
                  Message = "Falha ao gerar protocolo CI: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                  Timestamp = DateTime.UtcNow
              });
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
