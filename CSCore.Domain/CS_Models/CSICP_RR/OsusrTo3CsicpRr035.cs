using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr035
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr035Descricao { get; set; }

    public string? Rr035Nrosemem { get; set; }

    public string? Rr035Lote { get; set; }

    public string? Rr035Nomefornecedor { get; set; }

    public string? Rr035Identtouro { get; set; }

    public long? Rr035Racaid { get; set; }

    public string? Rr035Nroregtouro { get; set; }

    public DateTime? Rr035Dtcongelamento { get; set; }

    public string? Rr035Volume { get; set; }

    public string? Rr035Concespermatica { get; set; }

    public string? Rr035Observacao { get; set; }

    public virtual ICollection<OsusrTo3CsicpRr031> OsusrTo3CsicpRr031s { get; set; } = new List<OsusrTo3CsicpRr031>();

    public virtual OsusrTo3CsicpRr004? Rr035Raca { get; set; }
}
