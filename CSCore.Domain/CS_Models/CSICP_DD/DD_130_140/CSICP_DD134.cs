using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD134
{
    public int TenantId { get; set; }

    public string Dd134Id { get; set; } = null!;

    public string? Dd134EstabelecimentoId { get; set; }

    public decimal? Dd134MargemInicial { get; set; }

    public decimal? Dd134MargemFinal { get; set; }

    public decimal? Dd134PercComissao { get; set; }

    public string? Dd134Descricao { get; set; }
}
