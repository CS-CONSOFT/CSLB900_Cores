namespace CSCore.Domain.Interfaces.Estatica
{
    public interface IStaticaLabelRepository
    {
        Task<int> GetIDStaticasSimNao(string label);
        Task<int> GetIDStaticasByTypeGG054StaPorCodCS(int codCs);
        Task<int> GetIDStaticasByTypeGG019CgBar(string label);
        Task<int> GetIDStaticasByTypeGG055StaPorCodCS(int codCs);
        Task<int> GetIDStaticasByTypeGG001TAlmox(string label);
        Task<int> GetIDStaticasByTypeGG032TpInvPorCodCS(string codCs);
        Task<int> GetIDStaticasByTypeGG032StaPorCodCS(string codCs);
        Task<int> GetIDStaticasByTypeGG028NatOpLabel(string label);
        Task<int> GetIDStaticasByTypeGG028EntSaidaLabel(string label);
        Task<int> GetIDStaticasByTypeGG071StaPorLabel(string label);
        Task<int> GetIDStaticasByTypeGG072StqPorLabel(string label);
        Task<int> GetIDStaticasByTypeGG073StatusPorLabel(string label);
        Task<int> GetIDStaticasByTypeGG073TMovPorLabel(string label);
        Task<int> GetIDStaticasByTypeBB012_MRELPorLabel(string label);
        Task<int> GetIDStaticasByTypeGG046StatusPorLabel(string label);
        Task<int> csicp_bb012_GruCta(string label);
        Task<int> GetIDStaticasByTypeBB01201_con_PorLabel(string label);
        Task<int> GetIDStaticasByTypeBB061_TPPorLabel(string label);
        Task<int> GetIDStaticasByTypebb062_staPorLabel(string label);
        Task<int> GetIDStaticasByTypeBB008_TPPorLabel(string label);
        Task<int> GetIDStaticasByTypeE9ACSICP_StaticaPorLabel(string label);
        Task<int> GetStaticasByTypeCC081PorLabel(string label);
        Task<int> GetIDStaticasByTypeFF102_EntPorLabel(string label);
        Task<int> GetIDStaticasByTypeFF102_SitPorLabel(string label);
        Task<int> csicp_ff120_trackApi(string label);
        Task<int> csicp_ff112_cnab(string label);
        Task<int> csicp_ff112_G028(string label);
        Task<int> csicp_ff112_C026(string label);
        Task<int> GetIDStaticasByTypeGG030StaPorLabel(string label);
        Task<int> GetIDStaticasByTypeGG023ValPorLabel(string Label);
        Task<int> GetIDStaticasByTypeGG045StatusPorLabel(string label);
        Task<int> GetIDStaticasByTypeGG046SaidaPorLabel(string label);
        Task<int> GetIDStaticasByTypeFF105_TpPorLabel(string label);

    }
}
