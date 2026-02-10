using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR009;
using CSCore.Application.Dto.Mapper.Rebanho.RR001;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR009
{
    public static class RR009Mapper
    {
        public static DtoGetRR009 ToDtoGetRR009(this OsusrTo3CsicpRr009 entity)
        {
            return new DtoGetRR009
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr001Id = entity.Rr001Id!,
                Rr001Virtualid = entity.Rr001Virtualid!,
                NavRR001Animal = entity.NavRR001Animal_RR009?.ToDtoGetRR001Padrao(),
                NavRR001AnimalVirtual = entity.NavRR001AnimalVirtual_RR009?.ToDtoGetRR001Padrao()


            };
        }

        public static DtoGetRR009Simples ToDtoGetRR009Simples(this OsusrTo3CsicpRr009 entity)
        {
            return new DtoGetRR009Simples
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr001Id = entity.Rr001Id!,
                Rr001Virtualid = entity.Rr001Virtualid!
            };
        }
    }
}