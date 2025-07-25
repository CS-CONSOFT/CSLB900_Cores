using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSBS101._82Application.Dto.BB00X.BB002.CSC
{
    public class Dto_BB002CSC_CreateUpdate
    {
        [MaxLength(36, ErrorMessage = "O ID deve ter no máximo 36 caracteres.")]
        public string? Id { get; set; }

        [MaxLength(36, ErrorMessage = "O Estabelecimento ID deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Bb001Estabid { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O CID Token deve ser um número positivo.")]
        public int? Bb002Cidtoken { get; set; } = 0;

        [MaxLength(36, ErrorMessage = "O CSC deve ter no máximo 36 caracteres.")]
        [DefaultValue("")]
        public string? Bb002Csc { get; set; } = string.Empty;


        public string? Bb002Dataativacao { get; set; } = "";

        
        public string? Bb002Datarevogacao { get; set; } = "";

        [MaxLength(36, ErrorMessage = "O ID de Revogação deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Bb002Id { get; set; }

        [DefaultValue(false)]
        public bool? Bb002Isrevogado { get; set; } = false;

        [MaxLength(255, ErrorMessage = "O motivo de revogação deve ter no máximo 255 caracteres.")]
        [DefaultValue("")]
        public string? Bb002Motivorevogacao { get; set; } = string.Empty;

        public string? TenantId { get; set; }
    }
}
