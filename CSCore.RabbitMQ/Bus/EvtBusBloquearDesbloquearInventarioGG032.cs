using CSCore.Domain.Interfaces.Estatica;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.RabbitMQ.PublishObjetos;
using MassTransit;
using Serilog;
namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusBloquearDesbloquearInventarioGG032 : IConsumer<Rbt_CS_BloquearDesbloquearInventario_GG032>
    {
        private readonly IGG032Repository _repository;
        private readonly IStaticaLabelRepository _staticaLabelRepository;

        public EvtBusBloquearDesbloquearInventarioGG032(IGG032Repository repository, IStaticaLabelRepository staticaLabelRepository)
        {
            _repository = repository;
            _staticaLabelRepository = staticaLabelRepository;
        }

        public async Task Consume(ConsumeContext<Rbt_CS_BloquearDesbloquearInventario_GG032> context)
        {

            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);
            int idGG032StaBloqueado = await _staticaLabelRepository.GetIDStaticasByTypeGG032StaPorCodCS("Bloqueado");
            int idGG032StaSolicitado = await _staticaLabelRepository.GetIDStaticasByTypeGG032StaPorCodCS("Solicitado");


            await _repository.CS_BloquearDesbloquearInventario(
                context.Message.tenant,
                context.Message.in_InventarioId,
                idGG032StaBloqueado,
                idGG032StaSolicitado,
                context.Message.in_tipoAcaoInventario);
        }
    }
}
