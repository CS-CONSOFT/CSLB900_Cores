using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSBS101._82Application.Dto.BB00X.BB024
{
    public class Dto_CreateUpdateBB024
    {
        [DefaultValue(null)]
        public int? Bb024CfopId { get; set; }

        [MaxLength(36, ErrorMessage = "O campo 'Bb025NatoperacaoId' pode ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Bb025NatoperacaoId { get; set; }
    }
}
