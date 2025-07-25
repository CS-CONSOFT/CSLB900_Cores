using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSBS101._82Application.Dto.AA00X.AA013
{
    public class Dto_CreateUpdateAA013
    {
        [DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime? Aa013DataValidade { get; set; }

        [Range(0, (double)decimal.MaxValue, ErrorMessage = "O valor da filial deve ser positivo.")]
        [DefaultValue(0)]
        public decimal? Aa013Filial { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da filial deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Aa013Filialid { get; set; }

        [DefaultValue(false)]
        public bool? Aa013Isusocontigencia { get; set; }

        [DefaultValue(null)]
        public int? Aa013ModId { get; set; }

        [Range(0, (double)decimal.MaxValue, ErrorMessage = "O número deve ser positivo.")]
        [DefaultValue(0)]
        public decimal? Aa013Numero { get; set; }

        [MaxLength(9, ErrorMessage = "A série deve ter no máximo 9 caracteres.")]
        [DefaultValue("")]
        public string? Aa013Serie { get; set; }
    }
}
