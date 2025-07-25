namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB031Repository : IBaseCrud<CSICP_Bb031>
    {
        Task<CSICP_Bb031?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb031>> GetListAsync(int tenant, string? search,int? searchCode, bool? isActive);
        Task<CSICP_Bb031> ChangeActive(CSICP_Bb031 entity);
    }
}
