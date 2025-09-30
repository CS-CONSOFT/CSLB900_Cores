using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF144
{
    public int TenantId { get; set; }

    public long Ff144Id { get; set; }

    public long? Ff144RdId { get; set; }

    public DateTime? Ff144Dhregistro { get; set; }

    public string? Ff144Usuarioproprieid { get; set; }

    public int? Ff144Statusid { get; set; }

    public int? Ff144Execucaoid { get; set; }

    public string? F144Observacao { get; set; }

    public CSICP_FF140? NavFF140 { get; set; }
    public OsusrE9aCsicpFf140Stum? NavFF140StatusFF144 { get; set; }
    public OsusrE9aCsicpFf140Exe? NavFF140ExecucaoFF144 { get; set; }
    public Csicp_Sy001? NavSY001UsuarioFF144 { get; set; }
}
