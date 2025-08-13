using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
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
    public class EvtBusProcessarInventario_GG032 : IConsumer<Rbt_CS_ProcessarInventario_GG032>
    {
        private readonly IGG032Repository _repository;
        private readonly IStaticaLabelRepository _staticaLabelRepository;
        private readonly IHubContext<HubProcessarInventarioGG032> _hubContext;

        public EvtBusProcessarInventario_GG032(IGG032Repository repository,
            IStaticaLabelRepository staticaLabelRepository,
            IHubContext<HubProcessarInventarioGG032> hubContext )
        {
            _repository = repository;
            _staticaLabelRepository = staticaLabelRepository;
            _hubContext = hubContext;
        }

        public async Task Consume(ConsumeContext<Rbt_CS_ProcessarInventario_GG032> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);

            try
            {
                int idGG032StaBloqueado = await _staticaLabelRepository.GetIDStaticaByLabel<OsusrE9aCsicpGg032Stum>("Bloqueado");
                int idGG032StaConcluido = await _staticaLabelRepository.GetIDStaticaByLabel<OsusrE9aCsicpGg032Stum>("Concluido");
                int idGG028EntSai_Entrada = await _staticaLabelRepository.GetIDStaticaByLabel<CSICP_GG028Entsai>(Entities.GG028EntSaida.Entrada);
                int idGG028EntSai_Saida = await _staticaLabelRepository.GetIDStaticaByLabel<CSICP_GG028Entsai>(Entities.GG028EntSaida.Saida);

                int idGG028Nat_Inventario = await
                    _staticaLabelRepository
                    .GetIDStaticaByLabel<OsusrE9aCsicpGg028Nat>(Entities.GG028Nat.Inventario);

              
                await _repository.CS_InventarioProcessar(
                    context.Message.tenant,
                    context.Message.in_InventarioId,
                    idGG032StaBloqueado,
                    idGG032StaConcluido,
                    idGG028EntSai_Saida,
                    idGG028EntSai_Entrada,
                    idGG028Nat_Inventario);


                await _hubContext.Clients.Group(context.Message.in_usuarioID)
                   .SendAsync(HubMethodNames.BLOQUEAR_DESBLOQUEAR_INVENTARIO_GG032, new
                   {
                       Success = true,
                       Message = "Inventário processado com sucesso!",
                       DetailsError = "",
                       Timestamp = DateTime.UtcNow
                   });

            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group(context.Message.in_usuarioID)
                 .SendAsync(HubMethodNames.PROCESSAR_BAIXA_ESTOQUE_GG073, new
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
