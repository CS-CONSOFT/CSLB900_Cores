using static CSCore.Domain.ComboTypes;
using static CSCore.Domain.StaticaTypes;

namespace CSCore.Domain.Interfaces.Combo
{
    public interface IStaticaComboRepository
    {
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeAA(StaticTypeAA staticTypeAA);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeBB(StaticTypeBB staticTypeBB);
        Task<IEnumerable<object>> GetCommonListForComboCG(int tenant, ComboTypeCGStaticas comboType);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeFF(StaticTypeFF staticTypeFF);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeGG(StaticTypeGG staticTypeGG);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeNN(StaticTypeNN staticTypeNN);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeRR(StaticTypeRR staticTypeRR);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeClient(StaticTypeClient staticTypeClient);
        Task<IReadOnlyCollection<object>> GetComboStaticasByTypeSped(StaticSpedType staticSpedType);
        Task<IReadOnlyCollection<object>> GetComboStaticaByRegistro(StaticaRegistros tipoRegistro);


    }
}
