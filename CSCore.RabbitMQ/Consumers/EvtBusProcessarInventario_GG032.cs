using CSCore.Domain.CS_Models.Staticas.GG;
using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Ifs.GG.Repository.GG._03X.GG032.ProcessarInventario;
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
        private readonly IProcessarInventarioGG032 _repository;
        private readonly IStaticaLabelRepository _staticaLabelRepository;
        private readonly IHubContext<HubNotification> _hubContext;

        public EvtBusProcessarInventario_GG032(IProcessarInventarioGG032 repository,
            IStaticaLabelRepository staticaLabelRepository,
            IHubContext<HubNotification> hubContext)
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


                var prm = new PrmProcessarInventarioGG032
                {
                    InTenant = context.Message.tenant,
                    InInventarioId = context.Message.in_InventarioId,
                    InStIDGG032StaBloqueadoID = idGG032StaBloqueado,
                    InStIDGG032StaConcluidoID = idGG032StaConcluido,
                    InStIDGG028EntSaidaSaidaID = idGG028EntSai_Saida,
                    InStIDGG028EntSaidaEntradaID = idGG028EntSai_Entrada,
                    InStIDGG028NatInventarioID = idGG028Nat_Inventario
                };
                await _repository.ProcessarInventario(prm);


                await _hubContext.Clients.Group("processar-inventario-" + context.Message.in_usuarioID)
                   .SendAsync(HubMethodNames.PROCESSAR_INVENTARIO_GG032, new
                   {
                       Success = true,
                       Message = "Inventário processado com sucesso!",
                       Timestamp = DateTime.UtcNow
                   });

            }
            catch (Exception ex)
            {
                await _hubContext.Clients.Group("processar-inventario-" + context.Message.in_usuarioID)
                 .SendAsync(HubMethodNames.PROCESSAR_INVENTARIO_GG032, new
                 {
                     Success = false,
                     Message = HandlerExceptionMessage.CreateExceptionMessage(ex),
                     Timestamp = DateTime.UtcNow
                 });
                throw new Exception(HandlerExceptionMessage.CreateExceptionMessage(ex));
            }
        }
    }
}
