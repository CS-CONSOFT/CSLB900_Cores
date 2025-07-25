using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD805
{
    public int TenantId { get; set; }

    public string Dd805Id { get; set; } = null!;

    public string? Dd805EstabelecimentoId { get; set; }

    public DateTime? Dd805Anomesmovimento { get; set; }

    public string? Dd805ProdutoId { get; set; }

    public decimal? Dd805Tvenda { get; set; }

    public decimal? Dd805Pvendaabc { get; set; }

    public string? Dd805Vendaabc { get; set; }

    public decimal? Dd805Pvendapartic { get; set; }

    public decimal? Dd805Pvendaacm { get; set; }

    public decimal? Dd805Tqtd { get; set; }

    public decimal? Dd805Pqtdabc { get; set; }

    public string? Dd805Qtdabc { get; set; }

    public decimal? Dd805Pqtdpartic { get; set; }

    public decimal? Dd805Pqtdacm { get; set; }

    public decimal? Dd805Qtdmin { get; set; }

    public decimal? Dd805Qtdmax { get; set; }

    public decimal? Dd805Vvendamin { get; set; }

    public decimal? Dd805Vvendamax { get; set; }

    public decimal? Dd805Vvendamedia { get; set; }

    public decimal? Dd805Qtdmedia { get; set; }

    public decimal? Dd805Qsaldoestq { get; set; }

    public int? Dd805Qdiasuteis { get; set; }

    public int? Dd805Tempomedioestq { get; set; }

    public int? Dd805CountLinha { get; set; }
}
