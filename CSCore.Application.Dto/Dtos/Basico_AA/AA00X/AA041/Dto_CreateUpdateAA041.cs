using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA041
    {
        [DefaultValue(null)]
        public int? Aa041TabspedId { get; set; }

        [MaxLength(20, ErrorMessage = "O código deve ter no máximo 20 caracteres.")]
        [DefaultValue("")]
        public string? Aa041Codigo { get; set; }

        [MaxLength(250, ErrorMessage = "A descrição deve ter no máximo 250 caracteres.")]
        [DefaultValue("")]
        public string? Aa041Descricao { get; set; }

        [DefaultValue(null)]
        public DateTime? Aa041Dinicio { get; set; }

        [DefaultValue(null)]
        public DateTime? Aa041Dfinal { get; set; }
    }
}
