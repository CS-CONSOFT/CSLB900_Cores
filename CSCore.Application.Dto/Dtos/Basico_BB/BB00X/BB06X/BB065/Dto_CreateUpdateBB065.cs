using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB06X.BB065
{
    public class Dto_CreateUpdateBB065
    {
        [Range(1, long.MaxValue, ErrorMessage = "O ID da faixa etária deve ser um valor positivo.")]
        public long? Bb064Fxetariaid { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "O ID do convênio deve ser um valor positivo.")]
        public long? Bb062Convenioid { get; set; }
    }
}
