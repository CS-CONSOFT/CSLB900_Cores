using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA040
    {
        [MaxLength(36, ErrorMessage = "O identificador da UF de origem deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa040UforigemId { get; set; }

        [MaxLength(36, ErrorMessage = "O identificador da UF de destino deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa040UfdestinoId { get; set; }

        [Range(0, 99.99, ErrorMessage = "A alíquota deve estar entre 0 e 99,99.")]
        [DefaultValue(0.00)]
        public decimal? Aa040Paliquota { get; set; }
    }
}
