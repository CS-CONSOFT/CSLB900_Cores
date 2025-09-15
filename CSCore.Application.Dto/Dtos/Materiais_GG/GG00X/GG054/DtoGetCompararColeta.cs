using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG055;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG054
{
    public class DtoGetCompararColeta
    {
        public List<DtoGetGG055> ProdutosSoNaColeta01 { get; set; } = [];
        public List<DtoGetGG055> ProdutosSoNaColeta02 { get; set; } = [];
        public List<DtoGetGG055> ProdutosComQuantidadeDiferente { get; set; } = [];
        public List<DtoGetGG055> TodosOsProdutos { get; set; } = [];
    }
}
