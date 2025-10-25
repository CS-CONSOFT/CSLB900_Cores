using CSCore.Domain.CS_Models.CSICP_GG;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG100
{
    public class DtoCreateUpdateGG100 : IConverteParaEntidade<CSICP_GG100>
    {
        public string? Gg100Estabid { get; set; }

        public string? Gg100PdvendaAlmoxid { get; set; }

        public string? Gg100Pdtransfalmoxid2 { get; set; }

        public string? Gg100Pdtipoprodutoid { get; set; }

        public bool? Gg100Iscopia { get; set; }

        public string? Gg100AwsBucket { get; set; }

        public string? Gg100Awsregion { get; set; }

        public string? Gg100Awsaccesskeyid { get; set; }

        public string? Gg100Awssecretaccesskey { get; set; }

        public CSICP_GG100 ToEntity(int tenant, string? id)
        {
            return new CSICP_GG100
            {
                TenantId = tenant,
                Gg100Estabid = this.Gg100Estabid,
                Gg100PdvendaAlmoxid = this.Gg100PdvendaAlmoxid,
                Gg100Pdtransfalmoxid2 = this.Gg100Pdtransfalmoxid2,
                Gg100Pdtipoprodutoid = this.Gg100Pdtipoprodutoid,
                Gg100Iscopia = this.Gg100Iscopia,
                Gg100AwsBucket = this.Gg100AwsBucket,
                Gg100Awsregion = this.Gg100Awsregion,
                Gg100Awsaccesskeyid = this.Gg100Awsaccesskeyid,
                Gg100Awssecretaccesskey = this.Gg100Awssecretaccesskey,
            };
        }
    }
}
