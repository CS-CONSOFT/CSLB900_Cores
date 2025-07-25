using System;
using System.Collections.Generic;

namespace CSCore.Domain;

public partial class Csicp_Sy992
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Auditoriaid { get; set; }

    public string? NomeEntidade { get; set; }

    public string? LabelEntidade { get; set; }

    public string? Registroid { get; set; }

    public string? Nomecampo { get; set; }

    public string? Labelcampo { get; set; }

    public string? Valorantigo { get; set; }

    public string? Valornovo { get; set; }

    public string? Tipodedado { get; set; }

    public int? EspaceidEntidade { get; set; }

    public int? Entidadeid { get; set; }

    public int? Entidateattrid { get; set; }

    public Csicp_Sy991? Auditoria { get; set; }
}
