using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB001.BB001Spls
{
    public class Dto_LinkSpls
    {

        [Required(ErrorMessage = "Bb001Id é obrigatório.")]
        public string Bb001Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bb001SimplespartId é obrigatório.")]
        public int Bb001SimplespartId { get; set; }

        public decimal? Bb001AliqSimples { get; set; }

        public decimal? Bb001AliqIrpj { get; set; }

        public decimal? Bb001AliqCsll { get; set; }

        public decimal? Bb001AliqCofins { get; set; }

        public decimal? Bb001AliqPisPasep { get; set; }

        public decimal? Bb001AliqCpp { get; set; }

        public decimal? Bb001AliqIcms { get; set; }

        public decimal? Bb001AliqIpi { get; set; }

        public decimal? Bb001AliqIss { get; set; }
    }
}
