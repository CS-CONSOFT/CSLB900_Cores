using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB004
{
    public class Dto_CreateUpdateBB004
    {
        [Required(ErrorMessage = "O campo Código é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O campo Código deve ser maior ou igual a 0.")]
        public int? Bb004Codigo { get; set; } = 0;

        [Required(ErrorMessage = "O campo Data de Câmbio é obrigatório.")]
        public DateTime? Bb004Datacambio { get; set; } = new DateTime(1900, 1, 1);

        [Required(ErrorMessage = "O campo Valor de Câmbio é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O Valor de Câmbio deve ser maior ou igual a 0.")]
        public decimal? Bb004Valorcambio { get; set; } = 0m;

        [StringLength(36, ErrorMessage = "O campo Moeda ID deve ter no máximo 36 caracteres.")]
        public string? Moedaid { get; set; } = null;
    }
}
