using CSCore.Application.Dto.Dtos.EvtRabbitMQ;
using CSCore.Ifs.Eventos.Repository;
using MassTransit;
using Serilog;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusGeraProtocoloCI(IGenerateProtocolo generateProtocolo) : IConsumer<DtoGerarProtocoloCI>
    {
        private readonly IGenerateProtocolo _gerarProtocolo = generateProtocolo;
        public async Task Consume(ConsumeContext<DtoGerarProtocoloCI> context)
        {
            Log.Information("RabbitMQ: Mensagem recebida no consumer {Consumer} às {Data}. Tipo da mensagem: {MessageType}. Conteúdo: {@Message}",
             this.GetType().Name,
             DateTime.UtcNow.ToLocalTime(),
             context.Message.GetType().Name,
             context.Message);
            await _gerarProtocolo.Fcn_ProtocoloGeral(context.Message.EmpresaID);
        }
    }
}
