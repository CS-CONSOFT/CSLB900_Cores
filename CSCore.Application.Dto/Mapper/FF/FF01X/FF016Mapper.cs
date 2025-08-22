using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF016;
using CSCore.Domain.CS_Models.CSICP_FF;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF016;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF016Mapper
    {
        public static DtoGetFF016 ToDtoGet(this RepoDtoCSICP_FF016 entity)
        {
            return new DtoGetFF016
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff016DescricaoCarta = entity.Ff016DescricaoCarta,
                Ff016Texto = entity.Ff016Texto,
                Ff016EmailsdestId = entity.Ff016EmailsdestId,
                Ff016Textocarta = entity.Ff016Textocarta,
                NavFF016Email = entity.NavFF016Email,
            };
        }
    }
}
