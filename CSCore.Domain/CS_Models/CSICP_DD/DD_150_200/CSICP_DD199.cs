using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD199
{
    public int TenantId { get; set; }

    public long Dd199Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public string? Dd199Usuarioid { get; set; }

    public DateTime? Dd199Datahora { get; set; }

    public string? Gg073Id { get; set; }

    public string? Bb007Respid { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }
}
