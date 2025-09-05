using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._03X.GG032;
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
        private readonly IBloquearDesbloquearInventario _repository;
        private readonly IStaticaLabelRepository _staticaLabelRepository;
        private readonly IHubContext<HubNotification> _hubContext;

        public EvtBusBloquearDesbloquearInventarioGG032(
            IBloquearDesbloquearInventario repository,
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

                var prm = new PrmBloquearDesbloquearInventario
                {
                    InTenantID = context.Message.tenant,
                    InInventarioID = context.Message.in_InventarioId,
                    InTipoAcaoInventario = context.Message.in_tipoAcaoInventario,
                    InSTIDCsicpGg032StaBloqueadoID = idGG032StaBloqueado,
                    InSTIDCsicpGg032StaSolicitadoID = idGG032StaSolicitado,
                };
                await _repository.BloquearDesbloquearInventario(prm);

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
