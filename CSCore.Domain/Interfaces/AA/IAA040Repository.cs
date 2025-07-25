namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA040Repository : IBaseCrud<CSICP_Aa040>
    {
        Task<CSICP_Aa040?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa040>> GetListAsync(int tenant);
    }
}
