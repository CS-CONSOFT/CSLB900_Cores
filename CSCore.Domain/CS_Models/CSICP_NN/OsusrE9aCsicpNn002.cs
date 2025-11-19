using CSCore.Domain.CS_Models.Staticas.NN;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn002
{
    public int TenantId { get; set; }

    public string Nn002GrupoId { get; set; } = null!;

    public string? Nn002FilialId { get; set; }

    public int? Nn002CodGrupo { get; set; }

    public string? Nn002Descricao { get; set; }

    public int? Nn002TipogrupoId { get; set; }

    public bool? Nn002Isactive { get; set; }

}
