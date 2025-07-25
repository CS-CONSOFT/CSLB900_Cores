namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB061Repository : IBaseCrud<CSICP_Bb061>
    {
        Task<CSICP_Bb061?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<CSICP_Bb061>> GetListAsync(int tenant, bool? isActive, string contaID);
        Task<CSICP_Bb061> ChangeActive(CSICP_Bb061 entity);
    }
}
