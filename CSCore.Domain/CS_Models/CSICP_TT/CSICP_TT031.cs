using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_TT;

public partial class CSICP_TT031
{
    public int TenantId { get; set; }

    public long? Tt031Id { get; set; } = null;

    public long? Tt030Id { get; set; }

    public string? CsCodgproduto { get; set; }

    public decimal? CsQtd { get; set; }

    public decimal? CsValor { get; set; }

    public decimal? CsDesc { get; set; }

    public string? Gg008Id { get; set; }

    public string? Gg008kdxId { get; set; }

    public string? Gg520Id { get; set; }

    public string? Campoespecial1 { get; set; }

    public string? Campoespecial2 { get; set; }
    public string? gg007_UnID { get; set; }
}

public partial class RepoTT031 : CSICP_TT031
{
    public string? Gg008Descreduzida { get; set; }
    public string? Gg001Descalmox { get; set; }
    public decimal? Gg520NsNumerosaldo { get; set; }
}

