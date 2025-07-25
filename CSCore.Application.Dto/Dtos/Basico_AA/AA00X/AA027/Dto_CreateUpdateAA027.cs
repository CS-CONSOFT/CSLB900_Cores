using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA027
    {
        [MaxLength(2, ErrorMessage = "A sigla deve ter no máximo 2 caracteres.")]
        [DefaultValue("")]
        public string? Aa027Sigla { get; set; }

        [MaxLength(60, ErrorMessage = "A descrição deve ter no máximo 60 caracteres.")]
        [DefaultValue("")]
        public string? Descricao { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [DefaultValue(0.0)]
        public decimal? Aa027Percicmscontrib { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [DefaultValue(0.0)]
        public decimal? Aa027Percicmsncontrib { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [DefaultValue(0.0)]
        public decimal? Aa027Percsubsttribut { get; set; }

        [MaxLength(30, ErrorMessage = "A máscara IE estadual deve ter no máximo 30 caracteres.")]
        [DefaultValue("")]
        public string? Aa027Mascinsestadual { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [DefaultValue(0.0)]
        public decimal? Aa027Percicmsentrada { get; set; }

        [MaxLength(30, ErrorMessage = "A máscara IE impressão deve ter no máximo 30 caracteres.")]
        [DefaultValue("")]
        public string? Aa027Mascieimpressao { get; set; }

        [DefaultValue(0)]
        public int? Aa027Codigoibge { get; set; }

        [MaxLength(36)]
        public string? Paisid { get; set; }

        [MaxLength(36)]
        public string? Regiaoid { get; set; }

        [MaxLength(50, ErrorMessage = "A naturalidade deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa027Naturalidade { get; set; }

        [MaxLength(50, ErrorMessage = "O ID de exportação UF deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa027ExportUfid { get; set; }

        [MaxLength(50, ErrorMessage = "O ID de exportação País deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa025ExportPaisid { get; set; }

        [MaxLength(50, ErrorMessage = "O ID de exportação Região deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa026ExportRegiaoid { get; set; }
    }
}
