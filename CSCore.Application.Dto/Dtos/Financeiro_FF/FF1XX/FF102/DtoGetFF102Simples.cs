namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF102
{
    public class DtoGetFF102Simples
    {
        public int TenantId { get; set; }
        public string Id { get; set; } = null!;
        public int? Ff102Tiporegistro { get; set; }
        public string? Ff102Filialid { get; set; }
        public string? Ff102Pfx { get; set; }
        public decimal? Ff102NoTitulo { get; set; }
        public string? Ff102Sfx { get; set; }
        public string? Ff102Contaid { get; set; }
        public DateTime? Ff102DataEmissao { get; set; }
        public DateTime? Ff102DataVencimento { get; set; }
        public decimal? Ff102ValorTitulo { get; set; }
        public int? Ff102Situacao { get; set; }
        public int? Ff102Situacaoid { get; set; }
    }
}