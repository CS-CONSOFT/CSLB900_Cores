using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg900
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg900Empresaid { get; set; }

    public string? Gg900Produtoid { get; set; }

    public string? Gg900Saldoid { get; set; }

    public string? Gg900Usuarioid { get; set; }

    public string? Gg900Chaveprograma { get; set; }

    public decimal? Gg900QtdeCesta { get; set; }

    public string? Gg900Chave { get; set; }

    public DateTime? Gg900Createon { get; set; }

    public decimal? Gg900Valor { get; set; }

    public decimal? Gg900Percentual { get; set; }

    public CSICP_GG008? Gg900Produto { get; set; }

    public CSICP_GG520? Gg900Saldo { get; set; }
}
