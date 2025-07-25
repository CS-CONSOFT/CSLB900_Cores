using CSBS101._82Application.Dto.BB00X.BB001;
using CSBS101._82Application.Dto.BB00X.BB05X.BB056;
using CSBS101._82Application.Dto.BB00X.BB05X.BB057;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB055
{
    public class Dto_GetBB055
    {
        public int TenantId { get; set; }

        public string Bb055Id { get; set; } = null!;

        public string? Bb055Nome { get; set; }

        public string? Bb055Email { get; set; }

        public string? Bb055Telefone { get; set; }

        public bool? Bb055IsActive { get; set; }

        public string? Bb055Logradouro { get; set; }

        public string? Bb055Numero { get; set; }

        public string? Bb055Complemento { get; set; }

        public string? Bb055Perimetro { get; set; }

        public string? Bb055Bairro { get; set; }

        public string? Bb055Cidadeid { get; set; }

        public string? Bb055UfId { get; set; }

        public int? Bb055Cep { get; set; }

        public string? Bb055Paisid { get; set; }

        public string? Bb055Nomecontato { get; set; }

        public string? Bb055CelularContato { get; set; }

        public string? Bb055EmailContato { get; set; }

        public string? Bb055UrlLogo { get; set; }

        public string? Bb055UrlAvatar { get; set; }

        public string? Bb055Desespecialidade { get; set; }

        public string? Bb055UrlSeloqld { get; set; }

        public decimal? Bb055Ratemedia { get; set; }

        public string? Bb055Tags { get; set; }

        public List<Dto_GetBB056> NavBB056_Avaliacao_List { get; set; } = [];
        public List<Dto_GetBB057> NavBB057_Click_List { get; set; } = [];
        public Dto_Enderecamento? NavEndereco { get; set; }

    }
}
