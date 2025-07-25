using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD813
{
    public int TenantId { get; set; }

    public string Dd813Id { get; set; } = null!;

    public int? Dd813CfopId { get; set; }

    public string? Dd813FormapagtoId { get; set; }

    public string? Dd813Anotacao { get; set; }

    public string? Dd813UsuariopropId { get; set; }

    public DateTime? Dd813Dregistro { get; set; }

    public string? Dd813UsuarioaltId { get; set; }

    public DateTime? Dd813Dalteracao { get; set; }
}
