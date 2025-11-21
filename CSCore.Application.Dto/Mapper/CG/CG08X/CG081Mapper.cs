using CSCore.Application.Dto.Dtos.CG.CG081;
using CSCore.Domain.CS_Models.CSICP_CG;

namespace CSCore.Application.Dto.Mapper.CG.CG08X
{
    public static class CG081Mapper
    {
        public static DtoGetCG081 ToDtoGet(this Osusr8dwCsicpCg081 entity)
        {
            return new DtoGetCG081
            {
                TenantId = entity.TenantId,
                Cg081Id = entity.Cg081Id,
                Cg081Contrelconfid = entity.Cg081Contrelconfid,
                Cg081Asid = entity.Cg081Asid,
                Cg081Txdescricao = entity.Cg081Txdescricao,
                Cg081Contrelregistrosup = entity.Cg081Contrelregistrosup,
                Cg081Naturezasaldo = entity.Cg081Naturezasaldo,
                Cg081Nrlinha = entity.Cg081Nrlinha,
                Cg081Nrgrau = entity.Cg081Nrgrau,
                Cg081Fllinharetaap = entity.Cg081Fllinharetaap,
                Cg081Fllinhatracap = entity.Cg081Fllinhatracap,
                Cg081Flnegrito = entity.Cg081Flnegrito,
                Cg081Flespacobranco = entity.Cg081Flespacobranco,
                Cg081Txnotaexplicativa = entity.Cg081Txnotaexplicativa,
                Cg081Isnewpage = entity.Cg081Isnewpage,
                Cg081Treeorder = entity.Cg081Treeorder
            };
        }
    }
}