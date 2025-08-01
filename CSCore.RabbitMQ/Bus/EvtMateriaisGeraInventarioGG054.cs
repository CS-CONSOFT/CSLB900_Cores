using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.GG._05X;
using MassTransit;
using Serilog;
namespace CSCore.Ifs.GG
{
    public class EvtMateriaisGeraInventarioGG054 : IConsumer<GG054GeraInventarioParametros>
    {
        private readonly IGG054Repository _repository;

        public EvtMateriaisGeraInventarioGG054(IGG054Repository repository)
        {
            _repository = repository;
        }

        public async Task Consume(ConsumeContext<GG054GeraInventarioParametros> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);
            await _repository.GerarInventario(context.Message);
        }
    }
}
