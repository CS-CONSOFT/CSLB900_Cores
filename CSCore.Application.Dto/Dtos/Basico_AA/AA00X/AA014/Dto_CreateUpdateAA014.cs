using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA014
    {
        [DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime? Aa014Dregistro { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da série deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa014Serienfid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do usuário deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa014Usuarioid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do usuário proprietário deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa014Usuariopropid { get; set; }
    }
}
