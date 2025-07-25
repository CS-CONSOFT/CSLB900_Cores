using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.GG._05X;
using MassTransit;

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
            await _repository.GerarInventario(context.Message);
        }
    }
}
