using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB032
{
    public class Dto_CreateUpdateBB032
    {
        [Required(ErrorMessage = "O código do cargo é obrigatório.")]
        public int? Bb032Codgcargoid { get; set; }

        [StringLength(60, ErrorMessage = "O nome do cargo não pode exceder 60 caracteres.")]
        public string? Bb032Cargo { get; set; }

    }
}
