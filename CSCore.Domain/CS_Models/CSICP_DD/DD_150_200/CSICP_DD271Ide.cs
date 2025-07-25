using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD271Ide
{
    public int TenantId { get; set; }

    public string Dd271IdDd270 { get; set; } = null!;

    public string? Dd271Cuf { get; set; }

    public string? Dd271Cnf { get; set; }

    public string? Dd271Natop { get; set; }

    public string? Dd271Indpag { get; set; }

    public string? Dd271Mod { get; set; }

    public string? Dd271Serie { get; set; }

    public string? Dd271Nnf { get; set; }

    public string? Dd271Demi { get; set; }

    public string? Dd271Dsaient { get; set; }

    public string? Dd271Hsaient { get; set; }

    public string? Dd271Tpnf { get; set; }

    public string? Dd271Cnumfg { get; set; }

    public string? Dd271Tpemis { get; set; }

    public string? Dd271Tpamb { get; set; }

    public string? Dd271ContaId { get; set; }

    public string? Dd271Xped { get; set; }

    public virtual CSICP_DD270 Dd271IdDd270Navigation { get; set; } = null!;
}
