namespace CSS_MC201MConsumidor.C82Application.Dto.ListaTituloByConta
{
    public class DtoCSICP_FF102Titulos
    {
        public string Id { get; set; } = null!;
        public string? Ff102Pfx { get; set; }
        public decimal? Ff102NoTitulo { get; set; }
        public string? QRCode { get; set; }
        public string? LinhaDigitavel { get; set; }
        public string? ContaBB012 { get; set; }
        public string? Ff102Sfx { get; set; }
        public DateTime? Ff102DataEmissao { get; set; }
        public DateTime? Ff102DataVencimento { get; set; }
        public decimal? Ff102VlLiqTitulo { get; set; }
        public string? NavLabelFF102Situacao { get; set; } = default;
        public decimal? CS_PercentualJuros { get; set; }
        public decimal? CS_PercentualMulta { get; set; }
        public decimal? CS_PercentualHonorarios { get; set; }
        public decimal? CS_PercentualCorrecaoMonetaria { get; set; }
        public int? CS_DiasCarenciaJuros { get; set; }
        public int? CS_DiasCarenciaMulta { get; set; }
        public decimal? CS_ValorJuros { get; set; }
        public decimal? CS_ValorMulta { get; set; }
        public decimal? CS_VlrCorrecaoMonetaria { get; set; }
        public decimal? CS_VlrHonorarios { get; set; }
        public decimal? CS_VlrAPagar { get; set; }
        public int? CS_Atraso { get; set; }
    }
}
