using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR020;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021
{
    public class DtoGetRR021
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr021Loteid { get; set; }

        public string? Rr021Animalid { get; set; }

        public DateTime? Rr021Dtregistro { get; set; }

        // Navegações
        public DtoGetRR001? NavRR001Animal { get; set; }
        //public DtoGetRR020Padrao? NavRR020RegLote { get; set; }
    }
}