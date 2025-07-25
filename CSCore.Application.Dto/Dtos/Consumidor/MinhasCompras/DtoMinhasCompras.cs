namespace CSCore.Application.Dto.Dtos.Consumidor.MinhasCompras
{
    public class DtoMinhasCompras
    {
        public DateTime? Emissao { get; set; } = default;
        public string Serie { get; set; } = string.Empty;
        public decimal? CompraValor { get; set; } = default;

        public List<DtoGetProduto> Produtos { get; set; } = [];
    }
}
