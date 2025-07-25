using CSCore.Domain.CS_Models.CSICP_BB.BB01X;

namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB015Repository : IBaseCrud<CSICP_BB015>
    {
        Task<CSICP_BB015?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_BB015>> GetListAsync(int tenant, string? search);
    }
}
