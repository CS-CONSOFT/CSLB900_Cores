namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB007dRepository : ISateliteCD<CSICP_BB007d>
    {
        Task<IEnumerable<CSICP_BB007d>> GetAllByParentId(string resId, int tenant);

        //PEGA TUDO PELO ALMOXARIFE PARA USAR NO GET ID DA BB007_ID
        Task<IEnumerable<CSICP_BB007d>> GetAllToUseOnBB007(string bb007Id, int tenant);
    }
}
