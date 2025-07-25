using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB061
{
    public class Dto_CreateUpdateBB061
    {
        [Range(0, long.MaxValue, ErrorMessage = "O ID do convênio deve ser maior ou igual a zero.")]
        public long? Bb060Convenioid { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O tipo de associação deve ser maior ou igual a zero.")]
        public int? Bb061Tipoassid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da conta deve ter no máximo 36 caracteres.")]
        public string? Bb012Contaid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do dependente deve ter no máximo 36 caracteres.")]
        public string? Bb061Dependenteid { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a zero.")]
        public decimal? Bb061Valor { get; set; }
    }
}
