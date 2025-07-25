using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD896
{
    public int TenantId { get; set; }

    public long Dd896Id { get; set; }

    public string? Bb001Id { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd070Id { get; set; }

    public string? Pd010Id { get; set; }

    public DateTime? Dd886Dregistro { get; set; }

    public DateTime? Dd886Dmovto { get; set; }

    public int? Dd886Qimpressoes { get; set; }

    public string? Dd886Usuariopropid { get; set; }

    public DateTime? Dd886Dimpressao { get; set; }

    public string? Dd886Ultimpusuarioid { get; set; }

    public string? Dd896Url { get; set; }

    public string? Dd896Hash { get; set; }

    public int? Dd896Tipo { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }
}
