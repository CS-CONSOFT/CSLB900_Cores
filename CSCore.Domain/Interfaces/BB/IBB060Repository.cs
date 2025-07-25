namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB060Repository : IBaseCrud<CSICP_Bb060>
    {
        Task<CSICP_Bb060?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb060?>> GetListAsync(int tenant, string? search, bool? isActive);
        Task<CSICP_Bb060> ChangeActive(CSICP_Bb060 entity);
    }
}
