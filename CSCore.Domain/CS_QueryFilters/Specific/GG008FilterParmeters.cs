using System.ComponentModel.DataAnnotations;

namespace CSLB900.MSTools.CS_QueryFilters.Specific
{
    public class GG008FilterParmeters
    {
        [Required]
        public int PageNumber { get; set; } = 1;
        [Required]
        public int PageSize { get; set; }
        public string? Search { get; set; } = null;
        public decimal? SearchCode { get; set; } = null;
        public string? GrupoDescricao { get; set; }
        public string? ClasseDescricao { get; set; }
        public string? MarcaDescricao { get; set; }
        public string? ArtigoDescricao { get; set; }
        public bool? IsForaDaLinha { get; set; }
        public string? SubGrupoDescricao { get; set; }
        public bool? IsECommerce { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        public bool? IsComNcm { get; set; }

    }
}
