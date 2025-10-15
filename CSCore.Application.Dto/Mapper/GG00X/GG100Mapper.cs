using CSCore.Application.Dto.Dtos.Materiais_GG.GG00X.GG100;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Application.Dto.Mapper.GG00X;

namespace CSCore.Application.Dto.Mapper.GG00X
{
    public static class GG100Mapper
    {
        public static DtoGetGG100 ToDtoGet(this CSICP_GG100 entity)
        {
            return new DtoGetGG100
            {
                TenantId = entity.TenantId,
                Gg100Id = entity.Gg100Id,
                Gg100Estabid = entity.Gg100Estabid,
                Gg100PdvendaAlmoxid = entity.Gg100PdvendaAlmoxid,
                Gg100Pdtransfalmoxid2 = entity.Gg100Pdtransfalmoxid2,
                Gg100Pdtipoprodutoid = entity.Gg100Pdtipoprodutoid,
                Gg100Iscopia = entity.Gg100Iscopia,
                Gg100AwsBucket = entity.Gg100AwsBucket,
                Gg100Awsregion = entity.Gg100Awsregion,
                Gg100Awsaccesskeyid = entity.Gg100Awsaccesskeyid,
                Gg100Awssecretaccesskey = entity.Gg100Awssecretaccesskey,
                Gg100Pdtipoproduto = entity.Gg100Pdtipoproduto?.ToDtoGet(),
                Gg100Pdtransfalmoxid2Navigation = entity.Gg100Pdtransfalmoxid2Navigation?.ToDtoGetSimples(),
                Gg100PdvendaAlmox = entity.Gg100PdvendaAlmox?.ToDtoGetSimples(),
            };
        }
    }
}
