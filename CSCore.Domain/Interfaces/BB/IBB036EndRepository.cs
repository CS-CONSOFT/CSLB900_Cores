namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB036EndRepository : ISateliteCD<CSICP_Bb036Ender>
    {
        Task<IEnumerable<CSICP_Bb036Ender>> GetAllByParentId(string parentId, int tenant);
    }
}
