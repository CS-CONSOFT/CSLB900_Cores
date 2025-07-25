using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Cnae
{
    public class Dto_LinkCnae
    {
        [NotNull]
        [Required(ErrorMessage = "A propriedade Bb001Id não pode ser nula.")]
        public string Bb001Id { get; set; } = string.Empty;

        [NotNull]
        [Required(ErrorMessage = "A propriedade Bb001CnaeId não pode ser nula.")]
        public string Bb001CnaeId { get; set; } = string.Empty;
        public bool? Bb001IscnaeFiscal { get; set; } = false;
    }
}
