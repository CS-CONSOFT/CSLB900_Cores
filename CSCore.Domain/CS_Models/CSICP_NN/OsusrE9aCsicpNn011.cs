using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn011
{
    public int TenantId { get; set; }

    public string Nn011Id { get; set; } = null!;

    public string? Nn011CtacorrenteId { get; set; }

    public string? Nn011FilialId { get; set; }

    public int? Nn011CodgFilial { get; set; }

    public int? Nn011CodCc { get; set; }

    public DateTime? Nn011Data { get; set; }

    public decimal? Nn011SaldoAnterior { get; set; }

    public decimal? Nn011TotalCheques { get; set; }

    public decimal? Nn011TotalDeposito { get; set; }

    public decimal? Nn011TotalEntradas { get; set; }

    public decimal? Nn011TotalSaidas { get; set; }

    public decimal? Nn011SaldoDoDia { get; set; }

    public bool? Nn011Isfechado { get; set; }

    public string? Nn011PkSldanteriorId { get; set; }

    
}
