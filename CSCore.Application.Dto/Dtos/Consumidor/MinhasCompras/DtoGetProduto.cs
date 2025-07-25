namespace CSCore.Application.Dto.Dtos.Consumidor.MinhasCompras
{
    public class DtoGetProduto
    {
        public string? Produto { get; set; } = string.Empty;
        public decimal? Quantidade { get; set; } = default;
        public string? Unidade { get; set; } = string.Empty;
        public decimal? ValorTotal { get; set; } = default;
        public string? Imagem { get; set; } = string.Empty;
    }
}
