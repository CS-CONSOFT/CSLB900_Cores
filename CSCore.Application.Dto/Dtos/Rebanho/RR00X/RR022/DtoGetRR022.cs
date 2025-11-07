using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR001;
using CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR021;

namespace CSCore.Application.Dto.Dtos.Rebanho.RR00X.RR022
{
    public class DtoGetRR022
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Rr022Loteid { get; set; }

        public string? Rr022Animalid { get; set; }

        public DateTime? Rr022Dtpeso { get; set; }

        public int? Rr022Idadediasatual { get; set; }

        public decimal? Rr022Peso { get; set; }

        public DateTime? Rr001Dtultpeso { get; set; }

        public decimal? Rr001Ultpeso { get; set; }

        public int? Rr022Idadediasult { get; set; }

        public decimal? Rr022Gmd { get; set; }

        public decimal? Rr022Gpd { get; set; }

        public DateTime? Rr022Dthrregistro { get; set; }

        public string? Rr022Usuarioid { get; set; }

        public bool? Rr022IsProcessado { get; set; }

        // Navegações
        public DtoGetRR001Padrao? NavRR001Animal { get; set; }
        public DtoGetRR021Padrao? NavRR021LoteXAnimal { get; set; }
    }
}