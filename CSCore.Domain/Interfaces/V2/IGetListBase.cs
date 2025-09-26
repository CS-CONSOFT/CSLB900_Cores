using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.V2
{
    public interface IGetListBase<TEntity, TFilters> where TEntity : class where TFilters : ParametrosBaseFiltro
    {
        Task<(List<TEntity>, int)> GetListAsync(int InTenantID, TFilters parametros);
    }
}
