using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB051
{
    public class Dto_CreateUpdateBB051
    {
        [Required(ErrorMessage = "O ID é obrigatório.")]
        [MaxLength(36, ErrorMessage = "O ID deve ter no máximo 36 caracteres.")]
        public string? Bb050Id { get; set; }

        [Required(ErrorMessage = "O ID da forma de pagamento é obrigatório.")]
        [MaxLength(36, ErrorMessage = "O ID da forma de pagamento deve ter no máximo 36 caracteres.")]
        public string? Bb051Formapagtoid { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O número máximo de parcelas deve ser maior ou igual a 0.")]
        public int? Bb051Maxparcela { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do tenant deve ter no máximo 36 caracteres.")]
        public string? TenantId { get; set; }
    }
}
