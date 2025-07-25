using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB067
{
    public class Dto_CreateUpdateBB067
    {
        [StringLength(10, ErrorMessage = "O código deve ter no máximo 10 caracteres.")]
        public string? Bb067Codigo { get; set; }

        [StringLength(50, ErrorMessage = "A descrição deve ter no máximo 50 caracteres.")]
        public string? Bb067Descricao { get; set; }
    }
}
