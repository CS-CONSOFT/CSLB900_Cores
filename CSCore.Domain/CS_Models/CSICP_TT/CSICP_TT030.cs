using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_TT;

public partial class CSICP_TT030
{
    public int TenantId { get; set; }

    public long Tt030Id { get; set; }

    public string? Tt030Estabid { get; set; }

    public int? Tt030Protocolonumber { get; set; }

    public DateTime? Tt030Datahora { get; set; }

    public string? Tt030Usuariopropid { get; set; }

    public string? Tt030Usuariovendedorid { get; set; }

    public string? Tt030Observacao { get; set; }

    public string? Tt030Protocolnumber { get; set; }

    public CSICP_BB001? CSICP_BB001 { get; set; }
    public Csicp_Sy001? Csicp_Sy001 { get; set; }
}
