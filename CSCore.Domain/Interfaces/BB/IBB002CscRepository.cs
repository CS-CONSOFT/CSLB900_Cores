namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB002CscRepository : IBaseCrud<CSICP_BB002CSC>
    {
        Task<CSICP_BB002CSC?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_BB002CSC>> GetListAsync(int tenant, string bb002Id);
    }
}
