namespace CSCore.Domain.Interfaces.BB.Estabelecimento
{
    public interface IBB001ImgRepository : ISateliteCD<CSICP_BB001Img>
    {
        Task<IEnumerable<CSICP_BB001Img>> GetAllByParentId(string parentId, int tenant);
        Task GetBB001UpdateImgPadrao(int tenant, string Id, string estabLogadoId);
    }
}
