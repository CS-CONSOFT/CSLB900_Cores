using CSLB900.MSTools.CS_QueryFilters;
using System.ComponentModel.DataAnnotations;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG021
{
    public class PrmFiltrosCG021Repo : ParametrosBaseFiltro
    {
        [Required(ErrorMessage = "O parâmetro LoteId (ID do lote CG020) é obrigatório.")]
        public string LoteId { get; set; } = null!; // Obrigatório
        public string? FilialId { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFinal { get; set; }
    }
}