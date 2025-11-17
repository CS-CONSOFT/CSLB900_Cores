using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn003
{
    public int TenantId { get; set; }

    public string Nn003Id { get; set; } = null!;

    public string? Nn003GrupoId { get; set; }

    public string? Nn003FilialId { get; set; }

    public int? Nn003Filial { get; set; }

    public int? Nn003Codggrupo { get; set; }

    public int? Nn003Ano { get; set; }

    public int? Nn003Mes { get; set; }

    public decimal? Nn003VlrProvisaoRec { get; set; }

    public decimal? Nn003Vlrrealizadorec { get; set; }

    public decimal? Nn003Vlrprovisaodesp { get; set; }

    public decimal? Nn003Vlrrealizadodesp { get; set; }

}
