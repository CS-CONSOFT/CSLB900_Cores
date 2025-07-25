namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB051Repository : IBaseCrud<CSICP_Bb051>
    {
        Task<CSICP_Bb051?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb051>> GetListAsync(int tenant);
    }
}
