using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR030;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR035;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR031
{
    public class DtoGetRR031
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr031IatfId { get; set; }

        public string? Rr031Animalid { get; set; }

        public DateTime? Rr031Dtregistro { get; set; }

        public bool? Rr031Ispositivo { get; set; }

        public string? Rr031Montaanimalid { get; set; }

        public string? Rr031Semenid { get; set; }

        // Navegações
        public DtoGetRR001Padrao? NavRR001Animal { get; set; }
        public DtoGetRR030? NavRR030Iatf { get; set; }
        public DtoGetRR001Padrao? NavRR001MontaAnimal { get; set; }
        public DtoGetRR035Padrao? NavRR035Semen { get; set; }
    }
}