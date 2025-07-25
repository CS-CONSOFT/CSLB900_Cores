using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Ifs.GG.Repository.GG._05X.Coleta.Comparar
{
    public interface IComparaColeta
    {
        Task<(List<CSICP_GG055> ProdutosSoNaColeta01,
                   List<CSICP_GG055> ProdutosSoNaColeta02,
                   List<CSICP_GG055> ProdutosComQuantidadeDiferente,
                   List<CSICP_GG055> TodosOsProdutos)> CompararColeta(ParametrosCompararColeta prm);
    }
}
