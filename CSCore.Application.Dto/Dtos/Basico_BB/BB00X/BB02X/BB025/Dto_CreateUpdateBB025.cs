using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB025
{
    public class Dto_CreateUpdateBB025
    {
        [DefaultValue(0)]
        public int? Bb025Filial { get; set; }

        [MaxLength(10, ErrorMessage = "O campo 'Bb025Codigo' pode ter no máximo 10 caracteres.")]
        [DefaultValue("")]
        public string? Bb025Codigo { get; set; }

        [MaxLength(60, ErrorMessage = "O campo 'Bb025Descricao' pode ter no máximo 60 caracteres.")]
        [DefaultValue("")]
        public string? Bb025Descricao { get; set; }

        [MaxLength(36, ErrorMessage = "O campo 'Empresaid' pode ter no máximo 36 caracteres.")]
        [DefaultValue(null)]
        public string? Empresaid { get; set; }
        public int? Bb025ModdoctofiscalId { get; set; }
        public bool? Bb025Isactive { get; set; }

    }
}
