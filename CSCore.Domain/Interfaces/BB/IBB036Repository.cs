namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB036Repository : IBaseCrud<CSICP_Bb036>
    {
        Task<CSICP_Bb036?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb036>> GetListAsync(int tenant, string? search, bool? isActive);
    }
}

