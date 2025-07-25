namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB007cRepository : ISateliteCD<CSICP_BB007c>
    {
        Task<IEnumerable<CSICP_BB007c>> GetAllByParentId(string resId, int tenant);
        //RECUPERA TUDO PARA USAR NO BB007 COM A BB012
        Task<IEnumerable<CSICP_BB007c>> GetAllToUseOnBB007(string bb007Id, int tenant);
    }
}
