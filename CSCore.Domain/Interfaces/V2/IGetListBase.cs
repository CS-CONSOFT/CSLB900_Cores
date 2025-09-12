using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.V2
{
    public interface IGetListBase<T> 
    {
        Task<(List<T>, int)> GetListAsync(int InTenantID, ParametrosBaseFiltro parametros,params ICSFilter<T>[] InFiltros);
    }
}
