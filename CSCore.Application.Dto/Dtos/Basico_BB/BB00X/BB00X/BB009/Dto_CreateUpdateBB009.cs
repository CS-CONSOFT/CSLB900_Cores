using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB009
{
    public class Dto_CreateUpdateBB009
    {
        [Required(ErrorMessage = "O campo Filial é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O campo Filial deve ser maior ou igual a 0.")]
        public int? Bb009Filial { get; set; } = 0;

        [Required(ErrorMessage = "O campo Código é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O campo Código deve ser maior ou igual a 0.")]
        public int? Bb009Codigo { get; set; } = 0;

        [StringLength(30, ErrorMessage = "O campo Tipo de Cobrança deve ter no máximo 30 caracteres.")]
        [Required(ErrorMessage = "O campo Tipo de Cobrança é obrigatório.")]
        public string? Bb009Tipocobranca { get; set; } = string.Empty;

        [StringLength(36, ErrorMessage = "O campo Empresa ID deve ter no máximo 36 caracteres.")]
        public string? Empresaid { get; set; } = null;
    }
}
