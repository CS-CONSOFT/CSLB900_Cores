using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB035Repository : IBaseCrud<CSICP_Bb035>
    {
        Task<CSICP_Bb035?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_Bb035>, int)> GetListAsync
            (int tenant, string? search, bool? isActive, ParametrosBaseFiltro parametrosBaseFiltro);
        Task<CSICP_Bb035> ChangeActive(CSICP_Bb035 entity);
        Task<CSICP_Bb035End> CreateUpdateBB035End(CSICP_Bb035End entity, bool isUpdate = false);
        Task<bool> UpdateAsync(CSICP_Bb035End entityEndereco, CSICP_Bb035 entity, bool isUpdate = false);
    }
}
