namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB024Repository : IBaseCrud<CSICP_Bb024>
    {
        Task<CSICP_Bb024?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<CSICP_Bb024>> GetListAsync(int tenant);
        Task<IEnumerable<CSICP_Bb024>> GetListByBB025ID(int tenant, string bb025id);
    }
}

