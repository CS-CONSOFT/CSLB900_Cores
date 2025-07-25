using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg991
{
    public int TenantId { get; set; }

    public string Gg991OrganogramaId { get; set; } = null!;

    public string? Gg991FilialId { get; set; }

    public string? Gg991UsuarioId { get; set; }

    public string? Gg991UsuarioPaiId { get; set; }

    public string? Gg991Descricao { get; set; }

    public bool? Gg991Isactive { get; set; }

    public int? Gg991Nivel { get; set; }

    public bool? Gg991Atender { get; set; }

    public bool? Gg991Isconfirmar { get; set; }

    public ICollection<OsusrE9aCsicpGg992> OsusrE9aCsicpGg992s { get; set; } = new List<OsusrE9aCsicpGg992>();
}
