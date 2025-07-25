using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy017
{
    public int TenantId { get; set; }

    public string Sy017Id { get; set; } = null!;

    public int? Sy017CountRelatorios { get; set; }

    public int? Sy017CountAtualizados { get; set; }

    public DateTime? Sy017Dataultatualizacao { get; set; }

    public string? Sy017Usuarioid { get; set; }

    public int? ProcessId { get; set; }

    public string? Sy017Hashunico { get; set; }

    public string? Sy017Mensagem { get; set; }
}
