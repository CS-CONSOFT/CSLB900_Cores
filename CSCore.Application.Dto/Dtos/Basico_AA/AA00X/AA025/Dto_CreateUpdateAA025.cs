using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.AA00X
{
    public class Dto_CreateUpdateAA025
    {
        [DefaultValue(0)]
        public int? Aa025Codigopais { get; set; }

        [MaxLength(60, ErrorMessage = "A descrição deve ter no máximo 60 caracteres.")]
        [DefaultValue("")]
        public string? Aa025Descricao { get; set; }

        [DefaultValue(0)]
        public int? Aa025Codigobacen { get; set; }

        [DefaultValue(0)]
        public int? Aa025Codigosiscomex { get; set; }

        [DefaultValue(false)]
        public bool? Aa025Isactive { get; set; }

        [MaxLength(50, ErrorMessage = "A nacionalidade deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa025Nacionalidade { get; set; }

        [MaxLength(2, ErrorMessage = "O código ISO3166 A2 deve ter no máximo 2 caracteres.")]
        [DefaultValue("")]
        public string? Aa025Iso3166A2 { get; set; }

        [MaxLength(3, ErrorMessage = "O código ISO3166 A3 deve ter no máximo 3 caracteres.")]
        [DefaultValue("")]
        public string? Aa025Iso3166A3 { get; set; }

        [DefaultValue(0)]
        public int? Aa025Iso3166N3 { get; set; }

        [MaxLength(50, ErrorMessage = "O ID do país de exportação deve ter no máximo 50 caracteres.")]
        [DefaultValue("")]
        public string? Aa025ExportPaisid { get; set; }

        [DefaultValue(0)]
        public int? Aa025CodigoNacoesunidas { get; set; }
    }
}
