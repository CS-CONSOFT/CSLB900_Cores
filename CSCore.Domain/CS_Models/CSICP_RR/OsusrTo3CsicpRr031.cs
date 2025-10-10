using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrTo3CsicpRr031
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr031IatfId { get; set; }

    public string? Rr031Animalid { get; set; }

    public DateTime? Rr031Dtregistro { get; set; }

    public bool? Rr031Ispositivo { get; set; }

    public string? Rr031Montaanimalid { get; set; }

    public string? Rr031Semenid { get; set; }

    public virtual OsusrTo3CsicpRr001? Rr031Animal { get; set; }

    public virtual OsusrTo3CsicpRr030? Rr031Iatf { get; set; }

    public virtual OsusrTo3CsicpRr001? Rr031Montaanimal { get; set; }

    public virtual OsusrTo3CsicpRr035? Rr031Semen { get; set; }
}
