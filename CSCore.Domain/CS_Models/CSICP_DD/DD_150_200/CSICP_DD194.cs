using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD194
{
    public int TenantId { get; set; }

    public long Dd194Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public string? Dd194Descricao { get; set; }

    public int? Dd194Ordem { get; set; }

    public byte[]? Dd194Objeto { get; set; }

    public string? Dd194Filetype { get; set; }

    public string? Filename { get; set; }

    public string? Dd194Path { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }
}
