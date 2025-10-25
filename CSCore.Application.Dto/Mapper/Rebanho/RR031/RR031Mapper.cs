using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR031;
using CSCore.Application.Dto.Mapper.Rebanho.RR001;
using CSCore.Application.Dto.Mapper.Rebanho.RR030;
using CSCore.Application.Dto.Mapper.Rebanho.RR035;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR031
{
    public static class RR031Mapper
    {
        public static DtoGetRR031 ToDtoGetRR031(this OsusrTo3CsicpRr031 entity)
        {
            return new DtoGetRR031
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr031IatfId = entity.Rr031IatfId,
                Rr031Animalid = entity.Rr031Animalid,
                Rr031Dtregistro = entity.Rr031Dtregistro,
                Rr031Ispositivo = entity.Rr031Ispositivo,
                Rr031Montaanimalid = entity.Rr031Montaanimalid,
                Rr031Semenid = entity.Rr031Semenid,

                // Navegações
                NavRR001Animal = entity.NavRR001Animal_RR031?.ToDtoGetRR001Padrao(),
                NavRR030Iatf = entity.NavRR030Iatf_RR031?.ToDtoGetRR030(),
                NavRR001MontaAnimal = entity.NavRR001MontaAnimal_RR031?.ToDtoGetRR001Padrao(),
                NavRR035Semen = entity.NavRR035Semen_RR031?.ToDtoGetRR035Padrao()
            };
        }

        public static DtoGetRR031Padrao ToDtoGetRR031Padrao(this OsusrTo3CsicpRr031 entity)
        {
            return new DtoGetRR031Padrao
            {
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr031IatfId = entity.Rr031IatfId,
                Rr031Animalid = entity.Rr031Animalid,
                Rr031Dtregistro = entity.Rr031Dtregistro,
                Rr031Ispositivo = entity.Rr031Ispositivo,
                Rr031Montaanimalid = entity.Rr031Montaanimalid,
                Rr031Semenid = entity.Rr031Semenid
            };
        }
    }
}