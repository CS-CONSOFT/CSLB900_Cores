using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr020
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr020Identificador { get; set; }

    public string? Rr020Descricao { get; set; }

    public DateTime? Rr020Dtinicio { get; set; }

    public DateTime? Rr020Dtfinal { get; set; }

    public long? Rr020Regalimentarid { get; set; }

    //public virtual ICollection<OsusrTo3CsicpRr021> OsusrTo3CsicpRr021s { get; set; } = new List<OsusrTo3CsicpRr021>();

    public OsusrTo3CsicpRr008? NavRR008RegAlimentar_RR020 { get; set; }
}
