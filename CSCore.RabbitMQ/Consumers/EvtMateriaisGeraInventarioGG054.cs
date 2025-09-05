using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.GG._05X;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;
namespace CSCore.Ifs.GG
{
    public class EvtMateriaisGeraInventarioGG054 : IConsumer<GG054GeraInventarioParametros>
    {
        private readonly IGG054Repository _repository;
        private readonly IHubContext<HubNotification> _hubContext;

        public EvtMateriaisGeraInventarioGG054(IGG054Repository repository, IHubContext<HubNotification> hubContext)
        {
            _repository = repository;
            _hubContext = hubContext;
        }

        public async Task Consume(ConsumeContext<GG054GeraInventarioParametros> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);

            try
            {
                await _repository.GerarInventario(context.Message);
                await _hubContext.Clients.Group("gera-inventario-gg054-" + context.Message.sy001_usuarioID)
                 .SendAsync(HubMethodNames.GERA_INVENTARIO_GG054, new
                 {
                     Success = true,
                     Message = "Sucesso ao gerar inventario gg054",
                     Timestamp = DateTime.UtcNow
                 });
            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("gera-inventario-gg054-" + context.Message.sy001_usuarioID)
                .SendAsync(HubMethodNames.GERA_INVENTARIO_GG054, new
                {
                    Success = false,
                    Message = "Falha ao gerar inventario: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                    Timestamp = DateTime.UtcNow
                });
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
