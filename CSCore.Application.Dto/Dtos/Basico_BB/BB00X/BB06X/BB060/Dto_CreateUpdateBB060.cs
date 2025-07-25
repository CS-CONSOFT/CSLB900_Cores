using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB060
{
    public class Dto_CreateUpdateBB060
    {
        [MaxLength(10, ErrorMessage = "O código deve ter no máximo 10 caracteres.")]
        [Required(ErrorMessage = "O código é obrigatório.")]
        public string? Bb060Codigo { get; set; }

        [MaxLength(50, ErrorMessage = "A descrição deve ter no máximo 50 caracteres.")]
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string? Bb060Descricao { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor base deve ser maior ou igual a zero.")]
        public decimal? Bb060Vbase { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do centro de custo deve ter no máximo 36 caracteres.")]
        public string? Bb060Ccustoid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do usuário proprietário deve ter no máximo 36 caracteres.")]
        public string? Bb060Usuarioproprieid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do agente cobrador deve ter no máximo 36 caracteres.")]
        public string? Bb060Agcobradorid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do responsável deve ter no máximo 36 caracteres.")]
        public string? Bb060Responsavelid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da condição deve ter no máximo 36 caracteres.")]
        public string? Bb060Condicaoid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do tipo de cobrança deve ter no máximo 36 caracteres.")]
        public string? Bb060Tipocobrancaid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do usuário de inclusão deve ter no máximo 36 caracteres.")]
        public string? Bb060Usuarioinc { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do usuário de alteração deve ter no máximo 36 caracteres.")]
        public string? Bb060Usuarioalt { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data de inclusão é inválida.")]
        public string? Bb060Dthrinc { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data de alteração é inválida.")]
        public string? Bb060Dthralt { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da espécie deve ter no máximo 36 caracteres.")]
        public string? Bb060Especieid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da forma de pagamento deve ter no máximo 36 caracteres.")]
        public string? Bb060FpagtoId { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "O ID do convênio master deve ser maior ou igual a zero.")]
        public long? Bb060Convmasterid { get; set; }
    }
}
