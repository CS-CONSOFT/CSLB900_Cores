using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB066
{
    public class Dto_CreateUpdateBB066
    {
        [Range(1, long.MaxValue, ErrorMessage = "O ID da faixa etária deve ser um valor positivo.")]
        public long? Bb066Fxetariaid { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A faixa 'de' deve ser um valor maior ou igual a zero.")]
        public int? Bb066Faixade { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A faixa 'até' deve ser um valor maior ou igual a zero.")]
        public int? Bb066Faixaate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser um número positivo.")]
        public decimal? Bb066Valor { get; set; }
    }
}
