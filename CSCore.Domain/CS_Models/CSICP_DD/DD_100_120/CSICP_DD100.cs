using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD100
{
    public int TenantId { get; set; }

    public string Dd100Id { get; set; } = null!;

    public string? Dd100FilialId { get; set; }

    public string? Dd100EmailGerencia { get; set; }

    public string? Dd100EmailDiretor { get; set; }

    public string? Dd100SmsGerencia { get; set; }

    public string? Dd100SmsDiretor { get; set; }

    public decimal? Dd100Tempomaxhoras { get; set; }

    public decimal? Dd100PercIndiceMinimo { get; set; }

    public decimal? Dd100ValorCargaInterno { get; set; }

    public int? Dd100Qdiasmax { get; set; }

    public string? Dd100VeiculoId { get; set; }

    public string? Dd100MotoristaId { get; set; }
}
