using FF105Financeiro.C82Application.Dto.GG00X.GG001;
using FF105Financeiro.C82Application.Dto.GG00X.GG002;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG100
{
    public class DtoGetGG100
    {
        public int TenantId { get; set; }

        public long Gg100Id { get; set; }

        public string? Gg100Estabid { get; set; }

        public string? Gg100PdvendaAlmoxid { get; set; }

        public string? Gg100Pdtransfalmoxid2 { get; set; }

        public string? Gg100Pdtipoprodutoid { get; set; }

        public bool? Gg100Iscopia { get; set; }

        public string? Gg100AwsBucket { get; set; }

        public string? Gg100Awsregion { get; set; }

        public string? Gg100Awsaccesskeyid { get; set; }

        public string? Gg100Awssecretaccesskey { get; set; }

        public DtoGetGG002? Gg100Pdtipoproduto { get; set; }

        public DtoGetGG001Simples? Gg100Pdtransfalmoxid2Navigation { get; set; }

        public DtoGetGG001Simples? Gg100PdvendaAlmox { get; set; }
    }
}
