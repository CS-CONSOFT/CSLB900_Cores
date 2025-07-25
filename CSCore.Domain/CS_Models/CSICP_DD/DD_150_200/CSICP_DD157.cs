using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD157
{
    public int TenantId { get; set; }

    public int Dd157Id { get; set; }

    public string? Gg008Produtoid { get; set; }

    public string? Gg008Produtosecid { get; set; }

    public string? Dd157Descricao { get; set; }

    public decimal? Dd157Qtd { get; set; }
}
