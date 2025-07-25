using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB029
{
    public class Dto_CreateUpdateBB029
    {
        public int? Bb029Codgcategoria { get; set; }

        [StringLength(30, ErrorMessage = "A categoria não pode exceder 30 caracteres.")]
        public string? Bb029Categoria { get; set; }

    }
}
