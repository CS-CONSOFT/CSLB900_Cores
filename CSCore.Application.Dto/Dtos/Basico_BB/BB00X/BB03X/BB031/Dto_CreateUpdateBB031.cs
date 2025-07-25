using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB031
{
    public class Dto_CreateUpdateBB031
    {
        [Required(ErrorMessage = "O código da função é obrigatório.")]
        public int? Bb031Codgfuncaoid { get; set; }

        [StringLength(60, ErrorMessage = "A descrição não pode exceder 60 caracteres.")]
        public string? Bb031Descricao { get; set; }

        [StringLength(10, ErrorMessage = "O CBO não pode exceder 10 caracteres.")]
        public string? Bb031Cbo { get; set; }
    }
}
