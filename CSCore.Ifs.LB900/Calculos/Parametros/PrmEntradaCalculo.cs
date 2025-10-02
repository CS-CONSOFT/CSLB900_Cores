using System;

public class PrmEntradaCalculo
{
    public int InTenantID { get; set; }
    public DateTime InDataVencimento { get; set; }
    public int? InDiasLiberacao { get; set; }
    public decimal InValorTitulo { get; set; }
    public decimal? InPercentualCorrecaoMonetaria { get; set; }
    public decimal? InPercentualMulta { get; set; }
    public decimal? InPercentualJuros { get; set; }
    public decimal? InPercentualHonorarios { get; set; }
    public string InEstabID { get; set; } = string.Empty;
    public bool InFinacEspJurosMulta { get; set; } = false;

    public static PrmEntradaCalculo CreateInstance(
        int inTenantID,
        DateTime inDataVencimento,
        int? inDiasLiberacao,
        decimal inValorTitulo,
        decimal? inPercentualCorrecaoMonetaria,
        decimal? inPercentualMulta,
        decimal? inPercentualJuros,
        decimal? inPercentualHonorarios,
        string inEstabID,
        bool inFinacEspJurosMulta
    )
    {
        return new PrmEntradaCalculo
        {
            InTenantID = inTenantID,
            InDataVencimento = inDataVencimento,
            InDiasLiberacao = inDiasLiberacao,
            InValorTitulo = inValorTitulo,
            InPercentualCorrecaoMonetaria = inPercentualCorrecaoMonetaria,
            InPercentualMulta = inPercentualMulta,
            InPercentualJuros = inPercentualJuros,
            InPercentualHonorarios = inPercentualHonorarios,
            InEstabID = inEstabID,
            InFinacEspJurosMulta = inFinacEspJurosMulta
        };
    }
}