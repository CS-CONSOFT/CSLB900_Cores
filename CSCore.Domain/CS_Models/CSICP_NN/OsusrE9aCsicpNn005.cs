using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn005
{
    public int TenantId { get; set; }

    public string Nn005Id { get; set; } = null!;

    public string? Nn001CtacorrenteId { get; set; }

    public string? Nn005Usuarioid { get; set; }

    public string? Nn005Usuariopropid { get; set; }

    public DateTime? Nn005Dinclusao { get; set; }

    public virtual OsusrE9aCsicpNn001? Nn001Ctacorrente { get; set; }
}
