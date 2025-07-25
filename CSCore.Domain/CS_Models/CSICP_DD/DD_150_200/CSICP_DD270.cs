using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD270
{
    public int TenantId { get; set; }

    public string Dd270Id { get; set; } = null!;

    public string? Dd270EmpresaId { get; set; }

    public DateTime? Dd270Datarecebimento { get; set; }

    public string? Dd270Usuariopropr { get; set; }

    public string? Dd270Anotacao { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd270Chavenfe { get; set; }

    public string? Dd270Versaoxml { get; set; }

    public bool? Dd270Iscontaspagar { get; set; }

    public string? Dd270FormapgtoId { get; set; }

    public string? Dd270CondpagtoId { get; set; }

    public string? Dd270Nomefabricante { get; set; }

    public long? Dd270Ultnrocsdfeid { get; set; }

    public string? Dd270Prtnumber { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD271Ide? OsusrDfwCsicpDd271Ide { get; set; }

    public virtual CSICP_DD273Xml? OsusrDfwCsicpDd273Xml { get; set; }
}
