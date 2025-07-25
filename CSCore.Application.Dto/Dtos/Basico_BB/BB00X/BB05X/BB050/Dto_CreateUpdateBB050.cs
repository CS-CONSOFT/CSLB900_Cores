using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB05X.BB050
{
    public class Dto_CreateUpdateBB050
    {
        [MaxLength(36, ErrorMessage = "O ID da empresa deve ter no máximo 36 caracteres.")]
        public string? Bb050Empresaid { get; set; }

        [MaxLength(36, ErrorMessage = "O ID do grupo de produto deve ter no máximo 36 caracteres.")]
        public string? Bb050Grupoprodutoid { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data de início é inválida.")]
        public DateTime? Bb050Datainicio { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data final é inválida.")]
        public DateTime? Bb050Datafinal { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor mínimo deve ser maior ou igual a zero.")]
        public decimal? Bb050Valorminimo { get; set; }
    }
}
