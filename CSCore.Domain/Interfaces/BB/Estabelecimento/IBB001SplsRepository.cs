namespace CSCore.Domain.Interfaces.BB.Estabelecimento
{
    public interface IBB001SplsRepository : ISateliteCD<CSICP_BB001Spls>
    {
        Task<IEnumerable<CSICP_BB001Spls>> GetAllByParentId(string parentId, int tenant);
    }
}
