using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSBS101._82Application.Dto.BB00X.BB002
{
    public class Dto_BB002CreateUpdate
    {
        [MaxLength(36, ErrorMessage = "O ID deve ter no máximo 36 caracteres.")]
        public string? Id { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O código deve ser um número positivo.")]
        public int? Bb002Codigo { get; set; } = default;

        [MaxLength(60, ErrorMessage = "O grupo da empresa deve ter no máximo 60 caracteres.")]
        [DefaultValue("")]
        public string? Bb002Grupoempresa { get; set; } = null;

        [MaxLength(50, ErrorMessage = "O nome do bucket AWS deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Bb003AwsBucket { get; set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "O AccessKeyId da AWS deve ter no máximo 100 caracteres.")]
        [DefaultValue("")]
        public string? Bb003Awsaccesskeyid { get; set; } = string.Empty;

        [MaxLength(50, ErrorMessage = "A região da AWS deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Bb003Awsregion { get; set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "O SecretAccessKey da AWS deve ter no máximo 100 caracteres.")]
        [DefaultValue("")]
        public string? Bb003Awssecretaccesskey { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "O número de domínio deve ser um número positivo.")]
        public int? CixNrodominio { get; set; } = default;

        [MaxLength(36, ErrorMessage = "O token deve ter no máximo 36 caracteres.")]
        [DefaultValue("")]
        public string? CixToken { get; set; } = string.Empty;

        [MaxLength(250, ErrorMessage = "A URL do serviço web CIX deve ter no máximo 250 caracteres.")]
        [DefaultValue("")]
        public string? CixUrlWebservicecix { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo de uso do CIX é obrigatório.")]
        public bool? CixUsacix { get; set; } = false;

        public string? TenantId { get; set; }
    }
}
