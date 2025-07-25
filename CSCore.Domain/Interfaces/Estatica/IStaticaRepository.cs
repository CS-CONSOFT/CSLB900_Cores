using CSCore.Domain.CS_Models.Staticas;
using static CSCore.Domain.StaticaTypes;

namespace CSCore.Domain.Interfaces.Estatica
{
    public interface IStaticaRepository
    {
        Task<IReadOnlyCollection<object>> GetStaticasByTypeAA(StaticTypeAA staticTypeAA);
        Task<IReadOnlyCollection<object>> GetStaticasByTypeBB(StaticTypeBB staticTypeBB);
        Task<IReadOnlyCollection<object>> GetStaticasByTypeClient(StaticTypeClient staticTypeClient);
        Task<IReadOnlyCollection<object>> GetStaticasByTypeFF(StaticTypeFF staticTypeFF);

        Task<IReadOnlyCollection<object>> GetStaticasByTypeGG(StaticTypeGG staticTypeGG);
        Task<IReadOnlyCollection<object>> GetStaticasByTypeSped(StaticSpedType staticSpedType);
        Task<IReadOnlyCollection<object>> GetStaticasByTypeSys(StaticTypeSys staticTypeSys);
        Task<IReadOnlyCollection<CSICP_Email>> GetStaticaEmail();
    }
}
