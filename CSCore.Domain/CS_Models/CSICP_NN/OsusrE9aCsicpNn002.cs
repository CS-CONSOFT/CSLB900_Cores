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

    public virtual OsusrE9aCsicpNn002Tpgru? Nn002Tipogrupo { get; set; }

    public virtual ICollection<OsusrE9aCsicpNn003> OsusrE9aCsicpNn003s { get; set; } = new List<OsusrE9aCsicpNn003>();

    public virtual ICollection<OsusrE9aCsicpNn010> OsusrE9aCsicpNn010s { get; set; } = new List<OsusrE9aCsicpNn010>();

    public virtual ICollection<CSICP_NN015> OsusrE9aCsicpNn015s { get; set; } = new List<CSICP_NN015>();
}
