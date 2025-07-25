using CSCore.Application.Dto.Dtos.EvtRabbitMQ;
using CSCore.Ifs.Eventos.Repository;
using MassTransit;

namespace CSCore.RabbitMQ.Bus
{
    public class EvtBusGeraProtocoloCI(IGenerateProtocolo generateProtocolo) : IConsumer<DtoGerarProtocoloCI>
    {
        private readonly IGenerateProtocolo _gerarProtocolo = generateProtocolo;
        public async Task Consume(ConsumeContext<DtoGerarProtocoloCI> context)
        {
            await _gerarProtocolo.Fcn_ProtocoloGeral(context.Message.EmpresaID);
        }
    }
}
