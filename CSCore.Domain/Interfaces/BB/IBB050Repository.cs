namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB050Repository : IBaseCrud<CSICP_Bb050>
    {
        Task<CSICP_Bb050?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb050>> GetListAsync(int tenant);
    }
}

