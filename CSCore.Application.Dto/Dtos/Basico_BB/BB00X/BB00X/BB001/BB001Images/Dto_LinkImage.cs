using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Images
{
    public class Dto_LinkImage
    {
        [NotNull]
        [Required(ErrorMessage = "O campo Empresaid não pode ser nulo")]
        public string Empresaid { get; set; } = string.Empty;

        [NotNull]
        [Required(ErrorMessage = "O campo Status não pode ser nulo")]
        public int Status { get; set; }

        [NotNull]
        [Required(ErrorMessage = "O campo Nome não pode ser nulo")]
        public string Nome { get; set; } = string.Empty;

        [NotNull]
        [Required(ErrorMessage = "O campo Tipo não pode ser nulo")]
        public string Tipo { get; set; } = string.Empty;

        public byte[]? Imagem { get; set; } = null;

        public bool? ExibirEmformapagto { get; set; } = false;


        public string? Filename { get; set; } = string.Empty;

        public string? Path { get; set; } = string.Empty;
    }
}
