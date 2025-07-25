using CSCore.Domain.CS_Models.Staticas.GG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg902
{
    public int TenantId { get; set; }

    public long Gg902Id { get; set; }

    public string? Gg902Saldoid { get; set; }

    public decimal? Gg902Slddisponnodia { get; set; }

    public decimal? Gg902Qaferida { get; set; }

    public string? Gg902Usuariopropid { get; set; }

    public DateTime? Gg902Dregistro { get; set; }

    public string? Gg902Observacao { get; set; }

    public int? Gg902Statusid { get; set; }

    public string? Gg902EstabId { get; set; }

    public string? Gg902Almoxid { get; set; }

    public DateTime? Gg902Dmovimento { get; set; }

    public DateTime? Gg902Dsaldodia { get; set; }

    public string? Gg902Motivoid { get; set; }

    public CSICP_GG001? Gg902Almox { get; set; }

    public CSICP_GG520? Gg902Saldo { get; set; }

    public OsusrE9aCsicpGg902St? Gg902Status { get; set; }
}
