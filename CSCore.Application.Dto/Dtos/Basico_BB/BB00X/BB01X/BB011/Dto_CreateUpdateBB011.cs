using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB011
{
    public class Dto_CreateUpdateBB011
    {
        public int? Bb011Codigo { get; set; }

        [MaxLength(30, ErrorMessage = "Atividade não pode ultrapassar 30 caracteres")]
        public string? Bb011Atividade { get; set; }
    }
}
