using System.ComponentModel.DataAnnotations;

namespace CSSY103.C82Application.Dto.SY001.SY001
{
    public class DtoAlteraSenha
    {
        [Required(ErrorMessage = "Nova senha não pode ser nula")]
        public string NovaSenha { get; set; } = null!;
    }
}
