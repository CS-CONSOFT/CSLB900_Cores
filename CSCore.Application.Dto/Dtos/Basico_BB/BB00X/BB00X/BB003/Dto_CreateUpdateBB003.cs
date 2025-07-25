using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X
{
    public class Dto_CreateUpdateBB003
    {
        [StringLength(30, ErrorMessage = "O campo Moeda deve ter no máximo 30 caracteres.")]
        public string Bb003Moeda { get; set; } = string.Empty;

        [StringLength(10, ErrorMessage = "O campo Sigla deve ter no máximo 10 caracteres.")]
        public string? Bb003Sigla { get; set; } = string.Empty;
    }
}
