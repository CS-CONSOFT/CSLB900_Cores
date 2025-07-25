using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB062
{
    public class Dto_CreateUpdateBB062
    {
        [Range(0, int.MaxValue, ErrorMessage = "O ano deve ser maior ou igual a zero.")]
        public int? Bb062Ano { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O mês deve ser maior ou igual a zero.")]
        public int? Bb062Mes { get; set; }

        [MaxLength(50, ErrorMessage = "O descritivo deve ter no máximo 50 caracteres.")]
        public string? Bb062Descritivo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data de emissão deve ser uma data válida.")]
        public DateTime? Bb062Dtemissao { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do dia de vencimento deve ter no máximo 36 caracteres.")]
        public string? Bb062Diavenctoid { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O status deve ser maior ou igual a zero.")]
        public int? Bb062Statusid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do estabelecimento deve ter no máximo 36 caracteres.")]
        public string? Bb062Estabid { get; set; }
    }
}
