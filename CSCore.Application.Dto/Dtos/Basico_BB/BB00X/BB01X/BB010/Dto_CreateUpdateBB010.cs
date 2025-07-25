
using System.ComponentModel.DataAnnotations;

namespace CSBS101._82Application.Dto.BB00X.BB010
{

    public class Dto_CreateUpdateBB010
    {
        public int? Bb010Codigo { get; set; }

        [StringLength(100, ErrorMessage = "A zona não pode exceder 100 caracteres.")]
        public string? Bb010Zona { get; set; }

        public int? Bb010CodVendedor { get; set; } = 0;

        public int? Bb010ColPrecoTabela { get; set; }

        [StringLength(50, ErrorMessage = "O ID do banco 01 não pode exceder 50 caracteres.")]
        public string? Bb010Banco01Id { get; set; }

        [StringLength(50, ErrorMessage = "O ID do banco 02 não pode exceder 50 caracteres.")]
        public string? Bb010Banco02Id { get; set; }

        [StringLength(50, ErrorMessage = "O ID do banco 03 não pode exceder 50 caracteres.")]
        public string? Bb010Banco03Id { get; set; }

        [StringLength(50, ErrorMessage = "O ID do centro de custo não pode exceder 50 caracteres.")]
        public string? Bb010CcustoId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor de Km deve ser positivo.")]
        public int? Bb010Km { get; set; }

        public string? Bb010FoneContato { get; set; } = null;

        public int? Bb010Promotor { get; set; }

        [StringLength(500, ErrorMessage = "A observação não pode exceder 500 caracteres.")]
        public string? Bb010Observacao { get; set; }

        public int? Bb010PeriodoRota { get; set; }

        public int? Bb010PeriodoVisita { get; set; }

        [StringLength(100, ErrorMessage = "A tabela de preço não pode exceder 100 caracteres.")]
        public string? Bb010TabelaPreco { get; set; }

        [StringLength(50, ErrorMessage = "O ID do vendedor não pode exceder 50 caracteres.")]
        public string? Bb010Vendedorid { get; set; }

        public int? Bb010Tiporotaid { get; set; }

        [StringLength(50, ErrorMessage = "O ID da cidade não pode exceder 50 caracteres.")]
        public string? Bb010Cidadeid { get; set; }
    }
}

