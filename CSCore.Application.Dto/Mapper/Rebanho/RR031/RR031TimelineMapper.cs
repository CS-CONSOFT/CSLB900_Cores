using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR031;
using CSCore.Application.Dto.Mapper.Rebanho.RR001;
using CSCore.Application.Dto.Mapper.Rebanho.RR030;
using CSCore.Application.Dto.Mapper.Rebanho.RR035;
using CSCore.Domain.CS_Models.CSICP_RR;

namespace CSCore.Application.Dto.Mapper.Rebanho.RR031
{
    public static class RR031TimelineMapper
    {
        public static DtoGetRR031Timeline ToDtoGetRR031Timeline(this OsusrTo3CsicpRr031 entity)
        {
            return new DtoGetRR031Timeline
            {
                // Dados completos da RR031
                TenantId = entity.TenantId,
                Id = entity.Id,
                Rr031IatfId = entity.Rr031IatfId,
                Rr031Animalid = entity.Rr031Animalid,
                Rr031Dtregistro = entity.Rr031Dtregistro,
                Rr031Ispositivo = entity.Rr031Ispositivo,
                Rr031Montaanimalid = entity.Rr031Montaanimalid,
                Rr031Semenid = entity.Rr031Semenid,
                Rr031Tiporeg = entity.Rr031Tiporeg,
                Rr031Isabsorveu = entity.Rr031Isabsorveu,
                
                // Usando mappers Padrao para evitar ciclos infinitos
                RR030IATF = entity.NavRR030Iatf_RR031?.ToDtoGetRR030(),
                RR001Animal = entity.NavRR001Animal_RR031?.ToDtoGetRR001Padrao(),
                RR001AnimalMonta = entity.NavRR001MontaAnimal_RR031?.ToDtoGetRR001Padrao(),
                RR031Semen = entity.NavRR035Semen_RR031?.ToDtoGetRR035Padrao()
            };
        }

        public static List<DtoGetRR031Timeline> ToDtoGetRR031TimelineList(this List<OsusrTo3CsicpRr031> entities)
        {
            return entities.Select(e => e.ToDtoGetRR031Timeline()).ToList();
        }
    }
}