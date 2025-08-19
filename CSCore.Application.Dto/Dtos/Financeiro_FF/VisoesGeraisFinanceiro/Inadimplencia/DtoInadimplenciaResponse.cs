namespace CSCore.Application.Dto.Dtos.Financeiro_FF.VisoesGeraisFinanceiro.Inadimplencia
{
    public class DtoInadimplenciaResponse
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string AnoMes { get; set; } = string.Empty;
        public int QuantidadeTitulosTotal { get; set; }
        public decimal ValorTitulosTotal { get; set; }
        public int QuantidadeTitulosLiquidados { get; set; }
        public decimal ValorTitulosLiquidados { get; set; }
        public int QuantidadeTitulosInadimplentes { get; set; }
        public decimal ValorTitulosInadimplentes { get; set; }
        public decimal PercentualInadimplencia { get; set; }
    }
}