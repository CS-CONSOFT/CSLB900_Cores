using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.GG.Repository.GG._03X;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtGerarInventarioEmMassa(IGerarInventarioEmMassa repository,
        IHubContext<HubNotification> hubContext, IStaticaLabelRepository staticaLabelRepository) : IConsumer<Rbt_CS_GerarInventarioEmMassa_GG032>
    {
        private readonly IGerarInventarioEmMassa repository = repository;
        private readonly IHubContext<HubNotification> _hubContext = hubContext;
        private readonly IStaticaLabelRepository _staticaLabelRepository = staticaLabelRepository;
        public async Task Consume(ConsumeContext<Rbt_CS_GerarInventarioEmMassa_GG032> context)
        {
            Log.Debug("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);

            try
            {
                int idgg001_talmox_virtual = await _staticaLabelRepository.GetIDStaticaByLabel<CSICP_GG001Talmox>(Entities.GG001_TAlmox.Virtual);


                string result = await repository
                .CS_GeradorInventarioEmMassa(
               context.Message.in_tenantId,
               context.Message.isQtdZero,
               context.Message.idgg001_talmox_virtual,
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
