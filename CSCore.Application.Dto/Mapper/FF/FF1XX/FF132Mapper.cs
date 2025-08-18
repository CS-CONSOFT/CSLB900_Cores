using CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF132;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF132;

namespace CSCore.Application.Dto.Mapper.FF.FF1XX
{
    public static class FF132Mapper
    {
        public static DtoGetFF132 ToDtoGetFF132(this RepoDtoCSICP_FF132 entity)
        {
            return new DtoGetFF132
            {
                TenantId = entity.TenantId,
                Ff132Id = entity.Ff132Id,
                Ff131Id = entity.Ff131Id,
                Ff102Id = entity.Ff102Id,
                NavFF131 = entity.NavFF131?.ToDtoGet_SemNavs(),
                NavFF102 = entity.NavFF102?.ToDtoGet_Exibicao()
            };
        }
    }
}
