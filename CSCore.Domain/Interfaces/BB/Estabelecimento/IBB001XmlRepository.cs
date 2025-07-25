namespace CSCore.Domain.Interfaces.BB.Estabelecimento
{
    public interface IBB001XmlRepository : ISateliteCD<CSICP_BB001_AXML>
    {
        Task<IEnumerable<CSICP_BB001_AXML>> GetAllByParentId(string parentId, int tenant);
    }
}
