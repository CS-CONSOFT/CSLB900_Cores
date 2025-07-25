using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD014
{
    public int TenantId { get; set; }

    public string Dd014Id { get; set; } = null!;

    public string? Dd014Empresaid { get; set; }

    public string? Dd014Descricao { get; set; }

    public DateTime? Dd014Dataemissao { get; set; }

    public string? Dd014Contaid { get; set; }

    public int? Dd014Vigencia { get; set; }

    public int? Dd014TipovigenciaId { get; set; }

    public string? Dd014Protocolnumber { get; set; }
}
