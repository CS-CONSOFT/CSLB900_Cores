namespace CSCore.Domain.Interfaces.BB.Estabelecimento
{
    public interface IBB001CnaesRepository : ISateliteCD<CSICP_BB001Cnaes>
    {
        Task<IEnumerable<CSICP_BB001Cnaes>> GetAllByParentId(string parentId, int tenant);
    }
}
