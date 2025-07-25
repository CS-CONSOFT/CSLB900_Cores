using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB037
{
    public class Dto_CreateUpdateBB037
    {
        [MaxLength(10, ErrorMessage = "O código deve ter no máximo 10 caracteres.")]
        public string? Bb037Codigo { get; set; }

        [MaxLength(50, ErrorMessage = "A descrição deve ter no máximo 50 caracteres.")]
        public string? Bb037Descricao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O dia deve ser um número não negativo.")]
        public int? Bb037Dia { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A quantidade de dias deve ser um número não negativo.")]
        public int? Bb037Qtddiasmcompra { get; set; }

        public bool? Bb037IsActive { get; set; }
    }
}
