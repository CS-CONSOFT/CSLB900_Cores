using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB056
{
    public class Dto_CreateUpdateBB056
    {
        [MaxLength(36, ErrorMessage = "O ID do profissional deve ter no máximo 36 caracteres.")]
        public string? Bb056Profid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da conta deve ter no máximo 36 caracteres.")]
        public string? Bb056Contaid { get; set; }

        [MaxLength(100, ErrorMessage = "A mensagem deve ter no máximo 100 caracteres.")]
        public string? Bb056Mensagem { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "A avaliação deve ser maior ou igual a 0.")]
        public decimal? Bb056Rate { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data e hora inválidas.")]
        public DateTime? Bb056Datahora { get; set; }

        public bool? Bb056Isactive { get; set; }

        public bool? Bb056Issmsenviadoprof { get; set; }

        public bool? Bb056Issmsenviadocliente { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data e hora do SMS do profissional inválidas.")]
        public DateTime? Bb056Dtsmsprof { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data e hora do SMS do cliente inválidas.")]
        public DateTime? Bb056Dtsmscliente { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do tenant deve ter no máximo 36 caracteres.")]
        public string? TenantId { get; set; }
    }
}
