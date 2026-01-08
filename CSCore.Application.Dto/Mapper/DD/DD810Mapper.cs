using CSCore.Application.Dto.Dtos.DD.DD810;
using CSCore.Domain.CS_Models.CSICP_DD;

namespace CSCore.Application.Dto.Mapper.DD
{
    public static class DD810Mapper
    {
        public static DtoGetDD810 ToDtoGet(this CSICP_DD810 entity)
        {
            return new DtoGetDD810
            {
                TenantId = entity.TenantId,
                Dd810Id = entity.Dd810Id,
                Dd810CfopSaida = entity.Dd810CfopSaida,
                Dd810CfopEntrada = entity.Dd810CfopEntrada,
                Dd810Anotacao = entity.Dd810Anotacao,
                Dd810Hashid = entity.Dd810Hashid,
                NavDD810_CFOP_Saida = entity.NavDD810_CFOP_Saida,
                NavDD810_CFOP_Entrada = entity.NavDD810_CFOP_Entrada
            };
        }
    }
}