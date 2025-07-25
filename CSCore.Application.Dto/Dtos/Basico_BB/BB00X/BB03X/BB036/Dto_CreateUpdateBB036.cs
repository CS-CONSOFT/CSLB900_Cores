using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB036
{
    public class Dto_CreateUpdateBB036
    {
        [MaxLength(50, ErrorMessage = "O primeiro nome deve ter no máximo 50 caracteres.")]
        public string? Bb036Primeironome { get; set; }

        [MaxLength(50, ErrorMessage = "O sobrenome deve ter no máximo 50 caracteres.")]
        public string? Bb036Sobrenome { get; set; }

        [MaxLength(50, ErrorMessage = "O nome da empresa deve ter no máximo 50 caracteres.")]
        public string? Bb036Empresa { get; set; }

        [MaxLength(250, ErrorMessage = "O e-mail deve ter no máximo 250 caracteres.")]
        public string? Bb036Email { get; set; }

        [MaxLength(250, ErrorMessage = "O e-mail secundário deve ter no máximo 250 caracteres.")]
        public string? Bb036Emailsecundario { get; set; }

        [MaxLength(50, ErrorMessage = "O título deve ter no máximo 50 caracteres.")]
        public string? Bb036Titulo { get; set; }

        [MaxLength(20, ErrorMessage = "O telefone deve ter no máximo 20 caracteres.")]
        public string? Bb036Telefone { get; set; }

        [MaxLength(20, ErrorMessage = "O celular deve ter no máximo 20 caracteres.")]
        public string? Bb036Celular { get; set; }

        [MaxLength(20, ErrorMessage = "O fax deve ter no máximo 20 caracteres.")]
        public string? Bb036Fax { get; set; }

        [MaxLength(100, ErrorMessage = "O site deve ter no máximo 100 caracteres.")]
        public string? Bb036Site { get; set; }

        [MaxLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
        public string? Bb036Descricao { get; set; }

        public int? Bb036TratamentoId { get; set; }

        public int? Bb036SituacaoId { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da atividade deve ter no máximo 36 caracteres.")]
        public string? Bb036Atividadeid { get; set; }
    }
}
