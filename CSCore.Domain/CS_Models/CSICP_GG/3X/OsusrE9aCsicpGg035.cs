using CSCore.Domain.CS_Models.Staticas.GG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg035
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg035Filialid { get; set; }

    public string? Gg035Promocaoid { get; set; }

    public string? Gg035KardexId { get; set; }

    public int? Gg035Produto { get; set; }

    public string? Gg035Produtoid { get; set; }

    public decimal? Gg035Codigobarra { get; set; }

    public decimal? Gg035PrecoVenda { get; set; }

    public decimal? Gg035PercPromocao { get; set; }

    public decimal? Gg035PrecoPromocao { get; set; }

    public string? Gg035Codbarrasalfa { get; set; }

    public CSICP_GG008Kdx? Gg035Kardex { get; set; }

    public CSICP_GG034? Gg035Promocao { get; set; }
}
