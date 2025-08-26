using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.Ifs.CS_Context;
using CSCore.RabbitMQ.Hub;
using CSCore.RabbitMQ.Hub.Ax;
using CSCore.RabbitMQ.PublishObjetos;
using CSLB900.MSTools.Util;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Serilog;
namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusBloquearDesbloquearInventarioGG032 : IConsumer<Rbt_CS_BloquearDesbloquearInventario_GG032>
    {
        private readonly IGG032Repository _repository;
        private readonly IStaticaLabelRepository _staticaLabelRepository;
        private readonly IHubContext<HubNotification> _hubContext;

        public EvtBusBloquearDesbloquearInventarioGG032(
            IGG032Repository repository,
            IStaticaLabelRepository staticaLabelRepository,
            IHubContext<HubNotification> hubContext,
            AppDbContext context)
        {
            _repository = repository;
            _staticaLabelRepository = staticaLabelRepository;
            _hubContext = hubContext;
        }

        public async Task Consume(ConsumeContext<Rbt_CS_BloquearDesbloquearInventario_GG032> context)
        {

            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);


            try
            {
                int idGG032StaBloqueado = await _staticaLabelRepository.GetIDStaticaByLabel<OsusrE9aCsicpGg032Stum>("Bloqueado");
                int idGG032StaSolicitado = await _staticaLabelRepository.GetIDStaticaByLabel<OsusrE9aCsicpGg032Stum>("Solicitado");


                await _repository.CS_BloquearDesbloquearInventario(
                    context.Message.tenant,
                    context.Message.in_InventarioId,
                    idGG032StaBloqueado,
                    idGG032StaSolicitado,
                    context.Message.in_tipoAcaoInventario);



                await _hubContext.Clients.Group("bloquear-desbloquear-inventario-" + context.Message.in_usuarioID)
                   .SendAsync(HubMethodNames.BLOQUEAR_DESBLOQUEAR_INVENTARIO_GG032, new
                   {
                       Success = true,
                       Message = context.Message.in_tipoAcaoInventario == 1 ? "Sucesso ao bloquear inventário!" : "Sucesso ao desbloquear inventário!",
                       Timestamp = DateTime.UtcNow
                   });
            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("bloquear-desbloquear-inventario-" + context.Message.in_usuarioID)
                 .SendAsync(HubMethodNames.BLOQUEAR_DESBLOQUEAR_INVENTARIO_GG032, new
                 {
                     Success = false,
                     Message = context.Message.in_tipoAcaoInventario == 1
                     ? "Falha ao bloquear inventário: " + HandlerExceptionMessage.CreateExceptionMessage(ex)
                     : "Falha ao desbloquear inventário: " + HandlerExceptionMessage.CreateExceptionMessage(ex),
                     DetailsError = HandlerExceptionMessage.CreateExceptionMessage(ex),
                     Timestamp = DateTime.UtcNow
                 });
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
