using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF118
{
    public int TenantId { get; set; }

    public string Ff118Id { get; set; } = null!;

    public string? Ff118TituloId { get; set; }

    public string? Ff118AutorizadorId { get; set; }

    public DateTime? Ff118Datahora { get; set; }

    public int? Ff118NivelatualId { get; set; }

    public int? Ff118Statusautorizacao { get; set; }

    public int? Ff118ProxnivelId { get; set; }

    public int? ProcessId { get; set; }

    public int? ActivityId { get; set; }

    public string? Ff118Mensagem { get; set; }

    public virtual CSICP_FF102? Ff118Titulo { get; set; }
}
