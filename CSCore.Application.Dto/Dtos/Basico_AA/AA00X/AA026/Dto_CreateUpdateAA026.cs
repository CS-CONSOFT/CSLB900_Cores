using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA026
    {
        [DefaultValue(0)]
        public int? Aa026Codigoregiao { get; set; }

        [MaxLength(60, ErrorMessage = "A descrição deve ter no máximo 60 caracteres.")]
        [DefaultValue("")]
        public string? Aa026Descricao { get; set; }

        [DefaultValue(0)]
        public int? Aa026Codigoibge { get; set; }

        [MaxLength(36, ErrorMessage = "O ID da região de exportação deve ter no máximo 36 caracteres.")]
        [DefaultValue("")]
        public string? Aa026ExportRegiaoid { get; set; }
    }
}
