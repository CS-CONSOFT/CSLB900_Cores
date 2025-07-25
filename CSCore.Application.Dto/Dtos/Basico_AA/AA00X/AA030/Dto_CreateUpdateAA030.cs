using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA030
    {

        [MaxLength(150, ErrorMessage = "A descrição deve ter no máximo 150 caracteres.")]
        [DefaultValue("")]
        public string? Aa030Descricao { get; set; }

        [DefaultValue(null)]
        public int? Aa030Tptokenid { get; set; }

        [MaxLength(250, ErrorMessage = "O usuário deve ter no máximo 250 caracteres.")]
        [DefaultValue("")]
        public string? Aa030User { get; set; }

        [MaxLength(250, ErrorMessage = "A senha deve ter no máximo 250 caracteres.")]
        [DefaultValue("")]
        public string? Aa030Senha { get; set; }

        [MaxLength(36, ErrorMessage = "O identificador do estabelecimento deve ter no máximo 36 caracteres.")]
        [DefaultValue(null)]

        public string? Aa030AwsBucket { get; set; }

        public string? Aa030Awsregion { get; set; }

        public string? Aa030Awsaccesskeyid { get; set; }

        public string? Aa030Awssecretaccesske { get; set; }

        public string? Aa030Ospushtoken { get; set; }
        public string? Aa030_PathCertificado { get; set; }
        public string? Aa030Estabid { get; set; }
    }
}
