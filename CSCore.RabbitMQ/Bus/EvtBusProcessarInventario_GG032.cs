using CSCore.Domain.EstaticasLabel.GG;
using CSCore.Domain.Interfaces.Estatica;
using CSCore.Domain.Interfaces.GG._03X;
using CSCore.RabbitMQ.PublishObjetos;
using MassTransit;
using Serilog;
namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusProcessarInventario_GG032 : IConsumer<Rbt_CS_ProcessarInventario_GG032>
    {
        private readonly IGG032Repository _repository;
        private readonly IStaticaLabelRepository _staticaLabelRepository;

        public EvtBusProcessarInventario_GG032(IGG032Repository repository, IStaticaLabelRepository staticaLabelRepository)
        {
            _repository = repository;
            _staticaLabelRepository = staticaLabelRepository;
        }

        public async Task Consume(ConsumeContext<Rbt_CS_ProcessarInventario_GG032> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);
            int idGG032StaBloqueado = await _staticaLabelRepository.GetIDStaticasByTypeGG032StaPorCodCS("Bloqueado");
            int idGG028EntSai_Entrada = await _staticaLabelRepository.GetIDStaticasByTypeGG028EntSaidaLabel(Entities.GG028EntSaida.Entrada);
            int idGG028EntSai_Saida = await _staticaLabelRepository.GetIDStaticasByTypeGG028EntSaidaLabel(Entities.GG028EntSaida.Saida);
            int idGG028Nat_Inventario = await _staticaLabelRepository.GetIDStaticasByTypeGG028NatOpLabel(Entities.GG028Nat.Inventario);
            int idGG032StaConcluido = await _staticaLabelRepository.GetIDStaticasByTypeGG032StaPorCodCS("Concluido");

            await _repository.CS_InventarioProcessar(
                context.Message.tenant,
                context.Message.in_InventarioId,
                idGG032StaBloqueado,
                idGG032StaConcluido,
                idGG028EntSai_Saida,
                idGG028EntSai_Entrada,
                idGG028Nat_Inventario);
        }
    }
}
