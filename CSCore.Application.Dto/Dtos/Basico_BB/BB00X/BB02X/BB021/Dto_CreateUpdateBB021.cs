using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSBS101._82Application.Dto.BB00X.BB021
{
    public class Dto_CreateUpdateBB021
    {
        [Required(ErrorMessage = "O campo 'Bb021Filial' é obrigatório.")]
        [DefaultValue(0)]
        public int? Bb021Filial { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021DataEmissao' é obrigatório.")]
        [DataType(DataType.Date)]
        [DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime? Bb021DataEmissao { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021Autorizacao' é obrigatório.")]
        [DefaultValue(0)]
        public decimal? Bb021Autorizacao { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021Hora' é obrigatório.")]
        [DataType(DataType.Time)]
        [DefaultValue(typeof(DateTime), "1900-01-01")]
        public DateTime? Bb021Hora { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021Codautorizador' é obrigatório.")]
        [DefaultValue(0)]
        public int? Bb021Codautorizador { get; set; }

        [MaxLength(30, ErrorMessage = "O campo 'Bb021NomeAutorizador' pode ter no máximo 30 caracteres.")]
        [DefaultValue("")]
        public string? Bb021NomeAutorizador { get; set; }

        [MaxLength(11, ErrorMessage = "O campo 'Bb021Situacao' pode ter no máximo 11 caracteres.")]
        [DefaultValue("")]
        public string? Bb021Situacao { get; set; }

        [MaxLength(11, ErrorMessage = "O campo 'Bb021Modulo' pode ter no máximo 11 caracteres.")]
        [DefaultValue("")]
        public string? Bb021Modulo { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021Tipo' é obrigatório.")]
        [DefaultValue(0)]
        public int? Bb021Tipo { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021PercentualValor' é obrigatório.")]
        [DefaultValue(0)]
        public decimal? Bb021PercentualValor { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021Codautorizado' é obrigatório.")]
        [DefaultValue(0)]
        public int? Bb021Codautorizado { get; set; }

        [MaxLength(30, ErrorMessage = "O campo 'Bb021NomeAutorizado' pode ter no máximo 30 caracteres.")]
        [DefaultValue("")]
        public string? Bb021NomeAutorizado { get; set; }

        [Required(ErrorMessage = "O campo 'Bb021CodigoProduto' é obrigatório.")]
        [DefaultValue(0)]
        public int? Bb021CodigoProduto { get; set; }
    }
}
