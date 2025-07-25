using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB005
{
    public class Dto_CreateUpdateBB005
    {
        [Required(ErrorMessage = "O campo Filial é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O campo Filial deve ser maior ou igual a 0.")]
        public int? Bb005Filial { get; set; } = 0;

        [Required(ErrorMessage = "O campo Código é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O campo Código deve ser maior ou igual a 0.")]
        public int? Bb005Codigo { get; set; } = 0;

        [StringLength(90, ErrorMessage = "O campo Nome do Centro de Custo deve ter no máximo 90 caracteres.")]
        [Required(ErrorMessage = "O campo Nome do Centro de Custo é obrigatório.")]
        public string? Bb005Nomeccusto { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Coluna de Impressão é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O campo Coluna de Impressão deve ser maior ou igual a 0.")]
        public int? Bb005Colunaimpressao { get; set; } = 0;

        [StringLength(36, ErrorMessage = "O campo Empresa ID deve ter no máximo 36 caracteres.")]
        public string? Empresaid { get; set; } = null;
    }
}


  

