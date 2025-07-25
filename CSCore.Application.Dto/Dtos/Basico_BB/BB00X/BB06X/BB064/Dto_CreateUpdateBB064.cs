using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB064
{
    public class Dto_CreateUpdateBB064
    {
        [MaxLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres.")]
        public string? Bb064Descricao { get; set; }
    }
}
