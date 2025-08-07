namespace CSCore.Domain.Interfaces.Estatica
{
    public interface IStaticaLabelRepository
    {
        [Obsolete]
        Task<int> GetIDStaticasSimNao(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG054StaPorCodCS(int codCs);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG019CgBar(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG055StaPorCodCS(int codCs);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG001TAlmox(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG032TpInvPorCodCS(string codCs);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG032StaPorCodCS(string codCs);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG028NatOpLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG028EntSaidaLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG071StaPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG072StqPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG073StatusPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG073TMovPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeBB012_MRELPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG046StatusPorLabel(string label);
        [Obsolete]
        Task<int> csicp_bb012_GruCta(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeBB01201_con_PorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeBB061_TPPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypebb062_staPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeBB008_TPPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeE9ACSICP_StaticaPorLabel(string label);
        [Obsolete]
        Task<int> GetStaticasByTypeCC081PorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeFF102_EntPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeFF102_SitPorLabel(string label);
        [Obsolete]
        Task<int> csicp_ff120_trackApi(string label);
        [Obsolete]
        Task<int> csicp_ff112_cnab(string label);
        [Obsolete]
        Task<int> csicp_ff112_G028(string label);
        [Obsolete]
        Task<int> csicp_ff112_C026(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG030StaPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG023ValPorLabel(string Label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG045StatusPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeGG046SaidaPorLabel(string label);
        [Obsolete]
        Task<int> GetIDStaticasByTypeFF105_TpPorLabel(string label);


        Task<int> GetIDStaticaByLabel<T>(string label, string idPropertyName = "Id") where T : class;
        Task<int> GetIDStaticaByLabelWithoutIsActive<T>(string label, string idPropertyName = "Id") where T : class;
        Task<int> GetIDStaticaByCodCS<T>(int codCs, string idPropertyName = "Id") where T : class;
    }
}
