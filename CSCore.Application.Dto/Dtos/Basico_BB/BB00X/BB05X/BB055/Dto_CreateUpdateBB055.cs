using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB055
{
    public class Dto_CreateUpdateBB055
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string? Bb055Nome { get; set; }


        [MaxLength(250, ErrorMessage = "O e-mail deve ter no máximo 250 caracteres.")]
        public string? Bb055Email { get; set; }

        [MaxLength(20, ErrorMessage = "O telefone deve ter no máximo 20 caracteres.")]
        public string? Bb055Telefone { get; set; }

        public bool? Bb055IsActive { get; set; }

        [MaxLength(200, ErrorMessage = "O logradouro deve ter no máximo 200 caracteres.")]
        public string? Bb055Logradouro { get; set; }

        [MaxLength(10, ErrorMessage = "O número deve ter no máximo 10 caracteres.")]
        public string? Bb055Numero { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento deve ter no máximo 50 caracteres.")]
        public string? Bb055Complemento { get; set; }

        [MaxLength(100, ErrorMessage = "O perímetro deve ter no máximo 100 caracteres.")]
        public string? Bb055Perimetro { get; set; }

        public string? Bb055Bairro { get; set; }

        public string? Bb055Cidadeid { get; set; }

        public string? Bb055UfId { get; set; }

        public int? Bb055Cep { get; set; }

        public string? Bb055Paisid { get; set; }

        [MaxLength(100, ErrorMessage = "O nome do contato deve ter no máximo 100 caracteres.")]
        public string? Bb055Nomecontato { get; set; }

        [MaxLength(20, ErrorMessage = "O celular do contato deve ter no máximo 20 caracteres.")]
        public string? Bb055CelularContato { get; set; }

        public string? Bb055EmailContato { get; set; }

        public string? Bb055UrlLogo { get; set; }

        public string? Bb055UrlAvatar { get; set; }

        [MaxLength(500, ErrorMessage = "A descrição da especialidade deve ter no máximo 500 caracteres.")]
        public string? Bb055Desespecialidade { get; set; }

        public string? Bb055UrlSeloqld { get; set; }
        public decimal? Bb055Ratemedia { get; set; }

        public string? Bb055Tags { get; set; }
    }
}
