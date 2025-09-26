using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF00X.FF007;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Application.Dto.Mapper.FF.FF00X
{
    public static class FF007Mapper
    {
        public static DtoGetFF007 ToDtoGet(this CSICP_FF007 entity)
        {
            return new DtoGetFF007
            {
                TenantId = entity.TenantId,
                Ff007Id = entity.Ff007Id,
                Ff007Estabid = entity.Ff007Estabid,
                Ff007Diasate = entity.Ff007Diasate,
                Ff007Pdesconto = entity.Ff007Pdesconto,
                NavBB001 = entity.NavBB001?.ToDtoGetSimples()
            };
        }
    }
}

