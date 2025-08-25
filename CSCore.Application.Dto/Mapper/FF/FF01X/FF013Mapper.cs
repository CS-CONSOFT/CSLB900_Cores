using CSBS101._82Application.ExtensionsMethods.BB00X;
using CSBS101._82Application.Mapper.BB00X.BB00X.BB001;
using CSBS101._82Application.Mapper.BB00X.BB012;
using CSCore.Application.Dto.Dtos.Financeiro_FF.FF01X.FF013;
using CSCore.Application.Dto.Mapper.FF.FF01X;
using CSCore.Application.Dto.Mapper.Sistema;
using CSCore.Domain.CS_Models.CSICP_FF;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF013;

namespace CSCore.Application.Dto.Mapper.FF.FF01X
{
    public static class FF013Mapper
    {
        public static DtoGetFF013 ToDtoGet(this RepoDtoCSICP_FF013 entity)
        {
            return new DtoGetFF013
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff013Filialid = entity.Ff013Filialid,
                Ff013Grupocobrancaid = entity.Ff013Grupocobrancaid,
                Ff013Cobradorid = entity.Ff013Cobradorid,
                Ff013Zonaid = entity.Ff013Zonaid,
                Ff013Contaid = entity.Ff013Contaid,
                Ff013Tpregistro = entity.Ff013Tpregistro,
                NavBB001 = entity.NavBB001?.ToDtoGetExibicao(),
                NavFF012 = entity.NavFF012?.ToDtoGetSimples(),
                NavSY001 = entity.NavSY001?.ToDtoGetSimples(),
                NavBB010 = entity.NavBB010?.ToDtoGetSimples(),
                NavBB012 = entity.NavBB012?.ToDtoBB012Exibicao()
            };
        }

        public static DtoGetFF013Simples ToDtoGetSimples(this CSICP_FF013 entity)
        {
            return new DtoGetFF013Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Ff013Filialid = entity.Ff013Filialid,
                Ff013Grupocobrancaid = entity.Ff013Grupocobrancaid,
                Ff013Cobradorid = entity.Ff013Cobradorid,
                Ff013Zonaid = entity.Ff013Zonaid,
                Ff013Contaid = entity.Ff013Contaid,
                Ff013Tpregistro = entity.Ff013Tpregistro
            };
        }
    }
}